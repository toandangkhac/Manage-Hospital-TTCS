﻿namespace BENHVIEN
{
    partial class FormRestore
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPATH = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPATH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(603, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Chọn thư mục";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn file Backup:";
            // 
            // txtPATH
            // 
            this.txtPATH.Location = new System.Drawing.Point(225, 307);
            this.txtPATH.Name = "txtPATH";
            this.txtPATH.Size = new System.Drawing.Size(335, 22);
            this.txtPATH.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(216, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "RESTORE DATABASE";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(336, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 57);
            this.button2.TabIndex = 10;
            this.button2.Text = "RESTORE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPATH);
            this.Controls.Add(this.label1);
            this.Name = "FormRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRestore";
            ((System.ComponentModel.ISupportInitialize)(this.txtPATH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPATH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}