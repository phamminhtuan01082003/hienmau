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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        // Ấn nút đăng xuất
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            Form f = new frmSignIn();
            f.Show();
        }

        // Ấn nút Ghi phiếu kết quả
        private void btn_Result_Click(object sender, EventArgs e)
        {
            // Mở form Danh sách phiếu kết quả với tham số -1
            Form f = new frmListResult(-1);
            f.Show();
        }

        // Ấn nút phiếu đăng ký
        private void btn_Accept_Click_1(object sender, EventArgs e)
        {
            // Mở form Danh sách phiếu đăng ký
            Form f = new frmListRegistor();
            f.Show();
        }

        // Ấn nút Thống kê nguồn cung cấp
        private void btn_Statis_Click(object sender, EventArgs e)
        {
            // Phần này tôi chưa làm ông nào rảnh thì làm thêm nhé!!!
        }
    }
}
