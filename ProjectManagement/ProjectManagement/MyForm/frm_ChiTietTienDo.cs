using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace ProjectManagement.MyForm
{
    public partial class frm_ChiTietTienDo : DevExpress.XtraEditors.XtraForm
    {
        public string Loai;
        public frm_ChiTietTienDo()
        {
            InitializeComponent();
        }

        private void frm_ChiTietTienDo_Load(object sender, EventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                return;
            }
            lb_TongSoHinh.Text =(from w in Global.db_BPO.tbl_TienDos where w.fBatchName == lb_fBatchName.Text && w.IDProject==lb_duan.Text select w.Idimage).Count().ToString();
            if (Loai=="DESO")
            {
                lb_SoHinhChuaNhap.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeSo == "Hình chưa nhập" select w.Idimage).Count().ToString();
                lb_SoHinhDangNhap.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeSo == "Hình đang nhập" select w.Idimage).Count().ToString();
                lb_SoHinhChoCheck.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeSo == "Hình chờ check" select w.Idimage).Count().ToString();
                lb_SoHinhDangCheck.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeSo == "Hình đang check" select w.Idimage).Count().ToString();
                lb_SoHinhHoanThanh.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text &&w.TienDoDeSo == "Hình hoàn thành"select w.Idimage).Count().ToString();

                gridControl1.DataSource = null;
                gridControl1.DataSource = Global.db_BPO.ChiTietTienDoDeSo_Entry(lb_fBatchName.Text,lb_duan.Text);
                gridView1.RowCellStyle += GridView1_RowCellStyle;
            }
            else
            {
                lb_SoHinhChuaNhap.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeJP == "Hình chưa nhập" select w.Idimage).Count().ToString();
                lb_SoHinhDangNhap.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeJP == "Hình đang nhập" select w.Idimage).Count().ToString();
                lb_SoHinhChoCheck.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeJP == "Hình chờ check" select w.Idimage).Count().ToString();
                lb_SoHinhDangCheck.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeJP == "Hình đang check" select w.Idimage).Count().ToString();
                lb_SoHinhHoanThanh.Text = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == lb_duan.Text && w.fBatchName == lb_fBatchName.Text && w.TienDoDeJP == "Hình hoàn thành" select w.Idimage).Count().ToString();
                gridControl1.DataSource = null;
                gridControl1.DataSource = Global.db_BPO.ChiTietTienDoDeJP_EnTry(lb_fBatchName.Text, lb_duan.Text);
                gridView1.RowCellStyle += GridView1_RowCellStyle;
            }
        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            //doi mau row chan
            //if (e.RowHandle >= 0)
            //{
            //    if (e.RowHandle % 2 == 0)//    {
            //        e.Appearance.BackColor = Color.AntiqueWhite;
            //    }
            //}
            //Doi mau cell cua colummn Status, neu co gia tri Actived thi co mau xanh, neu co gia tri N/A thi co mau hong`
            if (e.Column.FieldName == "ThongTin")
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ThongTin"]);
                if (category == "Hình đang nhập")
                    e.Appearance.BackColor = Color.HotPink;
                else if (category == "Hình chờ check")
                {
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.ForeColor = Color.White;
                }
                else if (category == "Hình đang check")
                {
                    e.Appearance.BackColor = Color.Purple;
                    e.Appearance.ForeColor = Color.White;
                }
                else if (category == "Hình hoàn thành")
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void popupContainerControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void repositoryItemPopupContainerEdit1_Click(object sender, EventArgs e)
        {
            if (!Global.db_BPO.DatabaseExists())
            {
                MessageBox.Show("Không thể kết nối tới Server. Bạn vui lòng kiểm tra lại kết nối internet");
                return;
            }
            string idimage = gridView1.GetFocusedRowCellValue("idimage").ToString();
            gridControl2.DataSource = null;
            if (Loai == "DESO")
            {
                gridControl2.DataSource = Global.db_BPO.ChiTietUserDeSo_Entry( lb_duan.Text,lb_fBatchName.Text, idimage);
            }
            else
            {
                gridControl2.DataSource = Global.db_BPO.ChiTietUserDeJP_Entry(lb_duan.Text,lb_fBatchName.Text, idimage);
            }
        }
    }
}