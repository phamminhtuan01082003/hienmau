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
    public partial class frmListRegistor : Form
    {
        QLDKHienMauDataContext db = new QLDKHienMauDataContext();
        public frmListRegistor()
        {
            InitializeComponent();
        }

        private void frmListRegistor_Load(object sender, EventArgs e)
        {
            // Load table PhieuDK trong database lên DataGridView trong form Danh sách phiếu đăng ký
            this.phieuDKTableAdapter.Fill(this.qLDKHienMauDataSet2.PhieuDK);
        }

        // Ấn phím Accept - Chấp nhận
        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (dGV_listregistor.SelectedRows.Count > 0)
            {
                // Tìm hàng được chọn trong DataGridView
                DataGridViewRow selectedRow = dGV_listregistor.SelectedRows[0];

                // Lấy giá trị cột 0 của hàng được chọn - Mã số đăng ký
                object cellValue = selectedRow.Cells[0].Value;
                int msdk = Convert.ToInt32(cellValue);

                // Chuyển trạng thái đăng ký của phiếu đăng ký có mã số trên thành "Đăng ký thành công"
                PhieuDK phieuDK = db.PhieuDKs.FirstOrDefault(t => t.mspDangKy == msdk);
                        phieuDK.trangThaiDK = "Đăng ký thành công";
                
                // Lưu database
                db.SubmitChanges();   
                this.phieuDKTableAdapter.Fill(this.qLDKHienMauDataSet2.PhieuDK);
            }
        }

        // Ấn phím Deny - không chấp nhận -> như trên và chuyển trạng thái thành "Đăng ký thất bại"
        private void btn_deny_Click(object sender, EventArgs e)
        {
            if (dGV_listregistor.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dGV_listregistor.SelectedRows[0];

                object cellValue = selectedRow.Cells[0].Value;

                int msdk = Convert.ToInt32(cellValue);

                PhieuDK phieuDK = db.PhieuDKs.FirstOrDefault(t => t.mspDangKy == msdk);
                        phieuDK.trangThaiDK = "Đăng ký thất bại";
                
                db.SubmitChanges();
                this.phieuDKTableAdapter.Fill(this.qLDKHienMauDataSet2.PhieuDK);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
