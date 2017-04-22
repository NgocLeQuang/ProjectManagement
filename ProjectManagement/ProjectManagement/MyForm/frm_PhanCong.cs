using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace ProjectManagement.MyForm
{
    public partial class frm_PhanCong : DevExpress.XtraEditors.XtraForm
    {
        public frm_PhanCong()
        {
            InitializeComponent();
        }

        public void LoadDataCheckDeadline()
        {
            ListIdproject = (from w in Global.db_BPO.CheckTimeDeadline() select w.fIDProject).ToList();
        }
        public static List<string> ListIdproject=new List<string>();
        public static List<string> ListBatch=new List<string>();
        void grid_RowStyle(object sender, RowStyleEventArgs e)
        {
            ListIdproject = (from w in Global.db_BPO.CheckTimeDeadline() select w.fIDProject).ToList();if (e.RowHandle >= 0)
            {
                string category = dgv_Duan.GetRowCellValue(e.RowHandle, "IDProject").ToString();
                if (category.Any(s => ListIdproject.Contains(category)))
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }

        void grid_RowStyle1(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string category = dgv_batch.GetRowCellValue(e.RowHandle, "fBatchName").ToString();
                if (category.Any(s => ListBatch.Contains(category)))
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }
        private void frm_PhanCong_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Global.db_BPO.DatabaseExists())
                {
                    MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                    return;
                }
                gridControl_duan.DataSource = Global.db_BPO.GetListProject();
                gridControl_user.DataSource =Global.db_BPO.GetListUser_PhanCong(dgv_Duan.GetRowCellValue(dgv_Duan.FocusedRowHandle, "IDProject") != null? dgv_Duan.GetRowCellValue(dgv_Duan.FocusedRowHandle, "IDProject").ToString(): "");
                groupControl2.Text = "Danh sách User tham gia dự án: " + dgv_Duan.GetRowCellValue(dgv_Duan.FocusedRowHandle, "MoTaChucNangMoi");
                LoadDataCheckDeadline();
                dgv_Duan.RowStyle += grid_RowStyle;
                dgv_batch.RowStyle += grid_RowStyle1;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + exception.Message);
            }
        }
        public bool Cal(int width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
            return true;
        }
        
        private void LoadSttGridView(RowIndicatorCustomDrawEventArgs e,GridView dgv)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
            int width = Convert.ToInt32(size.Width) + 20;
            BeginInvoke(new MethodInvoker(delegate { Cal(width, dgv); }));
        }

        private void dgv_Duan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            LoadSttGridView(e,dgv_Duan);
        }

        private void dgv_User_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
           LoadSttGridView(e,dgv_User);
        }
        
        private void dgv_User_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (!Global.db_BPO.DatabaseExists())
                {
                    MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                    return;
                }
                if (e.Column.FieldName != "TrangThai" || e.RowHandle < 0) return;
                bool check = (bool) e.Value;
                if (check)
                {
                    Global.db_BPO.Insert_PhanCong(dgv_User.GetFocusedRowCellValue("Username") != null? dgv_User.GetFocusedRowCellValue("Username").ToString(): "",dgv_Duan.GetFocusedRowCellValue("IDProject") != null? dgv_Duan.GetFocusedRowCellValue("IDProject").ToString(): "");
                }
                else
                {
                    Global.db_BPO.Delete_PhanCong(dgv_User.GetFocusedRowCellValue("Username") != null? dgv_User.GetFocusedRowCellValue("Username").ToString(): "",dgv_Duan.GetFocusedRowCellValue("IDProject") != null? dgv_Duan.GetFocusedRowCellValue("IDProject").ToString(): "");
                }
            }
            catch{// ignored 
            }
        }
        
        private void dgv_Duan_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                return;
            }
            string idproject = dgv_Duan.GetRowCellValue(dgv_Duan.FocusedRowHandle, "IDProject") != null? dgv_Duan.GetRowCellValue(dgv_Duan.FocusedRowHandle, "IDProject").ToString(): "";

            gridControl_user.DataSource = Global.db_BPO.GetListUser_PhanCong(idproject);
            groupControl2.Text = "Danh sách User tham gia dự án: "+dgv_Duan.GetRowCellValue(dgv_Duan.FocusedRowHandle, "MoTaChucNangMoi");
            
            ListBatch = (from w in Global.db_BPO.GetList_Batch_BaoDeadline(idproject) select w.fBatchName).ToList();
        }

        private void popup_listduan_Click(object sender, EventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                return;
            }
            string username = dgv_User.GetFocusedRowCellValue("Username").ToString();
            gridControl1.DataSource = Global.db_BPO.GetList_Project_UserPerform(username);
        }

        private void dgv_popup_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                return;
            }
            string idproject = dgv_popup.GetRowCellValue(dgv_popup.FocusedRowHandle, "IDProject") != null? dgv_popup.GetRowCellValue(dgv_popup.FocusedRowHandle, "IDProject").ToString(): "";
            for (int i = 0; i < dgv_Duan.RowCount; i++)
            {
                if (idproject == dgv_Duan.GetRowCellValue(i, "IDProject").ToString())
                {
                    dgv_Duan.FocusedRowHandle = i;
                    break;
                }
            }
            gridControl_user.DataSource = Global.db_BPO.GetListUser_PhanCong(dgv_popup.GetRowCellValue(dgv_popup.FocusedRowHandle, "IDProject") != null ? dgv_popup.GetRowCellValue(dgv_popup.FocusedRowHandle, "IDProject").ToString() : "");
        }

        private void Popup_Deadline_Batch_Click(object sender, EventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                return;
            }
            string idproject = dgv_Duan.GetFocusedRowCellValue("IDProject").ToString();
            gridControl2.DataSource = Global.db_BPO.GetList_Batch_Deadline(idproject);
        }
    }
}