using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENHVIEN.FormChon
{
    public partial class FormChonBenhNhan : Form
    {
        public FormChonBenhNhan()
        {
            InitializeComponent();
        }

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bENHNHANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonBenhNhan_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.bENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bENHNHANTableAdapter.FillByLoai(this.DS.BENHNHAN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maBN = ((DataRowView)bENHNHANBindingSource.Current)["mabenhnhan"].ToString();
            Program.maBN = maBN;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
