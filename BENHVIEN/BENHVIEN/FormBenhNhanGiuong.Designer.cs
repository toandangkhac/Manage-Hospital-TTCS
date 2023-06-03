namespace BENHVIEN
{
    partial class FormBenhNhanGiuong
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
            System.Windows.Forms.Label maBenhNhanLabel;
            System.Windows.Forms.Label ngayBDLabel;
            System.Windows.Forms.Label ngayKTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBenhNhanGiuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            this.bdsCT_GIUONG = new System.Windows.Forms.BindingSource(this.components);
            this.cT_BENHNHAN_GIUONGTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_BENHNHAN_GIUONGTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.cT_BENHNHAN_GIUONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMAGIUONG = new DevExpress.XtraEditors.TextEdit();
            this.txtMABN = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAYBD = new DevExpress.XtraEditors.DateEdit();
            this.dteNGAYKT = new DevExpress.XtraEditors.DateEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            maGiuongLabel = new System.Windows.Forms.Label();
            maBenhNhanLabel = new System.Windows.Forms.Label();
            ngayBDLabel = new System.Windows.Forms.Label();
            ngayKTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_GIUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_BENHNHAN_GIUONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGIUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // maGiuongLabel
            // 
            maGiuongLabel.AutoSize = true;
            maGiuongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maGiuongLabel.Location = new System.Drawing.Point(143, 537);
            maGiuongLabel.Name = "maGiuongLabel";
            maGiuongLabel.Size = new System.Drawing.Size(114, 25);
            maGiuongLabel.TabIndex = 5;
            maGiuongLabel.Text = "Mã Giường:";
            // 
            // maBenhNhanLabel
            // 
            maBenhNhanLabel.AutoSize = true;
            maBenhNhanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maBenhNhanLabel.Location = new System.Drawing.Point(120, 480);
            maBenhNhanLabel.Name = "maBenhNhanLabel";
            maBenhNhanLabel.Size = new System.Drawing.Size(149, 25);
            maBenhNhanLabel.TabIndex = 7;
            maBenhNhanLabel.Text = "Mã Bệnh Nhân:";
            // 
            // ngayBDLabel
            // 
            ngayBDLabel.AutoSize = true;
            ngayBDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayBDLabel.Location = new System.Drawing.Point(975, 472);
            ngayBDLabel.Name = "ngayBDLabel";
            ngayBDLabel.Size = new System.Drawing.Size(96, 25);
            ngayBDLabel.TabIndex = 9;
            ngayBDLabel.Text = "Ngay BD:";
            // 
            // ngayKTLabel
            // 
            ngayKTLabel.AutoSize = true;
            ngayKTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKTLabel.Location = new System.Drawing.Point(977, 533);
            ngayKTLabel.Name = "ngayKTLabel";
            ngayKTLabel.Size = new System.Drawing.Size(96, 25);
            ngayKTLabel.TabIndex = 11;
            ngayKTLabel.Text = "Ngay KT:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(868, 377);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLUU, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUNDO, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1313, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 677);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1313, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 647);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1313, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 647);
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
            // bdsCT_GIUONG
            // 
            this.bdsCT_GIUONG.DataMember = "CT_BENHNHAN_GIUONG";
            this.bdsCT_GIUONG.DataSource = this.DS;
            // 
            // cT_BENHNHAN_GIUONGTableAdapter
            // 
            this.cT_BENHNHAN_GIUONGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GIUONGBENHTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // cT_BENHNHAN_GIUONGGridControl
            // 
            this.cT_BENHNHAN_GIUONGGridControl.DataSource = this.bdsCT_GIUONG;
            this.cT_BENHNHAN_GIUONGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cT_BENHNHAN_GIUONGGridControl.Location = new System.Drawing.Point(0, 30);
            this.cT_BENHNHAN_GIUONGGridControl.MainView = this.gridView1;
            this.cT_BENHNHAN_GIUONGGridControl.MenuManager = this.barManager1;
            this.cT_BENHNHAN_GIUONGGridControl.Name = "cT_BENHNHAN_GIUONGGridControl";
            this.cT_BENHNHAN_GIUONGGridControl.Size = new System.Drawing.Size(1313, 329);
            this.cT_BENHNHAN_GIUONGGridControl.TabIndex = 5;
            this.cT_BENHNHAN_GIUONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGiuong,
            this.colMaBenhNhan,
            this.colNgayBD,
            this.colNgayKT});
            this.gridView1.GridControl = this.cT_BENHNHAN_GIUONGGridControl;
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
            // colMaBenhNhan
            // 
            this.colMaBenhNhan.FieldName = "MaBenhNhan";
            this.colMaBenhNhan.MinWidth = 25;
            this.colMaBenhNhan.Name = "colMaBenhNhan";
            this.colMaBenhNhan.Visible = true;
            this.colMaBenhNhan.VisibleIndex = 1;
            this.colMaBenhNhan.Width = 94;
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
            // txtMAGIUONG
            // 
            this.txtMAGIUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_GIUONG, "MaGiuong", true));
            this.txtMAGIUONG.Location = new System.Drawing.Point(307, 534);
            this.txtMAGIUONG.MenuManager = this.barManager1;
            this.txtMAGIUONG.Name = "txtMAGIUONG";
            this.txtMAGIUONG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGIUONG.Properties.Appearance.Options.UseFont = true;
            this.txtMAGIUONG.Size = new System.Drawing.Size(219, 30);
            this.txtMAGIUONG.TabIndex = 6;
            // 
            // txtMABN
            // 
            this.txtMABN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_GIUONG, "MaBenhNhan", true));
            this.txtMABN.Location = new System.Drawing.Point(307, 477);
            this.txtMABN.MenuManager = this.barManager1;
            this.txtMABN.Name = "txtMABN";
            this.txtMABN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABN.Properties.Appearance.Options.UseFont = true;
            this.txtMABN.Size = new System.Drawing.Size(219, 30);
            this.txtMABN.TabIndex = 8;
            // 
            // dteNGAYBD
            // 
            this.dteNGAYBD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_GIUONG, "NgayBD", true));
            this.dteNGAYBD.EditValue = null;
            this.dteNGAYBD.Location = new System.Drawing.Point(1113, 474);
            this.dteNGAYBD.MenuManager = this.barManager1;
            this.dteNGAYBD.Name = "dteNGAYBD";
            this.dteNGAYBD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNGAYBD.Properties.Appearance.Options.UseFont = true;
            this.dteNGAYBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYBD.Size = new System.Drawing.Size(200, 30);
            this.dteNGAYBD.TabIndex = 10;
            // 
            // dteNGAYKT
            // 
            this.dteNGAYKT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_GIUONG, "NgayKT", true));
            this.dteNGAYKT.EditValue = null;
            this.dteNGAYKT.Location = new System.Drawing.Point(1113, 535);
            this.dteNGAYKT.MenuManager = this.barManager1;
            this.dteNGAYKT.Name = "dteNGAYKT";
            this.dteNGAYKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNGAYKT.Properties.Appearance.Options.UseFont = true;
            this.dteNGAYKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYKT.Size = new System.Drawing.Size(200, 30);
            this.dteNGAYKT.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(604, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Chọn Bệnh Nhân";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(604, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Chọn Giường";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBenhNhanGiuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 677);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(ngayKTLabel);
            this.Controls.Add(this.dteNGAYKT);
            this.Controls.Add(ngayBDLabel);
            this.Controls.Add(this.dteNGAYBD);
            this.Controls.Add(maBenhNhanLabel);
            this.Controls.Add(this.txtMABN);
            this.Controls.Add(maGiuongLabel);
            this.Controls.Add(this.txtMAGIUONG);
            this.Controls.Add(this.cT_BENHNHAN_GIUONGGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBenhNhanGiuong";
            this.Text = "FormBenhNhanGiuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBenhNhanGiuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_GIUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_BENHNHAN_GIUONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGIUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYKT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
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
        private System.Windows.Forms.BindingSource bdsCT_GIUONG;
        private HOSPITALDataSet DS;
        private HOSPITALDataSetTableAdapters.CT_BENHNHAN_GIUONGTableAdapter cT_BENHNHAN_GIUONGTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cT_BENHNHAN_GIUONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKT;
        private DevExpress.XtraEditors.DateEdit dteNGAYKT;
        private DevExpress.XtraEditors.DateEdit dteNGAYBD;
        private DevExpress.XtraEditors.TextEdit txtMABN;
        private DevExpress.XtraEditors.TextEdit txtMAGIUONG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}