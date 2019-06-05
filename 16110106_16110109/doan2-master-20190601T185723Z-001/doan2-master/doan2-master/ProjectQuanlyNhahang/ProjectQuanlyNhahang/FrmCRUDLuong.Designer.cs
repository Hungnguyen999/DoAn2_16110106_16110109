namespace ProjectQuanlyNhahang
{
	partial class FrmCRUDLuong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDLuong));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
			this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
			this.btnThem = new DevExpress.XtraBars.BarButtonItem();
			this.btnSua = new DevExpress.XtraBars.BarButtonItem();
			this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
			this.btnReload = new DevExpress.XtraBars.BarButtonItem();
			this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
			this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
			this.btnTim = new DevExpress.XtraBars.BarButtonItem();
			this.btnSave = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.pnql = new System.Windows.Forms.Panel();
			this.cbbMa = new System.Windows.Forms.TextBox();
			this.txttong = new System.Windows.Forms.TextBox();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtLuong = new System.Windows.Forms.TextBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.cbxMANV = new System.Windows.Forms.ComboBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtThuong = new System.Windows.Forms.TextBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvLuong = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			this.pnql.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.AllowMinimizeRibbon = false;
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnReload,
            this.btnLuu,
            this.barEditItem1,
            this.btnTim,
            this.btnSave});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 26;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.Size = new System.Drawing.Size(766, 116);
			this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// bbiPrintPreview
			// 
			this.bbiPrintPreview.Caption = "Print Preview";
			this.bbiPrintPreview.Id = 14;
			this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
			this.bbiPrintPreview.Name = "bbiPrintPreview";
			// 
			// bsiRecordsCount
			// 
			this.bsiRecordsCount.Caption = "RECORDS : 0";
			this.bsiRecordsCount.Id = 15;
			this.bsiRecordsCount.Name = "bsiRecordsCount";
			// 
			// btnThem
			// 
			this.btnThem.Caption = "Thêm";
			this.btnThem.Id = 16;
			this.btnThem.ImageOptions.ImageUri.Uri = "AddItem";
			this.btnThem.Name = "btnThem";
			this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
			// 
			// btnSua
			// 
			this.btnSua.Caption = "Sửa";
			this.btnSua.Id = 17;
			this.btnSua.ImageOptions.ImageUri.Uri = "Edit";
			this.btnSua.Name = "btnSua";
			this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
			// 
			// btnXoa
			// 
			this.btnXoa.Caption = "Xóa";
			this.btnXoa.Id = 18;
			this.btnXoa.ImageOptions.ImageUri.Uri = "Delete";
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
			// 
			// btnReload
			// 
			this.btnReload.Caption = "ReLoad";
			this.btnReload.Id = 19;
			this.btnReload.ImageOptions.ImageUri.Uri = "Refresh";
			this.btnReload.Name = "btnReload";
			this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
			// 
			// btnLuu
			// 
			this.btnLuu.Caption = "Lưu";
			this.btnLuu.Id = 20;
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
			this.btnLuu.Name = "btnLuu";
			// 
			// barEditItem1
			// 
			this.barEditItem1.Edit = null;
			this.barEditItem1.Id = 22;
			this.barEditItem1.Name = "barEditItem1";
			// 
			// btnTim
			// 
			this.btnTim.Caption = "Tìm Kiếm";
			this.btnTim.Id = 24;
			this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
			this.btnTim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.LargeImage")));
			this.btnTim.LargeWidth = 60;
			this.btnTim.MergeOrder = 100;
			this.btnTim.Name = "btnTim";
			// 
			// btnSave
			// 
			this.btnSave.Caption = "Lưu";
			this.btnSave.Id = 25;
			this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
			this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
			this.btnSave.Name = "btnSave";
			this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
			this.ribbonPage1.MergeOrder = 0;
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Home";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.ItemLinks.Add(this.btnThem);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			this.ribbonPageGroup1.Text = "                        ";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnSua);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "                                            ";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnXoa);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "                                             ";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.btnReload);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "                                             ";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.btnSave);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "                                           ";
			// 
			// pnql
			// 
			this.pnql.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnql.Controls.Add(this.cbbMa);
			this.pnql.Controls.Add(this.txttong);
			this.pnql.Controls.Add(this.labelControl5);
			this.pnql.Controls.Add(this.labelControl2);
			this.pnql.Controls.Add(this.txtLuong);
			this.pnql.Controls.Add(this.labelControl4);
			this.pnql.Controls.Add(this.cbxMANV);
			this.pnql.Controls.Add(this.labelControl3);
			this.pnql.Controls.Add(this.txtThuong);
			this.pnql.Controls.Add(this.labelControl1);
			this.pnql.Location = new System.Drawing.Point(113, 184);
			this.pnql.Name = "pnql";
			this.pnql.Size = new System.Drawing.Size(557, 119);
			this.pnql.TabIndex = 46;
			// 
			// cbbMa
			// 
			this.cbbMa.Location = new System.Drawing.Point(108, 10);
			this.cbbMa.Name = "cbbMa";
			this.cbbMa.Size = new System.Drawing.Size(149, 20);
			this.cbbMa.TabIndex = 61;
			// 
			// txttong
			// 
			this.txttong.Location = new System.Drawing.Point(254, 90);
			this.txttong.Name = "txttong";
			this.txttong.Size = new System.Drawing.Size(149, 20);
			this.txttong.TabIndex = 60;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(161, 93);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(57, 13);
			this.labelControl5.TabIndex = 59;
			this.labelControl5.Text = "Tổng Lương";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(15, 57);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(48, 13);
			this.labelControl2.TabIndex = 57;
			this.labelControl2.Text = "Nhân Viên";
			// 
			// txtLuong
			// 
			this.txtLuong.Location = new System.Drawing.Point(385, 10);
			this.txtLuong.Name = "txtLuong";
			this.txtLuong.Size = new System.Drawing.Size(149, 20);
			this.txtLuong.TabIndex = 51;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(290, 57);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(37, 13);
			this.labelControl4.TabIndex = 50;
			this.labelControl4.Text = "Thưởng";
			// 
			// cbxMANV
			// 
			this.cbxMANV.FormattingEnabled = true;
			this.cbxMANV.Location = new System.Drawing.Point(108, 49);
			this.cbxMANV.Name = "cbxMANV";
			this.cbxMANV.Size = new System.Drawing.Size(149, 21);
			this.cbxMANV.TabIndex = 56;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(290, 13);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(70, 13);
			this.labelControl3.TabIndex = 48;
			this.labelControl3.Text = "Lương  Cơ Bản";
			// 
			// txtThuong
			// 
			this.txtThuong.Location = new System.Drawing.Point(385, 50);
			this.txtThuong.Name = "txtThuong";
			this.txtThuong.Size = new System.Drawing.Size(149, 20);
			this.txtThuong.TabIndex = 47;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(15, 13);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(47, 13);
			this.labelControl1.TabIndex = 19;
			this.labelControl1.Text = "Mã Lương";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(172, 129);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(453, 45);
			this.label7.TabIndex = 48;
			this.label7.Text = "Quản Lý Lương Thưởng";
			// 
			// dgvLuong
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenNV,
            this.LuongCB,
            this.Thuong,
            this.TongLuong});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvLuong.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvLuong.Location = new System.Drawing.Point(38, 315);
			this.dgvLuong.Name = "dgvLuong";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvLuong.Size = new System.Drawing.Size(693, 307);
			this.dgvLuong.TabIndex = 49;
			this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick);
			this.dgvLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellContentClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID_NV";
			this.ID.HeaderText = "Mã bảng lương";
			this.ID.Name = "ID";
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ID.Width = 150;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Nhân Viên";
			this.TenNV.Name = "TenNV";
			this.TenNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.TenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.TenNV.Width = 150;
			// 
			// LuongCB
			// 
			this.LuongCB.DataPropertyName = "LuongCB";
			this.LuongCB.HeaderText = "Lương Cơ Bản";
			this.LuongCB.Name = "LuongCB";
			this.LuongCB.Width = 150;
			// 
			// Thuong
			// 
			this.Thuong.DataPropertyName = "Thuong";
			this.Thuong.HeaderText = "Tiền Thưởng";
			this.Thuong.Name = "Thuong";
			// 
			// TongLuong
			// 
			this.TongLuong.DataPropertyName = "TongLuong";
			this.TongLuong.HeaderText = "Thực Lãnh";
			this.TongLuong.Name = "TongLuong";
			// 
			// FrmCRUDLuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(766, 634);
			this.Controls.Add(this.dgvLuong);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pnql);
			this.Controls.Add(this.ribbonControl);
			this.Name = "FrmCRUDLuong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "QUẢN LÝ LƯƠNG THƯỞNG";
			this.Load += new System.EventHandler(this.FrmCRUDLuong_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			this.pnql.ResumeLayout(false);
			this.pnql.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
		private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
		private DevExpress.XtraBars.BarButtonItem btnThem;
		private DevExpress.XtraBars.BarButtonItem btnSua;
		private DevExpress.XtraBars.BarButtonItem btnXoa;
		private DevExpress.XtraBars.BarButtonItem btnReload;
		private DevExpress.XtraBars.BarButtonItem btnLuu;
		private DevExpress.XtraBars.BarEditItem barEditItem1;
		private DevExpress.XtraBars.BarButtonItem btnTim;
		private DevExpress.XtraBars.BarButtonItem btnSave;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private System.Windows.Forms.Panel pnql;
		private System.Windows.Forms.TextBox txttong;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.TextBox txtLuong;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private System.Windows.Forms.ComboBox cbxMANV;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private System.Windows.Forms.TextBox txtThuong;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewComboBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
		private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
		private System.Windows.Forms.TextBox cbbMa;
	}
}