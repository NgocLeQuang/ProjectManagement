namespace ProjectManagement.MyForm
{
    partial class frm_PhanCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl_user = new DevExpress.XtraGrid.GridControl();
            this.dgv_User = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popup_listduan = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgv_popup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkBox_TrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.popupContainer_deadline_Batch = new DevExpress.XtraEditors.PopupContainerControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.dgv_batch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_duan = new DevExpress.XtraGrid.GridControl();
            this.dgv_Duan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Popup_Deadline = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup_listduan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_popup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox_TrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer_deadline_Batch)).BeginInit();
            this.popupContainer_deadline_Batch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_batch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_duan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Duan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Popup_Deadline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_user
            // 
            this.gridControl_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_user.Location = new System.Drawing.Point(2, 20);
            this.gridControl_user.MainView = this.dgv_User;
            this.gridControl_user.Name = "gridControl_user";
            this.gridControl_user.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkBox_TrangThai,
            this.popup_listduan});
            this.gridControl_user.Size = new System.Drawing.Size(688, 516);
            this.gridControl_user.TabIndex = 0;
            this.gridControl_user.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_User});
            // 
            // dgv_User
            // 
            this.dgv_User.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.dgv_User.GridControl = this.gridControl_user;
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.OptionsView.ShowAutoFilterRow = true;
            this.dgv_User.OptionsView.ShowGroupPanel = false;
            this.dgv_User.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dgv_User_CustomDrawRowIndicator);
            this.dgv_User.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dgv_User_CellValueChanging);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Username";
            this.gridColumn1.ColumnEdit = this.popup_listduan;
            this.gridColumn1.FieldName = "Username";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 207;
            // 
            // popup_listduan
            // 
            this.popup_listduan.AutoHeight = false;
            this.popup_listduan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popup_listduan.Name = "popup_listduan";
            this.popup_listduan.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D;
            this.popup_listduan.PopupControl = this.popupContainerControl1;
            this.popup_listduan.Click += new System.EventHandler(this.popup_listduan_Click);
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.gridControl1);
            this.popupContainerControl1.InvertTouchScroll = true;
            this.popupContainerControl1.Location = new System.Drawing.Point(75, 117);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(199, 104);
            this.popupContainerControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.dgv_popup;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(199, 104);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_popup});
            // 
            // dgv_popup
            // 
            this.dgv_popup.GridControl = this.gridControl1;
            this.dgv_popup.Name = "dgv_popup";
            this.dgv_popup.OptionsBehavior.Editable = false;
            this.dgv_popup.OptionsView.ShowGroupPanel = false;
            this.dgv_popup.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dgv_popup_RowCellClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Role";
            this.gridColumn2.FieldName = "IDRole";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 201;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Full name";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 195;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.ColumnEdit = this.checkBox_TrangThai;
            this.gridColumn4.FieldName = "TrangThai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 99;
            // 
            // checkBox_TrangThai
            // 
            this.checkBox_TrangThai.Appearance.Options.UseTextOptions = true;
            this.checkBox_TrangThai.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkBox_TrangThai.AppearanceDisabled.Options.UseTextOptions = true;
            this.checkBox_TrangThai.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.checkBox_TrangThai.AutoHeight = false;
            this.checkBox_TrangThai.Name = "checkBox_TrangThai";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(387, 538);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "List project";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.popupContainer_deadline_Batch);
            this.panelControl2.Controls.Add(this.gridControl_duan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 20);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(383, 516);
            this.panelControl2.TabIndex = 2;
            // 
            // popupContainer_deadline_Batch
            // 
            this.popupContainer_deadline_Batch.Controls.Add(this.gridControl2);
            this.popupContainer_deadline_Batch.InvertTouchScroll = true;
            this.popupContainer_deadline_Batch.Location = new System.Drawing.Point(19, 97);
            this.popupContainer_deadline_Batch.Name = "popupContainer_deadline_Batch";
            this.popupContainer_deadline_Batch.Size = new System.Drawing.Size(435, 173);
            this.popupContainer_deadline_Batch.TabIndex = 2;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.dgv_batch;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(435, 173);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_batch});
            // 
            // dgv_batch
            // 
            this.dgv_batch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.dgv_batch.GridControl = this.gridControl2;
            this.dgv_batch.Name = "dgv_batch";
            this.dgv_batch.OptionsView.ColumnAutoWidth = false;
            this.dgv_batch.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Batch Name";
            this.gridColumn7.FieldName = "fBatchName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 80;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Time starts";
            this.gridColumn8.FieldName = "fTimeStart";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 104;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "End time";
            this.gridColumn9.FieldName = "fTimeEnd";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 109;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.Caption = "Deadline notification time";
            this.gridColumn10.FieldName = "fDeadlineNotificationTime";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 126;
            // 
            // gridControl_duan
            // 
            this.gridControl_duan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_duan.Location = new System.Drawing.Point(2, 2);
            this.gridControl_duan.MainView = this.dgv_Duan;
            this.gridControl_duan.Name = "gridControl_duan";
            this.gridControl_duan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Popup_Deadline});
            this.gridControl_duan.Size = new System.Drawing.Size(379, 512);
            this.gridControl_duan.TabIndex = 1;
            this.gridControl_duan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Duan});
            // 
            // dgv_Duan
            // 
            this.dgv_Duan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.dgv_Duan.GridControl = this.gridControl_duan;
            this.dgv_Duan.Name = "dgv_Duan";
            this.dgv_Duan.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.dgv_Duan.OptionsView.ShowAutoFilterRow = true;
            this.dgv_Duan.OptionsView.ShowGroupPanel = false;
            this.dgv_Duan.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dgv_Duan_RowCellClick);
            this.dgv_Duan.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dgv_Duan_CustomDrawRowIndicator);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Project ID";
            this.gridColumn5.FieldName = "IDProject";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 144;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Project name";
            this.gridColumn6.ColumnEdit = this.Popup_Deadline;
            this.gridColumn6.FieldName = "MoTaChucNangMoi";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 189;
            // 
            // Popup_Deadline
            // 
            this.Popup_Deadline.AutoHeight = false;
            this.Popup_Deadline.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Popup_Deadline.Name = "Popup_Deadline";
            this.Popup_Deadline.PopupControl = this.popupContainer_deadline_Batch;
            this.Popup_Deadline.Click += new System.EventHandler(this.Popup_Deadline_Batch_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.popupContainerControl1);
            this.groupControl2.Controls.Add(this.gridControl_user);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(387, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(692, 538);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "List user";
            // 
            // frm_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 538);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_PhanCong";
            this.Text = "Assigning project";
            this.Load += new System.EventHandler(this.frm_PhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup_listduan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_popup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox_TrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer_deadline_Batch)).EndInit();
            this.popupContainer_deadline_Batch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_batch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_duan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Duan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Popup_Deadline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl_user;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_User;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkBox_TrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit popup_listduan;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_popup;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PopupContainerControl popupContainer_deadline_Batch;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_batch;
        private DevExpress.XtraGrid.GridControl gridControl_duan;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Duan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit Popup_Deadline;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}