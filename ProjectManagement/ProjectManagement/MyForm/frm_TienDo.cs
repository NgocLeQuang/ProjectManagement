using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace ProjectManagement.MyForm
{
    public partial class frm_TienDo : DevExpress.XtraEditors.XtraForm
    {
        private string loai;
        public frm_TienDo()
        {
            InitializeComponent();
        }

        private void frm_TienDo_Load(object sender, EventArgs e)
        {
            btn_ChiTiet.Visible = false;
            radioGroup1.Visible = false;

            var idproject = (from w in Global.db_BPO.tbl_Versions orderby w.IDProject select new { w.IDProject }).ToList();
            cbb_project.Properties.DataSource = idproject;
            cbb_project.Properties.DisplayMember = "IDProject";
            cbb_project.Properties.ValueMember = "IDProject";
            cbb_project.ItemIndex = 0;

            var fBatchName = (from w in Global.db_BPO.tbl_TienDos where w.IDProject==cbb_project.Text  orderby w.id group w by w.fBatchName into g select new { fBatchName=g.Key }).ToList();
            cbb_Batch.Properties.DataSource = fBatchName;
            cbb_Batch.Properties.DisplayMember = "fBatchName";
            cbb_Batch.Properties.ValueMember = "fBatchName";
            cbb_Batch.ItemIndex = 0;
            if (cbb_Batch.Text == "Không có batch")
            {
                btn_ChiTiet.Visible = false;
                radioGroup1.Visible = false;
            }
            else
            {
                btn_ChiTiet.Visible = true;
                radioGroup1.Visible = true;
            }
        }
        private void ThongKe()
        {
            try
            {
                if (radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Value == "DESO")
                {
                    chartControl1.DataSource = null;
                    chartControl1.Series.Clear();
                    chartControl1.DataSource = Global.db_BPO.ThongKeDeSo(cbb_Batch.Text,cbb_project.Text);
                    Series series1 = new Series("Series1", ViewType.Pie);
                    series1.ArgumentScaleType = ScaleType.Qualitative;
                    series1.ArgumentDataMember = "name";
                    series1.ValueScaleType = ScaleType.Numerical;
                    series1.ValueDataMembers.AddRange(new string[] { "soluong" });
                    chartControl1.Series.Add(series1);
                    ((PiePointOptions)series1.Label.PointOptions).PointView = PointView.ArgumentAndValues;
                    chartControl1.PaletteName = "Palette 1";
                    loai = "DESO";
                }
                else
                {
                    chartControl1.DataSource = null;
                    chartControl1.Series.Clear();
                    chartControl1.DataSource = Global.db_BPO.ThongKeDeJP(cbb_Batch.Text,cbb_project.Text);
                    Series series1 = new Series("Series1", ViewType.Pie);
                    series1.ArgumentScaleType = ScaleType.Qualitative;
                    series1.ArgumentDataMember = "name";
                    series1.ValueScaleType = ScaleType.Numerical;
                    series1.ValueDataMembers.AddRange(new string[] { "soluong" });
                    chartControl1.Series.Add(series1);
                    ((PiePointOptions)series1.Label.PointOptions).PointView = PointView.ArgumentAndValues;
                    //((Pie3DSeriesView)series1.View). = true;
                    //((pie)chartControl2.Diagram).AxisY.Visible = false;
                    chartControl1.PaletteName = "Palette 1";
                    loai = "DEJP";
                }
               
            }
            catch (Exception)
            {

            }

        }

        private void cbb_Batch_EditValueChanged(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            var frm = new frm_ChiTietTienDo();
            frm.lb_fBatchName.Text = cbb_Batch.Text;
            frm.lb_duan.Text = cbb_project.Text;
            frm.Text = "Chi tiết tiến độ " + loai;
            frm.Loai = loai;
            frm.ShowDialog();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void cbb_project_EditValueChanged(object sender, EventArgs e)
        {
            var fBatchName = (from w in Global.db_BPO.tbl_TienDos where w.IDProject == cbb_project.Text orderby w.id group w by w.fBatchName into g select new { fBatchName = g.Key }).ToList();
            cbb_Batch.Properties.DataSource = fBatchName;
            cbb_Batch.Properties.DisplayMember = "fBatchName";
            cbb_Batch.Properties.ValueMember = "fBatchName";
            cbb_Batch.ItemIndex = 0;ThongKe();
        }
    }
}