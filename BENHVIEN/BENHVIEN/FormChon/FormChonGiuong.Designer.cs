namespace BENHVIEN.FormChon
{
    partial class FormChonGiuong
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
            this.gIUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIUONGTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.GIUONGTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.gIUONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIUONGBindingSource
            // 
            this.gIUONGBindingSource.DataMember = "GIUONG";
            this.gIUONGBindingSource.DataSource = this.DS;
            // 
            // gIUONGTableAdapter
            // 
            this.gIUONGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // gIUONGGridControl
            // 
            this.gIUONGGridControl.DataSource = this.gIUONGBindingSource;
            this.gIUONGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIUONGGridControl.Location = new System.Drawing.Point(0, 0);
            this.gIUONGGridControl.MainView = this.gridView1;
            this.gIUONGGridControl.Name = "gIUONGGridControl";
            this.gIUONGGridControl.Size = new System.Drawing.Size(955, 421);
            this.gIUONGGridControl.TabIndex = 1;
            this.gIUONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGiuong,
            this.colSoGiuong,
            this.colSoPhong,
            this.colTenKhu});
            this.gridView1.GridControl = this.gIUONGGridControl;
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
            // colTenKhu
            // 
            this.colTenKhu.FieldName = "TenKhu";
            this.colTenKhu.MinWidth = 25;
            this.colTenKhu.Name = "colTenKhu";
            this.colTenKhu.Visible = true;
            this.colTenKhu.VisibleIndex = 3;
            this.colTenKhu.Width = 94;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(538, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChonGiuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gIUONGGridControl);
            this.Name = "FormChonGiuong";
            this.Text = "FormChonGiuong";
            this.Load += new System.EventHandler(this.FormChonGiuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIUONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource gIUONGBindingSource;
        private HOSPITALDataSetTableAdapters.GIUONGTableAdapter gIUONGTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIUONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}