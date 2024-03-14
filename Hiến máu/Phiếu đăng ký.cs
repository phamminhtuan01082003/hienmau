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
    public partial class frmRegister : Form
    {
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        private int mshs_phieudk;
        private int check_null;
        public frmRegister(int data1, int data2)
        {
            InitializeComponent();
            // Lấy dữ liệu check_null và mã số phiếu đăng ký 
            check_null = data1;
            mshs_phieudk = data2; 
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            // Load diaChi của table ChienDich trong database lên conbobox Địa điểm đăng ký
            this.chienDichTableAdapter.Fill(this.qLDKHienMauDataSet.ChienDich);
            cbo_place.DataSource = db.ChienDiches;
            cbo_place.DisplayMember = "diaChi";
            cbo_place.ValueMember = "diaChi";
            
            // Nếu check_null khác -1 <=> Đã có dữ liệu Phiếu đăng ký từ trước và chưa hiến máu thành công
            if (check_null != -1)
            { 
                // Tìm phiếu đăng ký mới nhất của người dùng
                PhieuDK phieuDK = db.PhieuDKs.OrderByDescending(t => t.mspDangKy).FirstOrDefault(d => d.mshs == mshs_phieudk);

                // Load database lên form
                dTP_Date.Value = (DateTime)phieuDK.ngayDKHienMau;
                dtp_Lastdate.Value = (DateTime)phieuDK.ngayHienMauTruoc;
                cbo_place.SelectedValue = phieuDK.diaDiemDKHienMau.ToString();
                cbo_type.SelectedItem = phieuDK.loaiHienMau.ToString();
                cbo_covid.SelectedItem = phieuDK.tiemVaccineCovid19.ToString();
                cbo_time.SelectedItem = phieuDK.GioDkHienMau.ToString();
                txt_phonenumber.Text = phieuDK.sdtNguoiThan;
                lbl_phieudk.Text = phieuDK.trangThaiDK;
            }    
        }

        // Ấn Phím hoàn tất đăng ký
        private void btn_finish_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("Đăng ký thành công");
            // Khởi tạo phieuDK mới trong database
            PhieuDK phieuDK = new PhieuDK();

            // Lấy dữ liệu địa chỉ trong combobox
            cbo_place.DataSource = db.ChienDiches;
            cbo_place.DisplayMember = "diaChi";
            cbo_place.ValueMember = "diaChi";
            ChienDich chienDich = cbo_place.SelectedItem as ChienDich;

            // CHuyến Label Trạng thái đăng ký thành Chờ xác nhận
            lbl_phieudk.Text = "Chờ xác nhận";

            //Lưu dữ liệu phiếu vào phieuDK mới tạo
            phieuDK.ngayDKHienMau = dTP_Date.Value;
            phieuDK.ngayHienMauTruoc = dtp_Lastdate.Value;
            phieuDK.diaDiemDKHienMau = chienDich.diaChi.ToString();
            phieuDK.GioDkHienMau = cbo_time.SelectedItem.ToString();
            phieuDK.tiemVaccineCovid19 = cbo_covid.SelectedItem.ToString();
            phieuDK.loaiHienMau = cbo_type.SelectedItem.ToString();
            phieuDK.sdtNguoiThan = txt_phonenumber.Text;
            phieuDK.trangThaiDK = lbl_phieudk.Text;
            phieuDK.mshs = mshs_phieudk;
            phieuDK.mscd = chienDich.mscd;
            
            // Lưu database, reset form
            db.PhieuDKs.InsertOnSubmit(phieuDK);
            db.SubmitChanges();
            this.Refresh();
            MessageBox.Show("Cảm ơn bạn đã tham gia!");
            this.Close();
        }
    }
}
