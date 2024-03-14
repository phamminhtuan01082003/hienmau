using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiến_máu
{
    public partial class frmListResult : Form
    {
        private int id_acc;
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        public frmListResult(int data)
        {
            InitializeComponent();
            id_acc = data;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            if (id_acc != -1) // Nếu người mở form là Người đăng ký hiến máu thì Load DataGridView
            {
                HoSoDK hs = db.HoSoDKs.FirstOrDefault(d => d.IDAccount == id_acc);

                int MaSoHS = hs.mshs;
                dGV_ListResult.DataSource = db.PhieuKQs.Where(d => d.mshs == MaSoHS)
                    .Select(d => new { d.mspDangKy, d.ngayThucSuHienMau, d.tinhTrangHienMau }).ToList();
                
                // Sửa tên các cột
                dGV_ListResult.Columns["mspDangKy"].HeaderText = "Mã số phiếu đăng ký";
                dGV_ListResult.Columns["ngayThucSuHienMau"].HeaderText = "Ngày thực sự hiến máu";
                dGV_ListResult.Columns["tinhTrangHienMau"].HeaderText = "Tình trạng hiến máu";

            }
            else               // Nếu người mở form là Nhân viên thì Load DataGridView
            {
                dGV_ListResult.DataSource = db.PhieuDKs.Where(d => d.trangThaiDK == "Đăng ký thành công")
                     .Select(d => new { d.mspDangKy, d.mshs, d.ngayDKHienMau }).ToList() ;

                // Sửa tên các cột
                dGV_ListResult.Columns["mshs"].HeaderText = "Mã số hồ sơ";
                dGV_ListResult.Columns["mspDangKy"].HeaderText = "Mã số phiếu đăng ký";
                dGV_ListResult.Columns["ngayDKHienMau"].HeaderText = "Ngày đăng ký hiến máu";

            }
            
        }
        // Ấn phím xem chi tiết
        private void btn_detail_Click(object sender, EventArgs e)
        {
            
               if (dGV_ListResult.SelectedRows.Count > 0)
                {
                // Tìm hàng được chọn
                    DataGridViewRow selectedRow = dGV_ListResult.SelectedRows[0];
                    object cellValue = selectedRow.Cells[0].Value;
                
                // Lấy dữ liệu mã số đăng ký từ hàng trên
                    int msdk = Convert.ToInt32(cellValue);
                    PhieuKQ phieuKQ = db.PhieuKQs.FirstOrDefault(t => t.mspKetQua == msdk);
                
                // Load form Phiếu kết quả có mã số đăng ký trên
                    Form f = new frmResult(msdk);
                    f.Show();
                }
            

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
