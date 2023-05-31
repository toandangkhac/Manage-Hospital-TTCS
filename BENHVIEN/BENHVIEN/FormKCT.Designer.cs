namespace BENHVIEN
{
    partial class FormKCT
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
            System.Windows.Forms.Label soKhuLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label maYTaTruongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKCT));
            this.DS = new BENHVIEN.HOSPITALDataSet();
            this.bdsKCT = new System.Windows.Forms.BindingSource(this.components);
            this.kHUCHUATRITableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.KHUCHUATRITableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.cT_NV_KHUCHUATRITableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_NV_KHUCHUATRITableAdapter();
            this.gIUONGBENHTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.GIUONGBENHTableAdapter();
            this.kHUCHUATRIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoKhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaYTaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.txtSOKHU = new DevExpress.XtraEditors.TextEdit();
            this.txtTENKHU = new DevExpress.XtraEditors.TextEdit();
            this.txtYTT = new DevExpress.XtraEditors.TextEdit();
            this.cT_NV_KHUCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIUONGBENHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            soKhuLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            maYTaTruongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NV_KHUCHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBENHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // soKhuLabel
            // 
            soKhuLabel.AutoSize = true;
            soKhuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soKhuLabel.Location = new System.Drawing.Point(208, 531);
            soKhuLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            soKhuLabel.Name = "soKhuLabel";
            soKhuLabel.Size = new System.Drawing.Size(91, 25);
            soKhuLabel.TabIndex = 5;
            soKhuLabel.Text = "Số Khu:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(197, 623);
            tenLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(102, 25);
            tenLabel.TabIndex = 7;
            tenLabel.Text = "Tên Khu:";
            // 
            // maYTaTruongLabel
            // 
            maYTaTruongLabel.AutoSize = true;
            maYTaTruongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maYTaTruongLabel.Location = new System.Drawing.Point(154, 714);
            maYTaTruongLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            maYTaTruongLabel.Name = "maYTaTruongLabel";
            maYTaTruongLabel.Size = new System.Drawing.Size(140, 25);
            maYTaTruongLabel.TabIndex = 9;
            maYTaTruongLabel.Text = "Y Tá Trưởng:";
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKCT
            // 
            this.bdsKCT.DataMember = "KHUCHUATRI";
            this.bdsKCT.DataSource = this.DS;
            // 
            // kHUCHUATRITableAdapter
            // 
            this.kHUCHUATRITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GIUONGBENHTableAdapter = this.gIUONGBENHTableAdapter;
            this.tableAdapterManager.KHUCHUATRITableAdapter = this.kHUCHUATRITableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // cT_NV_KHUCHUATRITableAdapter
            // 
            this.cT_NV_KHUCHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // gIUONGBENHTableAdapter
            // 
            this.gIUONGBENHTableAdapter.ClearBeforeFill = true;
            // 
            // kHUCHUATRIGridControl
            // 
            this.kHUCHUATRIGridControl.DataSource = this.bdsKCT;
            this.kHUCHUATRIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHUCHUATRIGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.kHUCHUATRIGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kHUCHUATRIGridControl.Location = new System.Drawing.Point(0, 30);
            this.kHUCHUATRIGridControl.MainView = this.gridView1;
            this.kHUCHUATRIGridControl.Margin = new System.Windows.Forms.Padding(5);
            this.kHUCHUATRIGridControl.Name = "kHUCHUATRIGridControl";
            this.kHUCHUATRIGridControl.Size = new System.Drawing.Size(1592, 344);
            this.kHUCHUATRIGridControl.TabIndex = 1;
            this.kHUCHUATRIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoKhu,
            this.colTen,
            this.colMaYTaTruong});
            this.gridView1.DetailHeight = 547;
            this.gridView1.GridControl = this.kHUCHUATRIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colSoKhu
            // 
            this.colSoKhu.FieldName = "SoKhu";
            this.colSoKhu.MinWidth = 41;
            this.colSoKhu.Name = "colSoKhu";
            this.colSoKhu.Visible = true;
            this.colSoKhu.VisibleIndex = 0;
            this.colSoKhu.Width = 153;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 41;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 153;
            // 
            // colMaYTaTruong
            // 
            this.colMaYTaTruong.FieldName = "MaYTaTruong";
            this.colMaYTaTruong.MinWidth = 41;
            this.colMaYTaTruong.Name = "colMaYTaTruong";
            this.colMaYTaTruong.Visible = true;
            this.colMaYTaTruong.VisibleIndex = 2;
            this.colMaYTaTruong.Width = 153;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(1592, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 878);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1592, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 848);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1592, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 848);
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
            // txtSOKHU
            // 
            this.txtSOKHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKCT, "SoKhu", true));
            this.txtSOKHU.Location = new System.Drawing.Point(395, 527);
            this.txtSOKHU.Margin = new System.Windows.Forms.Padding(5);
            this.txtSOKHU.MenuManager = this.barManager1;
            this.txtSOKHU.Name = "txtSOKHU";
            this.txtSOKHU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOKHU.Properties.Appearance.Options.UseFont = true;
            this.txtSOKHU.Size = new System.Drawing.Size(203, 30);
            this.txtSOKHU.TabIndex = 6;
            this.txtSOKHU.EditValueChanged += new System.EventHandler(this.soKhuTextEdit_EditValueChanged);
            // 
            // txtTENKHU
            // 
            this.txtTENKHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKCT, "Ten", true));
            this.txtTENKHU.Location = new System.Drawing.Point(395, 619);
            this.txtTENKHU.Margin = new System.Windows.Forms.Padding(5);
            this.txtTENKHU.MenuManager = this.barManager1;
            this.txtTENKHU.Name = "txtTENKHU";
            this.txtTENKHU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENKHU.Properties.Appearance.Options.UseFont = true;
            this.txtTENKHU.Size = new System.Drawing.Size(203, 30);
            this.txtTENKHU.TabIndex = 8;
            this.txtTENKHU.EditValueChanged += new System.EventHandler(this.tenTextEdit_EditValueChanged);
            // 
            // txtYTT
            // 
            this.txtYTT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKCT, "MaYTaTruong", true));
            this.txtYTT.Enabled = false;
            this.txtYTT.Location = new System.Drawing.Point(395, 709);
            this.txtYTT.Margin = new System.Windows.Forms.Padding(5);
            this.txtYTT.MenuManager = this.barManager1;
            this.txtYTT.Name = "txtYTT";
            this.txtYTT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTT.Properties.Appearance.Options.UseFont = true;
            this.txtYTT.Size = new System.Drawing.Size(203, 30);
            this.txtYTT.TabIndex = 10;
            this.txtYTT.EditValueChanged += new System.EventHandler(this.maYTaTruongTextEdit_EditValueChanged);
            // 
            // cT_NV_KHUCHUATRIBindingSource
            // 
            this.cT_NV_KHUCHUATRIBindingSource.DataMember = "FK_SoKhu_CT_NV_KHUCHUATRI";
            this.cT_NV_KHUCHUATRIBindingSource.DataSource = this.bdsKCT;
            // 
            // gIUONGBENHBindingSource
            // 
            this.gIUONGBENHBindingSource.DataMember = "FK_SoKhu_GIUONGBENH";
            this.gIUONGBENHBindingSource.DataSource = this.bdsKCT;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 693);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "Chọn Y Tá Trưởng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormKCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 878);
            this.Controls.Add(this.button1);
            this.Controls.Add(maYTaTruongLabel);
            this.Controls.Add(this.txtYTT);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.txtTENKHU);
            this.Controls.Add(soKhuLabel);
            this.Controls.Add(this.txtSOKHU);
            this.Controls.Add(this.kHUCHUATRIGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormKCT";
            this.Text = "FormKCT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NV_KHUCHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBENHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource bdsKCT;
        private HOSPITALDataSetTableAdapters.KHUCHUATRITableAdapter kHUCHUATRITableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl kHUCHUATRIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoKhu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaYTaTruong;
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
        private DevExpress.XtraEditors.TextEdit txtYTT;
        private DevExpress.XtraEditors.TextEdit txtTENKHU;
        private DevExpress.XtraEditors.TextEdit txtSOKHU;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private HOSPITALDataSetTableAdapters.CT_NV_KHUCHUATRITableAdapter cT_NV_KHUCHUATRITableAdapter;
        private System.Windows.Forms.BindingSource cT_NV_KHUCHUATRIBindingSource;
        private HOSPITALDataSetTableAdapters.GIUONGBENHTableAdapter gIUONGBENHTableAdapter;
        private System.Windows.Forms.BindingSource gIUONGBENHBindingSource;
        private System.Windows.Forms.Button button1;
    }
}