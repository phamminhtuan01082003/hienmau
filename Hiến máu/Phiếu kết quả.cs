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
    public partial class frmResult : Form
    {
        private int msdk;
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        public frmResult(int data)
        {
            InitializeComponent();
            // Lấy dữ liệu mã số phiếu đăng ký
            msdk = data;
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            // Lấy các phiếu đăng ký và phiếu kết quả có mã số phiếu đăng ký như trên
            PhieuKQ phieuKQ = db.PhieuKQs.FirstOrDefault(t => t.mspDangKy == msdk);
            PhieuDK phieuDK = db.PhieuDKs.FirstOrDefault(t => t.mspDangKy == msdk);
            txt_place.Text = phieuDK.diaDiemDKHienMau;

            // Load dữ liệu trong database lên DataGridView nếu có
            if (phieuKQ != null)
            {
                dTP_HienMau.Value = phieuKQ.ngayThucSuHienMau;
                txt_amount.Text = phieuKQ.soLuongMauDaHien;
                cbo_status.SelectedItem = phieuKQ.tinhTrangHienMau;
                cbo_type.SelectedItem = phieuKQ.loaiHienMauThucSu;
                txt_health.Text = phieuKQ.tinhTrangSucKhoe;
                txt_note.Text = phieuKQ.ghiChu; 
                
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ấn nút xác nhận
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // Khởi tạo phieuKQ mới trog database
            PhieuKQ phieuKQ = new PhieuKQ();
            // Lấy phiếu đăng ký có mã số phiếu đăng ký như trên
            PhieuDK phieuDK = db.PhieuDKs.FirstOrDefault(t => t.mspDangKy == msdk);

            // Lưu dữ liệu đã nhập vào phieuDK vừa tạo mới
            phieuKQ.mspDangKy = msdk;
            phieuKQ.ngayThucSuHienMau = (DateTime)dTP_HienMau.Value;
            phieuKQ.soLuongMauDaHien = txt_amount.Text;
            phieuKQ.loaiHienMauThucSu = cbo_type.SelectedItem.ToString();
            phieuKQ.tinhTrangHienMau = cbo_status.SelectedItem.ToString();
            phieuKQ.tinhTrangSucKhoe = txt_health.Text;
            phieuKQ.ghiChu = txt_note.Text;
            phieuKQ.mscd = phieuDK.mscd;
            phieuKQ.mshs = phieuDK.mshs;

            // Lưu database
            MessageBox.Show("Xác nhận thành công");
            db.PhieuKQs.InsertOnSubmit(phieuKQ);
            db.SubmitChanges();
        }
    }
}
