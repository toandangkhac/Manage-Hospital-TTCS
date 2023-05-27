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
    public partial class FormSuChuaTri : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;
        public FormSuChuaTri()
        {
            InitializeComponent();
        }

        private void FormSuChuaTri_Load(object sender, EventArgs e)
        {
            
            HOSPITAL_DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'hOSPITALDataSet.SUCHUATRI' table. You can move, or remove it, as needed.
            this.SUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.SUCHUATRITableAdapter.Fill(this.HOSPITAL_DS.SUCHUATRI);

            // TODO: This line of code loads data into the 'HOSPITAL_DS.CT_BACSI_CHUATRI_BENHNHAN' table. You can move, or remove it, as needed.
            this.CT_BACSI_CHUATRI_BENHNHANTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.CT_BACSI_CHUATRI_BENHNHANTableAdapter.Fill(this.HOSPITAL_DS.CT_BACSI_CHUATRI_BENHNHAN);
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            /*lấy vị trí hiện tại của con trỏ*/
            viTri = SUCHUATRI_BDS.Position;

            dangThemMoi = true;
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            SUCHUATRI_BDS.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;
            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
        }
        private bool kiemTraDuLieuDauVao()
        {

            /*kiem tra txtHO*/
            if (txtTenSCT.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên sự chữa trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSCT.Focus();
                return false;
            }
            return true;
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = SUCHUATRI_BDS.Position;
           
            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)SUCHUATRI_BDS[SUCHUATRI_BDS.Position]);
            String TenCu = drv["TenSuChuaTri"].ToString();
            String MaSCT = txtMaSCT.Text.ToString();
            String TenSCT = txtTenSCT.Text.ToString();

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


                        this.SUCHUATRI_BDS.EndEdit();
                        /*  this.bENHNHANTableAdapter.Update(this.DS.BENHNHAN);*/


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            /*queryUndo = "" +
                                "DELETE DBO.BENHNHAN " +
                                "WHERE MaBenhNhan = " + txtMABN.Text.Trim();
*/
                            this.SUCHUATRI_BDS.RemoveCurrent();
                            string query =
                                string.Format("EXEC SP_Them_SuChuaTri N'{0}'", TenSCT);
                            int n = Program.ExecSqlNonQuery(query);
                            queryUndo = string.Format("EXEC SP_Xoa_SuChuaTri N'{0}'", TenSCT);
                            undoList.Push(queryUndo); 
                        }

                        else
                        {





                            queryUndo =
                                "UPDATE DBO.SUCHUATRI " +
                                "SET " +
                                "TenSuChuaTri = N'" + TenCu + "' " +
                                "WHERE MaSuChuaTri = '" + MaSCT + "'";




                            this.SUCHUATRI_BDS.EndEdit();
                            this.SUCHUATRITableAdapter.Update(this.HOSPITAL_DS.SUCHUATRI);
                            undoList.Push(queryUndo);
                        }





                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        SUCHUATRI_BDS.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.SUCHUATRITableAdapter.Fill(this.HOSPITAL_DS.SUCHUATRI);
                    SUCHUATRI_BDS.Position = viTriThem;
                }
            }

        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSCT = txtMaSCT.Text.Trim();// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)SUCHUATRI_BDS[SUCHUATRI_BDS.Position]);

            String tenSCT = txtTenSCT.Text.ToString();
            if (SUCHUATRI_BDS.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (CT_BACSI_CHUATRI_BENHNHAN_BDS.Count > 0)
            {
                MessageBox.Show("Không thể xoá sự chữa trị này vì đã lập chi tiết chữa trị bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryUndo =
string.Format("INSERT INTO DBO.SUCHUATRI(MaSuChuaTri, TenSuChuaTri) " +
"VALUES('{0}',N'{1}')", maSCT, tenSCT);

            undoList.Push(queryUndo);



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = SUCHUATRI_BDS.Position;
                    SUCHUATRI_BDS.RemoveCurrent();

                    this.SUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SUCHUATRITableAdapter.Update(this.HOSPITAL_DS.SUCHUATRI);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.SUCHUATRITableAdapter.Fill(this.HOSPITAL_DS.SUCHUATRI);
                    // tro ve vi tri cua nhan vien dang bi loi
                    SUCHUATRI_BDS.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
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
                dangThemMoi = false;



                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnLUU.Enabled = true;


                this.btnLAMMOI.Enabled = true;

                this.btnTHOAT.Enabled = true;



                /*  bds.CancelEdit();*/
                /*xoa dong hien tai*/
                SUCHUATRI_BDS.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                SUCHUATRI_BDS.Position = viTri;


                return;
            }


            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUNDO.Enabled = false;
                return;
            }


            SUCHUATRI_BDS.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.SUCHUATRITableAdapter.Fill(this.HOSPITAL_DS.SUCHUATRI);
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.SUCHUATRITableAdapter.Fill(this.HOSPITAL_DS.SUCHUATRI);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
