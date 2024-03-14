using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hiến_máu
{
    public partial class frmUser : Form
    {
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        private int id_acc;
        public frmUser(int data)
        {
            InitializeComponent();
            id_acc = data;
            
        }
        //Ấn nút Phiếu đăng ký
        private void btn_registor_Click(object sender, EventArgs e)
        {
            // Tìm hồ sơ người dùng có IDAccount đăng nhập
            HoSoDK hoSoDK = db.HoSoDKs.FirstOrDefault(d => d.IDAccount == id_acc);


            // Tìm phiếu đăng ký có mã số hồ sơ của người tìm được
            int mshs_phieu = hoSoDK.mshs;
            PhieuDK phieuDK = db.PhieuDKs.OrderByDescending(t => t.mspDangKy).FirstOrDefault(d => d.mshs == mshs_phieu);
            
            // Nếu đã hiến máu thành công thì check_null = 0
            int check_null = -1;
            if (phieuDK != null)
            if (phieuDK.trangThaiDK != "Hiến máu thành công") check_null = 0;
            
            // Mở form PHiếu đăng ký có trạng thái check_null và mã số phiếu đăng ký 
            Form f = new frmRegister(check_null, mshs_phieu);
                f.Show();

        }
        // Ấn nút Thông tin cá nhân, lấy dữ liệu IDAccount người dùng
        private void btn_info_Click(object sender, EventArgs e)
        {
            Form f = new frmInfo(id_acc);
            f.Show();
        }

        // Ấn nút Đăng xuất
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new frmSignIn();
            f.Show();  
        }

        // Ấn nút phiếu kết quả, lấy dữ liệu IDAccount người dùng
        private void btn_result_Click(object sender, EventArgs e)
        {
            Form f = new frmListResult(id_acc);
            f.Show();
        }
    }
}
