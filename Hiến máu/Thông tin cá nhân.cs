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
    public partial class frmInfo : Form
    {
        private int dta;
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        public frmInfo(int infodata)
        {
            InitializeComponent();
            dta = infodata;
        }
        
        private void frmInfo_Load(object sender, EventArgs e)
        {
            // Nếu hồ sơ đã có dữ liệu thì load dữ liệu từ database lên form
            HoSoDK info = db.HoSoDKs.SingleOrDefault(t => t.IDAccount == dta);
            if (info != null) 
            {
                txt_name.Text = info.hoTen;
                date.Value = info.ntns;
                string gt = "Nữ";
                if (info.gioitinh == gt) cbo_gioitinh.SelectedItem = 1;else
                    cbo_gioitinh.SelectedIndex = 0;
                txt_adress.Text = info.dclh;
                txt_phone.Text = info.sdtlh;
                txt_email.Text = info.DCemail;
                txt_bloodtype.Text = info.nhommau;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ấn nút Update - Cập nhật dữ liệu
        private void btn_update_Click(object sender, EventArgs e)
        {
            // Tạo mới một HoSoDK và lưu dữ liệu vừa nhập vào
            HoSoDK info = new HoSoDK();
            info.hoTen = txt_name.Text;
            info.ntns = date.Value;
            if (cbo_gioitinh.SelectedIndex == 1) info.gioitinh = "Nữ";
            else info.gioitinh = "Nam"; 
            info.dclh = txt_adress.Text;
            info.sdtlh = txt_phone.Text;
            info.DCemail = txt_email.Text;
            info.nhommau = txt_bloodtype.Text;
            info.IDAccount = dta;

            // Lưu database
            db.HoSoDKs.InsertOnSubmit(info);
            db.SubmitChanges();
            this.Close();
        }
    }
}
