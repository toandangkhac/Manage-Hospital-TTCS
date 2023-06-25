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
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Backup Files (*.bak)|*.bak";
            choofdlog.FilterIndex = 1;


            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
         
              txtPATH.Text = choofdlog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPATH.Text == "")
            {
                MessageBox.Show("Hãy chọn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
           

            String path = txtPATH.Text.ToString().Trim() ;

            String query = "EXEC RESTORE_DATABASE " + "@PATH= N'" + path + "'";
            Program.loi = 0;
            int n = Program.ExecSqlNonQuery(query);
            if (Program.loi == 1)
            {
                MessageBox.Show("Không thể Restore do có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.loi = 0;
                return;
            }
            MessageBox.Show("Restore thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
