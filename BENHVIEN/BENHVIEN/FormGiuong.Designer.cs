namespace BENHVIEN
{
    partial class FormGiuong
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
            System.Windows.Forms.Label maGiuongLabel;
            System.Windows.Forms.Label soGiuongLabel;
            System.Windows.Forms.Label soPhongLabel;
            System.Windows.Forms.Label soKhuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiuong));
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
            this.DS = new BENHVIEN.HOSPITALDataSet();
            this.bdsGUONG = new System.Windows.Forms.BindingSource(this.components);
            this.gIUONGBENHTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.GIUONGBENHTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.cT_BENHNHAN_GIUONGTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_BENHNHAN_GIUONGTableAdapter();
            this.gIUONGBENHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoKhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMAGIUONG = new DevExpress.XtraEditors.TextEdit();
            this.txtSOGIUONG = new DevExpress.XtraEditors.SpinEdit();
            this.txtSOKHU = new DevExpress.XtraEditors.TextEdit();
            this.buttonCHONKHU = new System.Windows.Forms.Button();
            this.cT_BENHNHAN_GIUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSOPHONG = new DevExpress.XtraEditors.SpinEdit();
            maGiuongLabel = new System.Windows.Forms.Label();
            soGiuongLabel = new System.Windows.Forms.Label();
            soPhongLabel = new System.Windows.Forms.Label();
            soKhuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBENHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGIUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOGIUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_BENHNHAN_GIUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOPHONG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maGiuongLabel
            // 
            maGiuongLabel.AutoSize = true;
            maGiuongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maGiuongLabel.Location = new System.Drawing.Point(305, 426);
            maGiuongLabel.Name = "maGiuongLabel";
            maGiuongLabel.Size = new System.Drawing.Size(114, 25);
            maGiuongLabel.TabIndex = 5;
            maGiuongLabel.Text = "Ma Giuong:";
            // 
            // soGiuongLabel
            // 
            soGiuongLabel.AutoSize = true;
            soGiuongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soGiuongLabel.Location = new System.Drawing.Point(307, 509);
            soGiuongLabel.Name = "soGiuongLabel";
            soGiuongLabel.Size = new System.Drawing.Size(111, 25);
            soGiuongLabel.TabIndex = 7;
            soGiuongLabel.Text = "So Giuong:";
            // 
            // soPhongLabel
            // 
            soPhongLabel.AutoSize = true;
            soPhongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soPhongLabel.Location = new System.Drawing.Point(311, 588);
            soPhongLabel.Name = "soPhongLabel";
            soPhongLabel.Size = new System.Drawing.Size(105, 25);
            soPhongLabel.TabIndex = 9;
            soPhongLabel.Text = "So Phong:";
            // 
            // soKhuLabel
            // 
            soKhuLabel.AutoSize = true;
            soKhuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soKhuLabel.Location = new System.Drawing.Point(328, 672);
            soKhuLabel.Name = "soKhuLabel";
            soKhuLabel.Size = new System.Drawing.Size(84, 25);
            soKhuLabel.TabIndex = 11;
            soKhuLabel.Text = "So Khu:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(981, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 763);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(981, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 733);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(981, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 733);
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
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGUONG
            // 
            this.bdsGUONG.DataMember = "GIUONGBENH";
            this.bdsGUONG.DataSource = this.DS;
            // 
            // gIUONGBENHTableAdapter
            // 
            this.gIUONGBENHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CT_BACSI_CHUATRI_BENHNHANTableAdapter = null;
            this.tableAdapterManager.CT_BENHNHAN_GIUONGTableAdapter = this.cT_BENHNHAN_GIUONGTableAdapter;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NV_KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.GIUONGBENHTableAdapter = this.gIUONGBENHTableAdapter;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // cT_BENHNHAN_GIUONGTableAdapter
            // 
            this.cT_BENHNHAN_GIUONGTableAdapter.ClearBeforeFill = true;
            // 
            // gIUONGBENHGridControl
            // 
            this.gIUONGBENHGridControl.DataSource = this.bdsGUONG;
            this.gIUONGBENHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIUONGBENHGridControl.Location = new System.Drawing.Point(0, 30);
            this.gIUONGBENHGridControl.MainView = this.gridView1;
            this.gIUONGBENHGridControl.MenuManager = this.barManager1;
            this.gIUONGBENHGridControl.Name = "gIUONGBENHGridControl";
            this.gIUONGBENHGridControl.Size = new System.Drawing.Size(981, 348);
            this.gIUONGBENHGridControl.TabIndex = 5;
            this.gIUONGBENHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGiuong,
            this.colSoGiuong,
            this.colSoPhong,
            this.colSoKhu});
            this.gridView1.GridControl = this.gIUONGBENHGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaGiuong
            // 
            this.colMaGiuong.FieldName = "MaGiuong";
            this.colMaGiuong.MinWidth = 25;
            this.colMaGiuong.Name = "colMaGiuong";
            this.colMaGiuong.Visible = true;
            this.colMaGiuong.VisibleIndex = 0;
            this.colMaGiuong.Width = 94;
            // 
            // colSoGiuong
            // 
            this.colSoGiuong.FieldName = "SoGiuong";
            this.colSoGiuong.MinWidth = 25;
            this.colSoGiuong.Name = "colSoGiuong";
            this.colSoGiuong.Visible = true;
            this.colSoGiuong.VisibleIndex = 1;
            this.colSoGiuong.Width = 94;
            // 
            // colSoPhong
            // 
            this.colSoPhong.FieldName = "SoPhong";
            this.colSoPhong.MinWidth = 25;
            this.colSoPhong.Name = "colSoPhong";
            this.colSoPhong.Visible = true;
            this.colSoPhong.VisibleIndex = 2;
            this.colSoPhong.Width = 94;
            // 
            // colSoKhu
            // 
            this.colSoKhu.FieldName = "SoKhu";
            this.colSoKhu.MinWidth = 25;
            this.colSoKhu.Name = "colSoKhu";
            this.colSoKhu.Visible = true;
            this.colSoKhu.VisibleIndex = 3;
            this.colSoKhu.Width = 94;
            // 
            // txtMAGIUONG
            // 
            this.txtMAGIUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGUONG, "MaGiuong", true));
            this.txtMAGIUONG.Enabled = false;
            this.txtMAGIUONG.Location = new System.Drawing.Point(472, 423);
            this.txtMAGIUONG.MenuManager = this.barManager1;
            this.txtMAGIUONG.Name = "txtMAGIUONG";
            this.txtMAGIUONG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGIUONG.Properties.Appearance.Options.UseFont = true;
            this.txtMAGIUONG.Size = new System.Drawing.Size(180, 30);
            this.txtMAGIUONG.TabIndex = 6;
            // 
            // txtSOGIUONG
            // 
            this.txtSOGIUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGUONG, "SoGiuong", true));
            this.txtSOGIUONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSOGIUONG.Location = new System.Drawing.Point(472, 506);
            this.txtSOGIUONG.MenuManager = this.barManager1;
            this.txtSOGIUONG.Name = "txtSOGIUONG";
            this.txtSOGIUONG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOGIUONG.Properties.Appearance.Options.UseFont = true;
            this.txtSOGIUONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSOGIUONG.Size = new System.Drawing.Size(180, 30);
            this.txtSOGIUONG.TabIndex = 8;
            // 
            // txtSOKHU
            // 
            this.txtSOKHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGUONG, "SoKhu", true));
            this.txtSOKHU.Enabled = false;
            this.txtSOKHU.Location = new System.Drawing.Point(472, 669);
            this.txtSOKHU.MenuManager = this.barManager1;
            this.txtSOKHU.Name = "txtSOKHU";
            this.txtSOKHU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOKHU.Properties.Appearance.Options.UseFont = true;
            this.txtSOKHU.Size = new System.Drawing.Size(180, 30);
            this.txtSOKHU.TabIndex = 12;
            // 
            // buttonCHONKHU
            // 
            this.buttonCHONKHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCHONKHU.Location = new System.Drawing.Point(745, 662);
            this.buttonCHONKHU.Name = "buttonCHONKHU";
            this.buttonCHONKHU.Size = new System.Drawing.Size(189, 48);
            this.buttonCHONKHU.TabIndex = 13;
            this.buttonCHONKHU.Text = "Chọn Khu";
            this.buttonCHONKHU.UseVisualStyleBackColor = true;
            this.buttonCHONKHU.Click += new System.EventHandler(this.buttonCHONKHU_Click);
            // 
            // cT_BENHNHAN_GIUONGBindingSource
            // 
            this.cT_BENHNHAN_GIUONGBindingSource.DataMember = "FK_MaGiuong_CT_BENHNHAN_GIUONG";
            this.cT_BENHNHAN_GIUONGBindingSource.DataSource = this.bdsGUONG;
            // 
            // txtSOPHONG
            // 
            this.txtSOPHONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGUONG, "SoPhong", true));
            this.txtSOPHONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSOPHONG.Location = new System.Drawing.Point(472, 584);
            this.txtSOPHONG.MenuManager = this.barManager1;
            this.txtSOPHONG.Name = "txtSOPHONG";
            this.txtSOPHONG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOPHONG.Properties.Appearance.Options.UseFont = true;
            this.txtSOPHONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSOPHONG.Size = new System.Drawing.Size(180, 30);
            this.txtSOPHONG.TabIndex = 18;
            // 
            // FormGiuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 763);
            this.Controls.Add(this.txtSOPHONG);
            this.Controls.Add(this.buttonCHONKHU);
            this.Controls.Add(soKhuLabel);
            this.Controls.Add(this.txtSOKHU);
            this.Controls.Add(soPhongLabel);
            this.Controls.Add(soGiuongLabel);
            this.Controls.Add(this.txtSOGIUONG);
            this.Controls.Add(maGiuongLabel);
            this.Controls.Add(this.txtMAGIUONG);
            this.Controls.Add(this.gIUONGBENHGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormGiuong";
            this.Text = "FormGiuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGiuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBENHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGIUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOGIUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_BENHNHAN_GIUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOPHONG.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.BindingSource bdsGUONG;
        private HOSPITALDataSet DS;
        private HOSPITALDataSetTableAdapters.GIUONGBENHTableAdapter gIUONGBENHTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtSOKHU;
        private DevExpress.XtraEditors.SpinEdit txtSOGIUONG;
        private DevExpress.XtraEditors.TextEdit txtMAGIUONG;
        private DevExpress.XtraGrid.GridControl gIUONGBENHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button buttonCHONKHU;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoKhu;
        private HOSPITALDataSetTableAdapters.CT_BENHNHAN_GIUONGTableAdapter cT_BENHNHAN_GIUONGTableAdapter;
        private System.Windows.Forms.BindingSource cT_BENHNHAN_GIUONGBindingSource;
        private DevExpress.XtraEditors.SpinEdit txtSOPHONG;
    }
}