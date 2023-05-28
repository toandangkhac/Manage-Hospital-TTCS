namespace BENHVIEN.FormChon
{
    partial class FormChonBacSi
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
            this.bdsBACSI = new System.Windows.Forms.BindingSource(this.components);
            this.bACSITableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.THONGTINBACSITableAdapter();
            this.tableAdapterManager1 = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.tHONGTINBACSIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaBacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrinhDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBACSI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBACSIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBACSI
            // 
            this.bdsBACSI.DataMember = "THONGTINBACSI";
            this.bdsBACSI.DataSource = this.DS;
            // 
            // bACSITableAdapter
            // 
            this.bACSITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BACSITableAdapter = null;
            this.tableAdapterManager1.BENHNHANTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CT_BACSI_CHUATRI_BENHNHANTableAdapter = null;
            this.tableAdapterManager1.CT_BENHNHAN_GIUONGTableAdapter = null;
            this.tableAdapterManager1.CT_HOADONTableAdapter = null;
            this.tableAdapterManager1.CT_NV_KHUCHUATRITableAdapter = null;
            this.tableAdapterManager1.GIUONGBENHTableAdapter = null;
            this.tableAdapterManager1.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager1.NHANVIENTableAdapter = null;
            this.tableAdapterManager1.SUCHUATRITableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VATTUTableAdapter = null;
            this.tableAdapterManager1.YTATableAdapter = null;
            // 
            // tHONGTINBACSIGridControl
            // 
            this.tHONGTINBACSIGridControl.DataSource = this.bdsBACSI;
            this.tHONGTINBACSIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tHONGTINBACSIGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.tHONGTINBACSIGridControl.Location = new System.Drawing.Point(0, 0);
            this.tHONGTINBACSIGridControl.MainView = this.gridView1;
            this.tHONGTINBACSIGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.tHONGTINBACSIGridControl.Name = "tHONGTINBACSIGridControl";
            this.tHONGTINBACSIGridControl.Size = new System.Drawing.Size(974, 318);
            this.tHONGTINBACSIGridControl.TabIndex = 3;
            this.tHONGTINBACSIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaBacSi,
            this.colHo,
            this.colTen,
            this.colTrinhDo});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.tHONGTINBACSIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaBacSi
            // 
            this.colMaBacSi.FieldName = "MaBacSi";
            this.colMaBacSi.MinWidth = 31;
            this.colMaBacSi.Name = "colMaBacSi";
            this.colMaBacSi.Visible = true;
            this.colMaBacSi.VisibleIndex = 0;
            this.colMaBacSi.Width = 117;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 31;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 117;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 31;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 117;
            // 
            // colTrinhDo
            // 
            this.colTrinhDo.FieldName = "TrinhDo";
            this.colTrinhDo.MinWidth = 31;
            this.colTrinhDo.Name = "colTrinhDo";
            this.colTrinhDo.Visible = true;
            this.colTrinhDo.VisibleIndex = 3;
            this.colTrinhDo.Width = 117;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(544, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Huỷ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(297, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 58);
            this.button4.TabIndex = 8;
            this.button4.Text = "Xác Nhận";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormChonBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 505);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tHONGTINBACSIGridControl);
            this.Name = "FormChonBacSi";
            this.Text = "FormChonBacSi";
            this.Load += new System.EventHandler(this.FormChonBacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBACSI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINBACSIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource bdsBACSI;
        private HOSPITALDataSetTableAdapters.THONGTINBACSITableAdapter bACSITableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl tHONGTINBACSIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBacSi;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colTrinhDo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}