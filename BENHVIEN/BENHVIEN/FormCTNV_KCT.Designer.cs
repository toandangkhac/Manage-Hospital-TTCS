namespace BENHVIEN
{
    partial class FormCTNV_KCT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label soKhuLabel;
            System.Windows.Forms.Label ngayBDLabel;
            System.Windows.Forms.Label ngayKTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTNV_KCT));
            this.DS = new BENHVIEN.HOSPITALDataSet();
            this.bdsCTNV_KCT = new System.Windows.Forms.BindingSource(this.components);
            this.cT_NV_KHUCHUATRITableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_NV_KHUCHUATRITableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.cT_NV_KHUCHUATRIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoKhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.txtSOKHU = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAYBD = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAYKT = new DevExpress.XtraEditors.DateEdit();
            this.btnCHONNV = new System.Windows.Forms.Button();
            this.btnCHONKHU = new System.Windows.Forms.Button();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnLUU = new DevExpress.XtraBars.BarButtonItem();
            this.btnUNDO = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            maNVLabel = new System.Windows.Forms.Label();
            soKhuLabel = new System.Windows.Forms.Label();
            ngayBDLabel = new System.Windows.Forms.Label();
            ngayKTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTNV_KCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NV_KHUCHUATRIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNVLabel.Location = new System.Drawing.Point(271, 329);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(79, 25);
            maNVLabel.TabIndex = 1;
            maNVLabel.Text = "Ma NV:";
            // 
            // soKhuLabel
            // 
            soKhuLabel.AutoSize = true;
            soKhuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soKhuLabel.Location = new System.Drawing.Point(266, 392);
            soKhuLabel.Name = "soKhuLabel";
            soKhuLabel.Size = new System.Drawing.Size(84, 25);
            soKhuLabel.TabIndex = 3;
            soKhuLabel.Text = "So Khu:";
            // 
            // ngayBDLabel
            // 
            ngayBDLabel.AutoSize = true;
            ngayBDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayBDLabel.Location = new System.Drawing.Point(257, 460);
            ngayBDLabel.Name = "ngayBDLabel";
            ngayBDLabel.Size = new System.Drawing.Size(96, 25);
            ngayBDLabel.TabIndex = 5;
            ngayBDLabel.Text = "Ngay BD:";
            // 
            // ngayKTLabel
            // 
            ngayKTLabel.AutoSize = true;
            ngayKTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKTLabel.Location = new System.Drawing.Point(259, 526);
            ngayKTLabel.Name = "ngayKTLabel";
            ngayKTLabel.Size = new System.Drawing.Size(96, 25);
            ngayKTLabel.TabIndex = 7;
            ngayKTLabel.Text = "Ngay KT:";
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCTNV_KCT
            // 
            this.bdsCTNV_KCT.DataMember = "CT_NV_KHUCHUATRI";
            this.bdsCTNV_KCT.DataSource = this.DS;
            // 
            // cT_NV_KHUCHUATRITableAdapter
            // 
            this.cT_NV_KHUCHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CT_BACSI_CHUATRI_BENHNHANTableAdapter = null;
            this.tableAdapterManager.CT_BENHNHAN_GIUONGTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NV_KHUCHUATRITableAdapter = this.cT_NV_KHUCHUATRITableAdapter;
            this.tableAdapterManager.GIUONGBENHTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // cT_NV_KHUCHUATRIGridControl
            // 
            this.cT_NV_KHUCHUATRIGridControl.DataSource = this.bdsCTNV_KCT;
            this.cT_NV_KHUCHUATRIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cT_NV_KHUCHUATRIGridControl.Location = new System.Drawing.Point(0, 30);
            this.cT_NV_KHUCHUATRIGridControl.MainView = this.gridView1;
            this.cT_NV_KHUCHUATRIGridControl.Name = "cT_NV_KHUCHUATRIGridControl";
            this.cT_NV_KHUCHUATRIGridControl.Size = new System.Drawing.Size(1033, 189);
            this.cT_NV_KHUCHUATRIGridControl.TabIndex = 1;
            this.cT_NV_KHUCHUATRIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colSoKhu,
            this.colNgayBD,
            this.colNgayKT});
            this.gridView1.GridControl = this.cT_NV_KHUCHUATRIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 25;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            this.colMaNV.Width = 94;
            // 
            // colSoKhu
            // 
            this.colSoKhu.FieldName = "SoKhu";
            this.colSoKhu.MinWidth = 25;
            this.colSoKhu.Name = "colSoKhu";
            this.colSoKhu.Visible = true;
            this.colSoKhu.VisibleIndex = 1;
            this.colSoKhu.Width = 94;
            // 
            // colNgayBD
            // 
            this.colNgayBD.FieldName = "NgayBD";
            this.colNgayBD.MinWidth = 25;
            this.colNgayBD.Name = "colNgayBD";
            this.colNgayBD.Visible = true;
            this.colNgayBD.VisibleIndex = 2;
            this.colNgayBD.Width = 94;
            // 
            // colNgayKT
            // 
            this.colNgayKT.FieldName = "NgayKT";
            this.colNgayKT.MinWidth = 25;
            this.colNgayKT.Name = "colNgayKT";
            this.colNgayKT.Visible = true;
            this.colNgayKT.VisibleIndex = 3;
            this.colNgayKT.Width = 94;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTNV_KCT, "MaNV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(417, 324);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Properties.Appearance.Options.UseFont = true;
            this.txtMANV.Size = new System.Drawing.Size(198, 30);
            this.txtMANV.TabIndex = 2;
            // 
            // txtSOKHU
            // 
            this.txtSOKHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTNV_KCT, "SoKhu", true));
            this.txtSOKHU.Enabled = false;
            this.txtSOKHU.Location = new System.Drawing.Point(417, 389);
            this.txtSOKHU.Name = "txtSOKHU";
            this.txtSOKHU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOKHU.Properties.Appearance.Options.UseFont = true;
            this.txtSOKHU.Size = new System.Drawing.Size(198, 30);
            this.txtSOKHU.TabIndex = 4;
            // 
            // dteNGAYBD
            // 
            this.dteNGAYBD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTNV_KCT, "NgayBD", true));
            this.dteNGAYBD.EditValue = null;
            this.dteNGAYBD.Location = new System.Drawing.Point(417, 455);
            this.dteNGAYBD.Name = "dteNGAYBD";
            this.dteNGAYBD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNGAYBD.Properties.Appearance.Options.UseFont = true;
            this.dteNGAYBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYBD.Size = new System.Drawing.Size(198, 30);
            this.dteNGAYBD.TabIndex = 6;
            // 
            // dteNGAYKT
            // 
            this.dteNGAYKT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTNV_KCT, "NgayKT", true));
            this.dteNGAYKT.EditValue = null;
            this.dteNGAYKT.Location = new System.Drawing.Point(417, 521);
            this.dteNGAYKT.Name = "dteNGAYKT";
            this.dteNGAYKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNGAYKT.Properties.Appearance.Options.UseFont = true;
            this.dteNGAYKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYKT.Size = new System.Drawing.Size(198, 30);
            this.dteNGAYKT.TabIndex = 8;
            // 
            // btnCHONNV
            // 
            this.btnCHONNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHONNV.Location = new System.Drawing.Point(656, 318);
            this.btnCHONNV.Name = "btnCHONNV";
            this.btnCHONNV.Size = new System.Drawing.Size(238, 36);
            this.btnCHONNV.TabIndex = 9;
            this.btnCHONNV.Text = "Chọn Nhân Viên";
            this.btnCHONNV.UseVisualStyleBackColor = true;
            this.btnCHONNV.Click += new System.EventHandler(this.btnCHONNV_Click);
            // 
            // btnCHONKHU
            // 
            this.btnCHONKHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHONKHU.Location = new System.Drawing.Point(656, 383);
            this.btnCHONKHU.Name = "btnCHONKHU";
            this.btnCHONKHU.Size = new System.Drawing.Size(238, 36);
            this.btnCHONKHU.TabIndex = 10;
            this.btnCHONKHU.Text = "Chọn Khu";
            this.btnCHONKHU.UseVisualStyleBackColor = true;
            this.btnCHONKHU.Click += new System.EventHandler(this.button1_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(868, 377);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnLUU,
            this.btnUNDO,
            this.barButtonItem2,
            this.btnLAMMOI,
            this.btnCHUYENCHINHANH,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(868, 377);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLUU, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUNDO, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 2;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnXOA.Caption = "Xoá";
            this.btnXOA.Id = 3;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnLUU
            // 
            this.btnLUU.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnLUU.Caption = "Lưu";
            this.btnLUU.Id = 4;
            this.btnLUU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLUU.ImageOptions.SvgImage")));
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLUU_ItemClick);
            // 
            // btnUNDO
            // 
            this.btnUNDO.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnUNDO.Caption = "Undo";
            this.btnUNDO.Id = 5;
            this.btnUNDO.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUNDO.ImageOptions.SvgImage")));
            this.btnUNDO.Name = "btnUNDO";
            this.btnUNDO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUNDO_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnLAMMOI.Caption = "Refresh";
            this.btnLAMMOI.Id = 7;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 9;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1033, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 761);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1033, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 731);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1033, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 731);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.barButtonItem2.Caption = "Redo";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 8;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // FormCTNV_KCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 761);
            this.Controls.Add(this.btnCHONKHU);
            this.Controls.Add(this.btnCHONNV);
            this.Controls.Add(ngayKTLabel);
            this.Controls.Add(this.dteNGAYKT);
            this.Controls.Add(ngayBDLabel);
            this.Controls.Add(this.dteNGAYBD);
            this.Controls.Add(soKhuLabel);
            this.Controls.Add(this.txtSOKHU);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.cT_NV_KHUCHUATRIGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormCTNV_KCT";
            this.Text = "FormCTNV_KCT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCTNV_KCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTNV_KCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NV_KHUCHUATRIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource bdsCTNV_KCT;
        private HOSPITALDataSetTableAdapters.CT_NV_KHUCHUATRITableAdapter cT_NV_KHUCHUATRITableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cT_NV_KHUCHUATRIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colSoKhu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKT;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtSOKHU;
        private DevExpress.XtraEditors.DateEdit dteNGAYBD;
        private DevExpress.XtraEditors.DateEdit dteNGAYKT;
        private System.Windows.Forms.Button btnCHONNV;
        private System.Windows.Forms.Button btnCHONKHU;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnLUU;
        private DevExpress.XtraBars.BarButtonItem btnUNDO;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
    }
}