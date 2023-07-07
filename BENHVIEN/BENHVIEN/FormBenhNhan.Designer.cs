namespace BENHVIEN
{
    partial class FormBenhNhan
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
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label maLoaiLabel;
            System.Windows.Forms.Label maBacSiTheoDoiLabel;
            System.Windows.Forms.Label maBacSiTiepNhanLabel;
            System.Windows.Forms.Label maBenhNhanLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBenhNhan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLOAI = new DevExpress.XtraEditors.CheckEdit();
            this.bdsBENHNHAN = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new BENHVIEN.HOSPITALDataSet();
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
            this.txtMABSTIEPNHAN = new DevExpress.XtraEditors.TextEdit();
            this.txtMABSTHEODOI = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMABN = new DevExpress.XtraEditors.TextEdit();
            this.bENHNHANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBacSiTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBacSiTiepNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCHONBSTIEPNHAN = new System.Windows.Forms.Button();
            this.btnCHONBSTHEODOI = new System.Windows.Forms.Button();
            this.bENHNHANTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.BENHNHANTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.cT_BACSI_CHUATRI_BENHNHANTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_BACSI_CHUATRI_BENHNHANTableAdapter();
            this.cT_BENHNHAN_GIUONGTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_BENHNHAN_GIUONGTableAdapter();
            this.bdsCT_BN_GIUONG = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCT_BS_CHUATRI = new System.Windows.Forms.BindingSource(this.components);
            hoLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            maLoaiLabel = new System.Windows.Forms.Label();
            maBacSiTheoDoiLabel = new System.Windows.Forms.Label();
            maBacSiTiepNhanLabel = new System.Windows.Forms.Label();
            maBenhNhanLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLOAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBENHNHAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABSTIEPNHAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABSTHEODOI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_BN_GIUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_BS_CHUATRI)).BeginInit();
            this.SuspendLayout();
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(666, 311);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(83, 25);
            hoLabel.TabIndex = 3;
            hoLabel.Text = "Họ Tên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.Location = new System.Drawing.Point(640, 353);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(109, 25);
            ngaySinhLabel.TabIndex = 7;
            ngaySinhLabel.Text = "Ngày Sinh:";
            // 
            // maLoaiLabel
            // 
            maLoaiLabel.AutoSize = true;
            maLoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLoaiLabel.Location = new System.Drawing.Point(32, 383);
            maLoaiLabel.Name = "maLoaiLabel";
            maLoaiLabel.Size = new System.Drawing.Size(55, 25);
            maLoaiLabel.TabIndex = 8;
            maLoaiLabel.Text = "Loại:";
            // 
            // maBacSiTheoDoiLabel
            // 
            maBacSiTheoDoiLabel.AutoSize = true;
            maBacSiTheoDoiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maBacSiTheoDoiLabel.Location = new System.Drawing.Point(557, 406);
            maBacSiTheoDoiLabel.Name = "maBacSiTheoDoiLabel";
            maBacSiTheoDoiLabel.Size = new System.Drawing.Size(193, 25);
            maBacSiTheoDoiLabel.TabIndex = 10;
            maBacSiTheoDoiLabel.Text = "Mã Bác Sĩ Theo Dõi:";
            // 
            // maBacSiTiepNhanLabel
            // 
            maBacSiTiepNhanLabel.AutoSize = true;
            maBacSiTiepNhanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maBacSiTiepNhanLabel.Location = new System.Drawing.Point(545, 456);
            maBacSiTiepNhanLabel.Name = "maBacSiTiepNhanLabel";
            maBacSiTiepNhanLabel.Size = new System.Drawing.Size(204, 25);
            maBacSiTiepNhanLabel.TabIndex = 12;
            maBacSiTiepNhanLabel.Text = "Mã Bác Sĩ Tiếp Nhận:";
            // 
            // maBenhNhanLabel1
            // 
            maBenhNhanLabel1.AutoSize = true;
            maBenhNhanLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maBenhNhanLabel1.Location = new System.Drawing.Point(24, 309);
            maBenhNhanLabel1.Name = "maBenhNhanLabel1";
            maBenhNhanLabel1.Size = new System.Drawing.Size(149, 25);
            maBenhNhanLabel1.TabIndex = 16;
            maBenhNhanLabel1.Text = "Mã Bệnh Nhân:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 128);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BỆNH NHÂN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbLOAI);
            this.panel2.Controls.Add(this.txtMABSTIEPNHAN);
            this.panel2.Controls.Add(this.txtMABSTHEODOI);
            this.panel2.Controls.Add(this.dteNGAYSINH);
            this.panel2.Controls.Add(this.txtTEN);
            this.panel2.Controls.Add(this.txtHO);
            this.panel2.Controls.Add(maBenhNhanLabel1);
            this.panel2.Controls.Add(this.txtMABN);
            this.panel2.Controls.Add(this.bENHNHANGridControl);
            this.panel2.Controls.Add(this.btnCHONBSTIEPNHAN);
            this.panel2.Controls.Add(this.btnCHONBSTHEODOI);
            this.panel2.Controls.Add(maBacSiTiepNhanLabel);
            this.panel2.Controls.Add(maBacSiTheoDoiLabel);
            this.panel2.Controls.Add(maLoaiLabel);
            this.panel2.Controls.Add(ngaySinhLabel);
            this.panel2.Controls.Add(hoLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1501, 515);
            this.panel2.TabIndex = 4;
            // 
            // cbLOAI
            // 
            this.cbLOAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBENHNHAN, "MaLoai", true));
            this.cbLOAI.Location = new System.Drawing.Point(111, 383);
            this.cbLOAI.MenuManager = this.barManager1;
            this.cbLOAI.Name = "cbLOAI";
            this.cbLOAI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLOAI.Properties.Appearance.Options.UseFont = true;
            this.cbLOAI.Properties.Caption = "Nội Trú";
            this.cbLOAI.Size = new System.Drawing.Size(155, 28);
            this.cbLOAI.TabIndex = 23;
            this.cbLOAI.CheckedChanged += new System.EventHandler(this.cbLOAI_CheckedChanged);
            // 
            // bdsBENHNHAN
            // 
            this.bdsBENHNHAN.DataMember = "BENHNHAN";
            this.bdsBENHNHAN.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1501, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 673);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1501, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 643);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1501, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 643);
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
            // txtMABSTIEPNHAN
            // 
            this.txtMABSTIEPNHAN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBENHNHAN, "MaBacSiTiepNhan", true));
            this.txtMABSTIEPNHAN.Enabled = false;
            this.txtMABSTIEPNHAN.Location = new System.Drawing.Point(804, 453);
            this.txtMABSTIEPNHAN.MenuManager = this.barManager1;
            this.txtMABSTIEPNHAN.Name = "txtMABSTIEPNHAN";
            this.txtMABSTIEPNHAN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABSTIEPNHAN.Properties.Appearance.Options.UseFont = true;
            this.txtMABSTIEPNHAN.Size = new System.Drawing.Size(125, 30);
            this.txtMABSTIEPNHAN.TabIndex = 22;
            // 
            // txtMABSTHEODOI
            // 
            this.txtMABSTHEODOI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBENHNHAN, "MaBacSiTheoDoi", true));
            this.txtMABSTHEODOI.Enabled = false;
            this.txtMABSTHEODOI.Location = new System.Drawing.Point(804, 403);
            this.txtMABSTHEODOI.MenuManager = this.barManager1;
            this.txtMABSTHEODOI.Name = "txtMABSTHEODOI";
            this.txtMABSTHEODOI.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABSTHEODOI.Properties.Appearance.Options.UseFont = true;
            this.txtMABSTHEODOI.Size = new System.Drawing.Size(125, 30);
            this.txtMABSTHEODOI.TabIndex = 21;
            // 
            // dteNGAYSINH
            // 
            this.dteNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBENHNHAN, "NgaySinh", true));
            this.dteNGAYSINH.EditValue = null;
            this.dteNGAYSINH.Location = new System.Drawing.Point(804, 348);
            this.dteNGAYSINH.MenuManager = this.barManager1;
            this.dteNGAYSINH.Name = "dteNGAYSINH";
            this.dteNGAYSINH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNGAYSINH.Properties.Appearance.Options.UseFont = true;
            this.dteNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAYSINH.Size = new System.Drawing.Size(256, 30);
            this.dteNGAYSINH.TabIndex = 20;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBENHNHAN, "Ten", true));
            this.txtTEN.Location = new System.Drawing.Point(935, 305);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEN.Properties.Appearance.Options.UseFont = true;
            this.txtTEN.Size = new System.Drawing.Size(125, 30);
            this.txtTEN.TabIndex = 19;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBENHNHAN, "Ho", true));
            this.txtHO.Location = new System.Drawing.Point(804, 305);
            this.txtHO.MenuManager = this.barManager1;
            this.txtHO.Name = "txtHO";
            this.txtHO.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHO.Properties.Appearance.Options.UseFont = true;
            this.txtHO.Size = new System.Drawing.Size(125, 30);
            this.txtHO.TabIndex = 18;
            // 
            // txtMABN
            // 
            this.txtMABN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBENHNHAN, "MaBenhNhan", true));
            this.txtMABN.Location = new System.Drawing.Point(232, 306);
            this.txtMABN.MenuManager = this.barManager1;
            this.txtMABN.Name = "txtMABN";
            this.txtMABN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABN.Properties.Appearance.Options.UseFont = true;
            this.txtMABN.Size = new System.Drawing.Size(208, 30);
            this.txtMABN.TabIndex = 17;
            // 
            // bENHNHANGridControl
            // 
            this.bENHNHANGridControl.DataSource = this.bdsBENHNHAN;
            this.bENHNHANGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bENHNHANGridControl.Location = new System.Drawing.Point(0, 0);
            this.bENHNHANGridControl.MainView = this.gridView1;
            this.bENHNHANGridControl.MenuManager = this.barManager1;
            this.bENHNHANGridControl.Name = "bENHNHANGridControl";
            this.bENHNHANGridControl.Size = new System.Drawing.Size(1501, 287);
            this.bENHNHANGridControl.TabIndex = 15;
            this.bENHNHANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaBenhNhan,
            this.colHo,
            this.colTen,
            this.colNgaySinh,
            this.colMaLoai,
            this.colMaBacSiTheoDoi,
            this.colMaBacSiTiepNhan});
            this.gridView1.GridControl = this.bENHNHANGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaBenhNhan
            // 
            this.colMaBenhNhan.FieldName = "MaBenhNhan";
            this.colMaBenhNhan.MinWidth = 25;
            this.colMaBenhNhan.Name = "colMaBenhNhan";
            this.colMaBenhNhan.Visible = true;
            this.colMaBenhNhan.VisibleIndex = 0;
            this.colMaBenhNhan.Width = 94;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            this.colNgaySinh.Width = 94;
            // 
            // colMaLoai
            // 
            this.colMaLoai.FieldName = "MaLoai";
            this.colMaLoai.MinWidth = 25;
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Visible = true;
            this.colMaLoai.VisibleIndex = 4;
            this.colMaLoai.Width = 94;
            // 
            // colMaBacSiTheoDoi
            // 
            this.colMaBacSiTheoDoi.FieldName = "MaBacSiTheoDoi";
            this.colMaBacSiTheoDoi.MinWidth = 25;
            this.colMaBacSiTheoDoi.Name = "colMaBacSiTheoDoi";
            this.colMaBacSiTheoDoi.Visible = true;
            this.colMaBacSiTheoDoi.VisibleIndex = 5;
            this.colMaBacSiTheoDoi.Width = 94;
            // 
            // colMaBacSiTiepNhan
            // 
            this.colMaBacSiTiepNhan.FieldName = "MaBacSiTiepNhan";
            this.colMaBacSiTiepNhan.MinWidth = 25;
            this.colMaBacSiTiepNhan.Name = "colMaBacSiTiepNhan";
            this.colMaBacSiTiepNhan.Visible = true;
            this.colMaBacSiTiepNhan.VisibleIndex = 6;
            this.colMaBacSiTiepNhan.Width = 94;
            // 
            // btnCHONBSTIEPNHAN
            // 
            this.btnCHONBSTIEPNHAN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCHONBSTIEPNHAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHONBSTIEPNHAN.Location = new System.Drawing.Point(984, 448);
            this.btnCHONBSTIEPNHAN.Name = "btnCHONBSTIEPNHAN";
            this.btnCHONBSTIEPNHAN.Size = new System.Drawing.Size(284, 44);
            this.btnCHONBSTIEPNHAN.TabIndex = 15;
            this.btnCHONBSTIEPNHAN.Text = "Chọn bác sĩ tiếp nhận";
            this.btnCHONBSTIEPNHAN.UseVisualStyleBackColor = false;
            this.btnCHONBSTIEPNHAN.Click += new System.EventHandler(this.btnCHONBSTIEPNHAN_Click);
            // 
            // btnCHONBSTHEODOI
            // 
            this.btnCHONBSTHEODOI.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCHONBSTHEODOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHONBSTHEODOI.Location = new System.Drawing.Point(984, 398);
            this.btnCHONBSTHEODOI.Name = "btnCHONBSTHEODOI";
            this.btnCHONBSTHEODOI.Size = new System.Drawing.Size(284, 43);
            this.btnCHONBSTHEODOI.TabIndex = 14;
            this.btnCHONBSTHEODOI.Text = "Chọn bác sĩ theo dõi";
            this.btnCHONBSTHEODOI.UseVisualStyleBackColor = false;
            this.btnCHONBSTHEODOI.Click += new System.EventHandler(this.btnCHONBSTHEODOI_Click);
            // 
            // bENHNHANTableAdapter
            // 
            this.bENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = this.bENHNHANTableAdapter;
            this.tableAdapterManager.CT_BACSI_CHUATRI_BENHNHANTableAdapter = this.cT_BACSI_CHUATRI_BENHNHANTableAdapter;
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
            // cT_BACSI_CHUATRI_BENHNHANTableAdapter
            // 
            this.cT_BACSI_CHUATRI_BENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // cT_BENHNHAN_GIUONGTableAdapter
            // 
            this.cT_BENHNHAN_GIUONGTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCT_BN_GIUONG
            // 
            this.bdsCT_BN_GIUONG.DataMember = "FK_MaBenhNhan_CT_BENHNHAN_GIUONG";
            this.bdsCT_BN_GIUONG.DataSource = this.bdsBENHNHAN;
            // 
            // bdsCT_BS_CHUATRI
            // 
            this.bdsCT_BS_CHUATRI.DataMember = "FK_MaBenhNhan_CT_BACSI_CHUATRI_BENHNHAN";
            this.bdsCT_BS_CHUATRI.DataSource = this.bdsBENHNHAN;
            // 
            // FormBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBenhNhan";
            this.Text = "FormBenhNhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBenhNhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLOAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBENHNHAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABSTIEPNHAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABSTHEODOI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_BN_GIUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_BS_CHUATRI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnLUU;
        private DevExpress.XtraBars.BarButtonItem btnUNDO;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.Button btnCHONBSTHEODOI;
        private System.Windows.Forms.Button btnCHONBSTIEPNHAN;
        private System.Windows.Forms.BindingSource bdsBENHNHAN;
        private HOSPITALDataSet DS;
        private HOSPITALDataSetTableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bENHNHANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBacSiTheoDoi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBacSiTiepNhan;
        private HOSPITALDataSetTableAdapters.CT_BENHNHAN_GIUONGTableAdapter cT_BENHNHAN_GIUONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_BN_GIUONG;
        private HOSPITALDataSetTableAdapters.CT_BACSI_CHUATRI_BENHNHANTableAdapter cT_BACSI_CHUATRI_BENHNHANTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_BS_CHUATRI;
        private DevExpress.XtraEditors.CheckEdit cbLOAI;
        private DevExpress.XtraEditors.TextEdit txtMABSTIEPNHAN;
        private DevExpress.XtraEditors.TextEdit txtMABSTHEODOI;
        private DevExpress.XtraEditors.DateEdit dteNGAYSINH;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMABN;
    }
}