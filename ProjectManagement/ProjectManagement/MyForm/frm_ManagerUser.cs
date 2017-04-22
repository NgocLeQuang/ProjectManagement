using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProjectManagement.MyForm
{
    public partial class frm_ManagerUser : XtraForm
    {
        public frm_ManagerUser()
        {
            InitializeComponent();
        }

        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void frm_ManagerUser_Load(object sender, EventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Unable to connect to Server. Please check your internet connection");
                return;
            }
            dgv_listuser.DataSource = null;
            dgv_listuser.DataSource = Global.db_BPO.GetListUser();
            txt_role.DataSource = Global.db_BPO.tbl_Roles;
            txt_role.DisplayMember = "RoleName";
            txt_role.ValueMember = "RoleID";
        }
       private void gridView1_RowCellDefaultAlignment(object sender, DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs e)
        {
            try
            {
                txt_username.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username") != null? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username").ToString(): "";
                //txt_password.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Password") != null? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Password").ToString(): "";
                txt_nhanvien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FullName") != null? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FullName").ToString(): "";
                txt_role.SelectedValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IDRole") != null? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IDRole").ToString(): "";
                txt_group.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Group_Level") != null? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Group_Level").ToString(): "";
            }
            catch (Exception i)
            {
                MessageBox.Show("Error: " + i);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.db_BPO.DatabaseExists())
                {
                    MessageBox.Show("Unable to connect to Server. Please check your internet connection");
                    return;
                }
                var token = (from w in Global.db_BPO.tbl_TokenLogins where w.Token==Global.StrUsername select w.Token).FirstOrDefault();
                if (token == Global.Strtoken)
                {
                    string pass = GetMd5Hash(txt_password.Text);

                    if (!string.IsNullOrEmpty(txt_nhanvien.Text) && !string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(pass))
                    {
                        //int r = Global.db_BPO.InsertUser(txt_username.Text, pass, null, txt_nhanvien.Text);
                        int r = Global.db_BPO.InsertUsername(txt_username.Text, txt_password.Text,txt_role.Text, txt_nhanvien.Text,txt_group.Text);
                        if (r == 0)
                        {
                            MessageBox.Show("UserName already exists, Please enter another UserName !");
                            //MessageBox.Show("UserName đã tồn tại, Vui lòng nhập tên User khác !");
                        }
                        if (r == 1)
                        {
                            MessageBox.Show("Added UserName '" + txt_username.Text + "' !");
                            frm_ManagerUser_Load(sender, e);
                            txt_username.Text = "";
                            txt_nhanvien.Text = "";
                            txt_password.Text = "";
                            txt_username.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter the full information before saving!");
                        //MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu!");
                    }
                }
                else
                {
                   MessageBox.Show("Your username is logged in on another PC, please log in again and repeat transactions!");
                    //MessageBox.Show("UserName của bạn đang đăng nhập ở máy tính khác, Vui lòng đăng nhập lại!");
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error: " + i);
                //MessageBox.Show("Lỗi: " + i);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.db_BPO.DatabaseExists())
                {
                    MessageBox.Show("Unable to connect to Server. Please check your internet connection");
                    return;
                }
                var token = (from w in Global.db_BPO.tbl_TokenLogins where w.Token == Global.StrUsername select w.Token).FirstOrDefault();
                if (token == Global.Strtoken)
                {
                    string pass = GetMd5Hash(txt_password.Text);

                    if (!string.IsNullOrEmpty(txt_nhanvien.Text) && !string.IsNullOrEmpty(txt_username.Text) &&
                        !string.IsNullOrEmpty(pass))
                    {
                        DialogResult thongbao =MessageBox.Show("You sure want to edit UserName information '" + txt_username.Text + "'","Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //DialogResult thongbao = MessageBox.Show("Bạn muốn sửa thông tin UserNamme '" + txt_username.Text + "' ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (thongbao == DialogResult.Yes)
                        {
                            //Global.db_BPO.UpdateUser(txt_username.Text, pass, null, txt_nhanvien.Text);
                            Global.db_BPO.UpdateUsername(txt_username.Text,txt_password.Text,txt_role.Text,txt_nhanvien.Text,txt_group.Text);
                            frm_ManagerUser_Load(sender,e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter full information before saving !");
                    }
                }
                else
                {
                    MessageBox.Show("Your UserName is logging in at another computer, please log in again!");
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error: " + i);
            }
        }
        
        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.db_BPO.DatabaseExists())
                {
                    MessageBox.Show("Unable to connect to Server. Please check your internet connection");
                    return;
                }
                string username = gridView1.GetFocusedRowCellValue("Username") != null ? gridView1.GetFocusedRowCellValue("Username").ToString() : "";
                DialogResult thongbao = MessageBox.Show("You sure you want to delete UserName '" + username + "'", "Affirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //DialogResult thongbao = MessageBox.Show("Bạn muốn xóa thông tin UserName '" + username + "' ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (thongbao == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(username))
                    {
                        Global.db_BPO.DeleteUsername(username);
                        frm_ManagerUser_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Username does not exist, can't removed!");
                        //MessageBox.Show("Username không tồn tại!");
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error: " + i);
            }
        }
    }
}