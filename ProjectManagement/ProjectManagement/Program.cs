﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using LibraryLogin;
using ProjectManagement.MyForm;

namespace ProjectManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            FormCollection forms = Application.OpenForms;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            var processss = from proc in System.Diagnostics.Process.GetProcessesByName("ProjectManagement") orderby proc.ProcessName ascending select proc;

            if (processss.Count() > 1)
            {
                MessageBox.Show("Chương trình này đã bật");
                return;
            }
            Application.Run(new FrmMain());
            //bool temp;
            //do
            //{
            //    temp = false;
            //    Frm_Login a = new Frm_Login();
            //    a.lb_programName.Text = "           ProjectManagement";
            //    a.lb_vision.Text = "Phiên bản :";
            //    a.grb_1.Text = "Thông Tin PC";
            //    a.lb_machine.Text = "Tên PC :";
            //    a.lb_user_window.Text = "Tài khoản window:";
            //    a.lb_ip.Text = "Địa chỉ IP :";
            //    a.grb_2.Text = "Thông Tin Tài Khoản Đăng Nhập";
            //    a.lb_username.Text = "Tên đăng nhập :";
            //    a.lb_password.Text = "Mật khẩu :";
            //    a.lb_role.Text = "Vai trò :";
            //    a.lb_date.Text = "Ngày: ";
            //    a.lb_time.Text = "Giờ: ";
            //    a.lb_batchno.Text = "BatchName: ";
            //    a.btn_thoat.Text = "Thoát";
            //    a.chb_hienthi.Text = "Hiển Thị";
            //    a.chb_luu.Text = "Lưu";
            //    a.lb_version.Text = @"1.0";
            //    a.UrlUpdateVersion = @"\\10.10.10.254\DE_Viet\2017\ProjectManagement";
            //    a.cbb_batchname.Visible = false;
            //    a.cbb_batchname.Text = " ";
            //    a.lb_batchno.Visible = false;
            //    a.LoginEvent += a_LoginEvent;
            //    a.ButtonLoginEven += a_ButtonLoginEven;
            //    if (a.ShowDialog() == DialogResult.OK)
            //    {
            //        Global.StrMachine = a.StrMachine;
            //        Global.StrUserWindow = a.StrUserWindow;
            //        Global.StrIpAddress = a.StrIpAddress;
            //        Global.StrUsername = a.StrUserName;
            //        Global.StrBatch = a.StrBatch;
            //        Global.StrRole = a.StrRole;
            //        Global.Strtoken = a.Token;
            //        FrmMain f = new FrmMain();
            //        if (f.ShowDialog() == DialogResult.Yes)
            //        {
            //            f.Close();
            //            temp = true;
            //        }
            //    }
            //}
            //while (temp);
        }

        private static void a_ButtonLoginEven(int iLogin, string strMachine, string strUserWindow, string strIpAddress, string strUsername, string password, string strBatch, string strRole, string strToken, ref bool loginOk)
        {
            if (iLogin != 1) return;
            //Kiểm tra Token
            bool has = Global.db_BPO.tbl_TokenLogins.Any(w => w.UserName == strUsername && w.IDProject == Global.StrIdProject);
            if (has)
            {
                var token = (from w in Global.db_BPO.tbl_TokenLogins
                    where w.UserName == strUsername && w.IDProject == Global.StrIdProject
                    select w.Token).FirstOrDefault();
                if (token == "")
                {
                    Global.db_BPO.updateToken(strUsername, Global.StrIdProject, strToken);
                    Global.db_BPO.InsertLoginTime(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress,
                        strToken);
                    loginOk = true;
                }
                else
                {
                    if (
                        MessageBox.Show("User này đã đăng nhập ở máy khác. Bạn có muốn tiếp tục đăng nhập?",
                            "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Global.db_BPO.updateToken(strUsername, Global.StrIdProject, strToken);
                        Global.db_BPO.InsertLoginTime(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress,
                            strToken);
                        loginOk = true;
                    }
                    else
                    {
                        loginOk = false;
                    }
                }
            }
            else
            {
                var token = new tbl_TokenLogin();
                token.UserName = strUsername;
                token.IDProject = Global.StrIdProject;
                token.Token = "";
                token.DateLogin = DateTime.Now;
                Global.db_BPO.tbl_TokenLogins.InsertOnSubmit(token);
                Global.db_BPO.SubmitChanges();
                loginOk = true;
                Global.db_BPO.updateToken(strUsername, Global.StrIdProject, strToken);
                Global.db_BPO.InsertLoginTime(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress,
                    strToken);
            }
        }

        private static void a_LoginEvent(string username, string password, ref string strVersion, ref int iKiemtraLogin, ref string role, ref ComboBox cbb)
        {
            try
            {
                iKiemtraLogin = Global.db_BPO.KiemTraLogin(username, password);
                strVersion = (from w in Global.db_BPO.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting to server, please check your connection Internet\r\n" + e.Message);
            }
        }
    }
}
