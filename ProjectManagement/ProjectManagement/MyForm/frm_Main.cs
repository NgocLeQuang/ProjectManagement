﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraTabbedMdi;

namespace ProjectManagement.MyForm
{
    public partial class FrmMain : XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                return;
            }
            Global.db_BPO.UpdateTimeLogout(Global.Strtoken);
            Global.db_BPO.ResetToken(Global.StrUsername, Global.StrIdProject, Global.Strtoken);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }
        private bool CheckActivate(Type type)
        {
            foreach (var item in tabbedView1.Documents)
            {
                if (item.Control.GetType() == type)
                {
                    tabbedView1.Controller.Activate(item);
                    return true;
                }
            }return false;
        }
       
        private void btn_quanly_user_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActivate(typeof(frm_ManagerUser))) return;
            var form = new frm_ManagerUser {MdiParent = this};
            form.Show();
        }

        private void btn_quanly_duan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActivate(typeof(frm_PhanCong))) return;
            var form = new frm_PhanCong {MdiParent = this};
            form.Show();
        }

        private void btn_tiendo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActivate(typeof(frm_TienDo))) return;
            var form = new frm_TienDo() {MdiParent = this};
            form.Show();
        }

        private void btn_deadline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActivate(typeof(frm_Deadline))) return;
            var form = new frm_Deadline() {MdiParent = this};
            form.Show();
        }
        
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
