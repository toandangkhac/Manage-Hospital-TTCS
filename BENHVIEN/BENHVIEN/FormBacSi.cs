using BENHVIEN.FormChon;
using System;
using System.Collections;
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
    public partial class FormBacSi : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;

        public FormBacSi()
        {
            InitializeComponent();
        }

        private void FormBacSi_Load(object sender, EventArgs e)
        {
           


            DS.EnforceConstraints = false;

            this.bACSITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bACSITableAdapter.Fill(this.DS.BACSI);

            this.tHONGTINTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHONGTINTableAdapter.Fill(this.DS.THONGTIN);

            this.bENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bENHNHANTableAdapter.Fill(this.DS.BENHNHAN);
            this.cT_BACSI_CHUATRI_BENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BACSI_CHUATRI_BENHNHANTableAdapter.Fill(this.DS.CT_BACSI_CHUATRI_BENHNHAN);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FormChonNhanVien();
            f.ShowDialog();
            txtMABS.Text = Program.maNV;
            Program.maNV = "";


        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsBACSI.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsBACSI.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
        }

        private bool kiemTraDuLieuDauVao()
        {


            if (txtMABS.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtTRINHDO.Text == "")
            {
                MessageBox.Show("Không bỏ trống trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }



            return true;
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = bdsBACSI.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)bdsBACSI[bdsBACSI.Position]);



            String maBS = drv["mabacsi"].ToString();
            String trinhDo = drv["trinhdo"].ToString();


            /*them moi | sua nhan vien*/
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        btnTHEM.Enabled = true;
                        btnXOA.Enabled = true;
                        btnLUU.Enabled = true;
                        btnUNDO.Enabled = true;

                        btnLAMMOI.Enabled = true;
                        btnCHUYENCHINHANH.Enabled = true;
                        btnTHOAT.Enabled = true;


                        this.bdsBACSI.EndEdit();
                        this.bACSITableAdapter.Update(this.DS.BACSI);


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {


                            queryUndo = "" +
                               "DELETE DBO.BACSI " +
                               "WHERE maBacSi = '" + txtMABS.Text.Trim()+ "'";


                        }
                        else
                        {


                            queryUndo =
                                "UPDATE DBO.BACSI " +
                                "SET " +
                                "TRINHDO = N'" + trinhDo +"' " +                          
                                "WHERE MABACSI = '" + maBS + "'";
                        }


                        /*Đưa câu truy vấn hoàn tác vào undoList */

                        undoList.Push(queryUndo);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsBACSI.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.bACSITableAdapter.Fill(this.DS.BACSI);
                    bdsBACSI.Position = viTriThem;
              
                    this.tHONGTINTableAdapter.Fill(this.DS.THONGTIN);
                }
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DS.EnforceConstraints = false;

            this.bACSITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bACSITableAdapter.Fill(this.DS.BACSI);

            this.tHONGTINTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHONGTINTableAdapter.Fill(this.DS.THONGTIN);
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsBACSI.Count == 0)
            {
                btnXOA.Enabled = false;
            }


            if (cT_BACSI_CHUATRI_BENHNHANBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá bác sĩ này vì có chi tiết chữa trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          

            DataRowView drv = ((DataRowView)bdsBACSI[bdsBACSI.Position]);
            String maBS = drv["mabacsi"].ToString();
            String trinhDo = drv["trinhdo"].ToString();


            string queryUndo =
                string.Format("INSERT INTO DBO.BACSI( mabacsi,trinhdo)" +
            "VALUES('{0}',N'{1}')", maBS, trinhDo);


            undoList.Push(queryUndo);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bác sĩ này không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsBACSI.Position;
                    bdsBACSI.RemoveCurrent();

                    this.bACSITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bACSITableAdapter.Update(this.DS.BACSI);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.bACSITableAdapter.Fill(this.DS.BACSI);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsBACSI.Position = viTri;

                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void btnUNDO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnLUU.Enabled = true;

                this.btnUNDO.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnCHUYENCHINHANH.Enabled = true;
                this.btnTHOAT.Enabled = true;


                dangThemMoi = false;

                /*xoa dong hien tai*/
                bdsBACSI.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsBACSI.Position = viTri;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUNDO.Enabled = false;
                return;
            }
            bdsBACSI.CancelEdit();
            String queryUndo = undoList.Pop().ToString();
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(queryUndo);

            }
            this.bACSITableAdapter.Fill(this.DS.BACSI);
        }
    }
}
