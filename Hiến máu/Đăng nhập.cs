using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hiến_máu
{
    public partial class frmSignIn : Form
    {
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        public frmSignIn()
        {
            InitializeComponent();
        }
            //Ấn Đăng nhập trong form Đăng nhập
        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ textbox
            string un = txt_username.Text;
            string pw = txt_password.Text;

            // So sánh tài khoản trong sql
            tblLogin account = db.tblLogins.SingleOrDefault(t => t.Username == un && t.Password == pw);
            if (account != null)
            {
                Form f;
                int id_acc = account.IDAccount;

            // Kiểm tra ID nếu bằng 0 thì mở form Người đăng ký hiến máu ngược lại thì mở form Nhân viên
                if (account.IDRole == 0) { f = new frmUser(id_acc);}
                else f = new frmAdmin();

                f.Show();
                this.Hide();
            }
            // Nếu tài khoản sai thì gửi thông báo
            else
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }
            // Ấn Tạo tài khoản mới -> Mở form Đăng ký tài khoản
        private void btn_signup_Click(object sender, EventArgs e)
        {
            Form f_Sign = new frmSignUp();
            f_Sign.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
