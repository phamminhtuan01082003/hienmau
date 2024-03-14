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
    public partial class frmSignUp : Form
    {
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        public frmSignUp()
        {
            InitializeComponent();
        }
        // Ấn Đăng ký trong form ĐĂng ký tài khoản
        private void btn_Sign_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ textbox
                tblLogin acc  = new tblLogin();
                acc.Username = txt_username.Text;
                acc.Password = txt_password.Text;
            
            //Nhập dữ liệu vào sql
            if (cbo_role.SelectedItem.ToString() == "Nhân viên") acc.IDRole = 1;else acc.IDRole = 0;
            db.tblLogins.InsertOnSubmit(acc);
            db.SubmitChanges();
            int dta = acc.IDAccount;
            MessageBox.Show("Đăng ký thành công");
            this.Close();

            //Nếu là người đăng ký hiến máu thì mở form Thông tin cá nhân
            if (acc.IDRole == 0)
            {
                Form f = new frmInfo(dta);
                f.Show();
            }   
        }
    }
}
