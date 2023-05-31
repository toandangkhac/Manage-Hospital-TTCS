namespace BENHVIEN.FormChon
{
    partial class FormChonYTAcs
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
            this.bdsYTA = new System.Windows.Forms.BindingSource(this.components);
            this.yTATableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.YTATableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.yTAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsYTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsYTA
            // 
            this.bdsYTA.DataMember = "YTA";
            this.bdsYTA.DataSource = this.DS;
            this.bdsYTA.CurrentChanged += new System.EventHandler(this.yTABindingSource_CurrentChanged);
            // 
            // yTATableAdapter
            // 
            this.yTATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
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
            this.tableAdapterManager.YTATableAdapter = this.yTATableAdapter;
            // 
            // yTAGridControl
            // 
            this.yTAGridControl.DataSource = this.bdsYTA;
            this.yTAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.yTAGridControl.Location = new System.Drawing.Point(0, 0);
            this.yTAGridControl.MainView = this.gridView1;
            this.yTAGridControl.Name = "yTAGridControl";
            this.yTAGridControl.Size = new System.Drawing.Size(800, 220);
            this.yTAGridControl.TabIndex = 1;
            this.yTAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaYT,
            this.colCongViec});
            this.gridView1.GridControl = this.yTAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaYT
            // 
            this.colMaYT.FieldName = "MaYT";
            this.colMaYT.MinWidth = 25;
            this.colMaYT.Name = "colMaYT";
            this.colMaYT.Visible = true;
            this.colMaYT.VisibleIndex = 0;
            this.colMaYT.Width = 94;
            // 
            // colCongViec
            // 
            this.colCongViec.FieldName = "CongViec";
            this.colCongViec.MinWidth = 25;
            this.colCongViec.Name = "colCongViec";
            this.colCongViec.Visible = true;
            this.colCongViec.VisibleIndex = 1;
            this.colCongViec.Width = 94;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(453, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 58);
            this.button3.TabIndex = 11;
            this.button3.Text = "Huỷ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(206, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 58);
            this.button4.TabIndex = 10;
            this.button4.Text = "Xác Nhận";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormChonYTAcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.yTAGridControl);
            this.Name = "FormChonYTAcs";
            this.Text = "FormChonYTAcs";
            this.Load += new System.EventHandler(this.FormChonYTAcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsYTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource bdsYTA;
        private HOSPITALDataSetTableAdapters.YTATableAdapter yTATableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl yTAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaYT;
        private DevExpress.XtraGrid.Columns.GridColumn colCongViec;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}