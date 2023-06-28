using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENHVIEN
{
    public partial class FormXemBNTheoDoi : Form
    {
        public FormXemBNTheoDoi()
        {
            InitializeComponent();
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }


        private void FormXemBNTheoDoi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            sP_DSBN_DangTheoDoiTableAdapter.Connection.ConnectionString = Program.connstr;
            sP_DSBN_DangTheoDoiTableAdapter.Fill(DS.SP_DSBN_DangTheoDoi, Program.userName);
            // TODO: This line of code loads data into the 'DS.CT_BENHNHAN_GIUONG' table. You can move, or remove it, as needed.
            this.cT_BENHNHAN_GIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);
        }

    }
}
