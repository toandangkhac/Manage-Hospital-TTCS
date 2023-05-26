namespace BENHVIEN.FormChon
{
    partial class FormChonBenhNhan
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
            this.DS = new BENHVIEN.HOSPITALDataSet();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bENHNHANTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.BENHNHANTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.bENHNHANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBacSiTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBacSiTiepNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHNHANBindingSource
            // 
            this.bENHNHANBindingSource.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource.DataSource = this.DS;
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
            this.tableAdapterManager.CT_BACSI_CHUATRI_BENHNHANTableAdapter = null;
            this.tableAdapterManager.CT_BENHNHAN_GIUONGTableAdapter = null;
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
            // bENHNHANGridControl
            // 
            this.bENHNHANGridControl.DataSource = this.bENHNHANBindingSource;
            this.bENHNHANGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bENHNHANGridControl.Location = new System.Drawing.Point(0, 0);
            this.bENHNHANGridControl.MainView = this.gridView1;
            this.bENHNHANGridControl.Name = "bENHNHANGridControl";
            this.bENHNHANGridControl.Size = new System.Drawing.Size(990, 220);
            this.bENHNHANGridControl.TabIndex = 1;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(534, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChonBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bENHNHANGridControl);
            this.Name = "FormChonBenhNhan";
            this.Text = "FormChonBenhNhan";
            this.Load += new System.EventHandler(this.FormChonBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}