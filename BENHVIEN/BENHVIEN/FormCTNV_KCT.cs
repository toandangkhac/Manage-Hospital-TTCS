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
    public partial class FormCTNV_KCT : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;

        public FormCTNV_KCT()
        {
            InitializeComponent();
        }

        private void cT_NV_KHUCHUATRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTNV_KCT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormCTNV_KCT_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.cT_NV_KHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NV_KHUCHUATRITableAdapter.Fill(this.DS.CT_NV_KHUCHUATRI);

        }

        private void btnCHONNV_Click(object sender, EventArgs e)
        {
            Form f = new FormChonNhanVien_KCT();
            f.ShowDialog();
            txtMANV.Text = Program.maNV;
            Program.maNV = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FormChonKhu();
            f.ShowDialog();
            txtSOKHU.Text = Program.maKhu;
            Program.maKhu = "";
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            viTri = bdsCTNV_KCT.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsCTNV_KCT.AddNew();

            dteNGAYBD.EditValue = DateTime.Now;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnCHUYENCHINHANH.Enabled = false;
            this.btnTHOAT.Enabled = false;
        }
        private bool kiemTraDuLieuDauVao()
        {

            if (txtMANV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtSOKHU.Text == "")
            {
                MessageBox.Show("Không bỏ trống số khu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (dteNGAYBD.Text == "")
            {
                MessageBox.Show("Không bỏ trống ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (dteNGAYKT.Text == "")
            {
                MessageBox.Show("Không bỏ trống ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;


        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;



            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/


            DataRowView drv = ((DataRowView)bdsCTNV_KCT[bdsCTNV_KCT.Position]);
            String maNv = (drv["manv"].ToString());
            String soKhu = (drv["sokhu"].ToString());
            String ngayBD = (drv["ngayBD"].ToString());
            String ngayKT = (drv["ngayKT"].ToString());


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
                        btnTHOAT.Enabled = true;


                        this.bdsCTNV_KCT.EndEdit();
                        this.cT_NV_KHUCHUATRITableAdapter.Update(this.DS.CT_NV_KHUCHUATRI);


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            queryUndo = "" +
                                "DELETE DBO.CT_NV_KHUCHUATRI " +
                                "WHERE manv = '" + txtMANV.Text.Trim() + "' AND sokhu = '" + txtSOKHU.Text.Trim() + "' AND ngayBD = '" + dteNGAYBD.Text + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin nhân viên*/
                        else
                        {
                            

                            queryUndo =
                                "UPDATE DBO.CT_NV_KHUCHUATRI " +
                                "SET " +
                                "manv = '" + maNv + "'," +
                                "sokhu = '" + soKhu + "'," +
                                "NGAYBD = '" + ngayBD + "' ," +
                                "NGAYKT = '" + ngayKT + "'" +
                                "WHERE manv = '" + txtMANV.Text.Trim() + "' AND sokhu = '" + txtSOKHU.Text.Trim() + "' AND ngayBD = '" + dteNGAYBD.Text + "'";
                        }


                        /*Đưa câu truy vấn hoàn tác vào undoList */

                        undoList.Push(queryUndo);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsCTNV_KCT.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                bdsCTNV_KCT.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsCTNV_KCT.Position = viTri;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUNDO.Enabled = false;
                return;
            }
            bdsCTNV_KCT.CancelEdit();
            String queryUndo = undoList.Pop().ToString();
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(queryUndo);

            }
            this.cT_NV_KHUCHUATRITableAdapter.Fill(this.DS.CT_NV_KHUCHUATRI);

        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = ((DataRowView)bdsCTNV_KCT[bdsCTNV_KCT.Position]);
            String maNv = (drv["manv"].ToString());
            String soKhu = (drv["sokhu"].ToString());
            String ngayBD = (drv["ngayBD"].ToString());
            String ngayKT = (drv["ngayKT"].ToString());

            string queryUndo =
                string.Format("INSERT INTO DBO.CT_NV_KHUCHUATRI( manv,sokhu,ngaybd,ngaykt)" +
            "VALUES('{0}','{1}','{2}','{3}')", maNv, soKhu, ngayBD, ngayKT);


            undoList.Push(queryUndo);


            if (MessageBox.Show("Bạn có chắc chắn muốn xoá chi tiết này không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsCTNV_KCT.Position;
                    bdsCTNV_KCT.RemoveCurrent();

                    this.cT_NV_KHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_NV_KHUCHUATRITableAdapter.Update(this.DS.CT_NV_KHUCHUATRI);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.cT_NV_KHUCHUATRITableAdapter.Fill(this.DS.CT_NV_KHUCHUATRI);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsCTNV_KCT.Position = viTri;

                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DS.EnforceConstraints = false;

            this.cT_NV_KHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NV_KHUCHUATRITableAdapter.Fill(this.DS.CT_NV_KHUCHUATRI);
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
