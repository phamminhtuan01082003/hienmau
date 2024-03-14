namespace Hiến_máu
{
    partial class frmListRegistor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dGV_listregistor = new System.Windows.Forms.DataGridView();
            this.mspDangKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDkHienMauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDKHienMauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHienMauTruocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemDKHienMauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHienMauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiemVaccineCovid19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNguoiThanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKHienMauDataSet2 = new Hiến_máu.QLDKHienMauDataSet2();
            this.qLDKHienMauDataSet = new Hiến_máu.QLDKHienMauDataSet();
            this.qLDKHienMauDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuDKTableAdapter = new Hiến_máu.QLDKHienMauDataSet2TableAdapters.PhieuDKTableAdapter();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_deny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_listregistor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_listregistor
            // 
            this.dGV_listregistor.AutoGenerateColumns = false;
            this.dGV_listregistor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_listregistor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mspDangKyDataGridViewTextBoxColumn,
            this.trangThaiDKDataGridViewTextBoxColumn,
            this.gioDkHienMauDataGridViewTextBoxColumn,
            this.ngayDKHienMauDataGridViewTextBoxColumn,
            this.ngayHienMauTruocDataGridViewTextBoxColumn,
            this.diaDiemDKHienMauDataGridViewTextBoxColumn,
            this.loaiHienMauDataGridViewTextBoxColumn,
            this.tiemVaccineCovid19DataGridViewTextBoxColumn,
            this.sdtNguoiThanDataGridViewTextBoxColumn});
            this.dGV_listregistor.DataSource = this.phieuDKBindingSource;
            this.dGV_listregistor.Location = new System.Drawing.Point(140, 181);
            this.dGV_listregistor.Name = "dGV_listregistor";
            this.dGV_listregistor.RowHeadersWidth = 82;
            this.dGV_listregistor.RowTemplate.Height = 33;
            this.dGV_listregistor.Size = new System.Drawing.Size(1999, 510);
            this.dGV_listregistor.TabIndex = 0;
            // 
            // mspDangKyDataGridViewTextBoxColumn
            // 
            this.mspDangKyDataGridViewTextBoxColumn.DataPropertyName = "mspDangKy";
            this.mspDangKyDataGridViewTextBoxColumn.Frozen = true;
            this.mspDangKyDataGridViewTextBoxColumn.HeaderText = "Mã số";
            this.mspDangKyDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.mspDangKyDataGridViewTextBoxColumn.Name = "mspDangKyDataGridViewTextBoxColumn";
            this.mspDangKyDataGridViewTextBoxColumn.ReadOnly = true;
            this.mspDangKyDataGridViewTextBoxColumn.Width = 30;
            // 
            // trangThaiDKDataGridViewTextBoxColumn
            // 
            this.trangThaiDKDataGridViewTextBoxColumn.DataPropertyName = "trangThaiDK";
            this.trangThaiDKDataGridViewTextBoxColumn.HeaderText = "Trạng thái đăng ký";
            this.trangThaiDKDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.trangThaiDKDataGridViewTextBoxColumn.Name = "trangThaiDKDataGridViewTextBoxColumn";
            this.trangThaiDKDataGridViewTextBoxColumn.Width = 110;
            // 
            // gioDkHienMauDataGridViewTextBoxColumn
            // 
            this.gioDkHienMauDataGridViewTextBoxColumn.DataPropertyName = "GioDkHienMau";
            this.gioDkHienMauDataGridViewTextBoxColumn.HeaderText = "Giờ";
            this.gioDkHienMauDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gioDkHienMauDataGridViewTextBoxColumn.Name = "gioDkHienMauDataGridViewTextBoxColumn";
            this.gioDkHienMauDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioDkHienMauDataGridViewTextBoxColumn.Width = 60;
            // 
            // ngayDKHienMauDataGridViewTextBoxColumn
            // 
            this.ngayDKHienMauDataGridViewTextBoxColumn.DataPropertyName = "ngayDKHienMau";
            this.ngayDKHienMauDataGridViewTextBoxColumn.HeaderText = "Ngày đăng ký";
            this.ngayDKHienMauDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ngayDKHienMauDataGridViewTextBoxColumn.Name = "ngayDKHienMauDataGridViewTextBoxColumn";
            this.ngayDKHienMauDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayDKHienMauDataGridViewTextBoxColumn.Width = 60;
            // 
            // ngayHienMauTruocDataGridViewTextBoxColumn
            // 
            this.ngayHienMauTruocDataGridViewTextBoxColumn.DataPropertyName = "ngayHienMauTruoc";
            this.ngayHienMauTruocDataGridViewTextBoxColumn.HeaderText = "Ngày hiến máu gần nhất";
            this.ngayHienMauTruocDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ngayHienMauTruocDataGridViewTextBoxColumn.Name = "ngayHienMauTruocDataGridViewTextBoxColumn";
            this.ngayHienMauTruocDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayHienMauTruocDataGridViewTextBoxColumn.Width = 80;
            // 
            // diaDiemDKHienMauDataGridViewTextBoxColumn
            // 
            this.diaDiemDKHienMauDataGridViewTextBoxColumn.DataPropertyName = "diaDiemDKHienMau";
            this.diaDiemDKHienMauDataGridViewTextBoxColumn.HeaderText = "Địa điểm đăng ký";
            this.diaDiemDKHienMauDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.diaDiemDKHienMauDataGridViewTextBoxColumn.Name = "diaDiemDKHienMauDataGridViewTextBoxColumn";
            this.diaDiemDKHienMauDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaDiemDKHienMauDataGridViewTextBoxColumn.Width = 250;
            // 
            // loaiHienMauDataGridViewTextBoxColumn
            // 
            this.loaiHienMauDataGridViewTextBoxColumn.DataPropertyName = "loaiHienMau";
            this.loaiHienMauDataGridViewTextBoxColumn.HeaderText = "Loại hiến máu";
            this.loaiHienMauDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.loaiHienMauDataGridViewTextBoxColumn.Name = "loaiHienMauDataGridViewTextBoxColumn";
            this.loaiHienMauDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiHienMauDataGridViewTextBoxColumn.Width = 105;
            // 
            // tiemVaccineCovid19DataGridViewTextBoxColumn
            // 
            this.tiemVaccineCovid19DataGridViewTextBoxColumn.DataPropertyName = "tiemVaccineCovid19";
            this.tiemVaccineCovid19DataGridViewTextBoxColumn.HeaderText = "Tiêm Vaccine Covid-19";
            this.tiemVaccineCovid19DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tiemVaccineCovid19DataGridViewTextBoxColumn.Name = "tiemVaccineCovid19DataGridViewTextBoxColumn";
            this.tiemVaccineCovid19DataGridViewTextBoxColumn.ReadOnly = true;
            this.tiemVaccineCovid19DataGridViewTextBoxColumn.Width = 80;
            // 
            // sdtNguoiThanDataGridViewTextBoxColumn
            // 
            this.sdtNguoiThanDataGridViewTextBoxColumn.DataPropertyName = "sdtNguoiThan";
            this.sdtNguoiThanDataGridViewTextBoxColumn.HeaderText = "Số điện thoại người thân";
            this.sdtNguoiThanDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sdtNguoiThanDataGridViewTextBoxColumn.Name = "sdtNguoiThanDataGridViewTextBoxColumn";
            this.sdtNguoiThanDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdtNguoiThanDataGridViewTextBoxColumn.Width = 150;
            // 
            // phieuDKBindingSource
            // 
            this.phieuDKBindingSource.DataMember = "PhieuDK";
            this.phieuDKBindingSource.DataSource = this.qLDKHienMauDataSet2;
            // 
            // qLDKHienMauDataSet2
            // 
            this.qLDKHienMauDataSet2.DataSetName = "QLDKHienMauDataSet2";
            this.qLDKHienMauDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDKHienMauDataSet
            // 
            this.qLDKHienMauDataSet.DataSetName = "QLDKHienMauDataSet";
            this.qLDKHienMauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDKHienMauDataSetBindingSource
            // 
            this.qLDKHienMauDataSetBindingSource.DataSource = this.qLDKHienMauDataSet;
            this.qLDKHienMauDataSetBindingSource.Position = 0;
            // 
            // phieuDKTableAdapter
            // 
            this.phieuDKTableAdapter.ClearBeforeFill = true;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(1605, 808);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(138, 62);
            this.btn_accept.TabIndex = 1;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(2001, 808);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(138, 62);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_deny
            // 
            this.btn_deny.Location = new System.Drawing.Point(1803, 808);
            this.btn_deny.Name = "btn_deny";
            this.btn_deny.Size = new System.Drawing.Size(138, 62);
            this.btn_deny.TabIndex = 3;
            this.btn_deny.Text = "Deny";
            this.btn_deny.UseVisualStyleBackColor = true;
            this.btn_deny.Click += new System.EventHandler(this.btn_deny_Click);
            // 
            // frmListRegistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2272, 992);
            this.Controls.Add(this.btn_deny);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.dGV_listregistor);
            this.Name = "frmListRegistor";
            this.Text = "Danh sách phiếu đăng ký";
            this.Load += new System.EventHandler(this.frmListRegistor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_listregistor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_listregistor;
        private QLDKHienMauDataSet qLDKHienMauDataSet;
        private System.Windows.Forms.BindingSource qLDKHienMauDataSetBindingSource;
        private QLDKHienMauDataSet2 qLDKHienMauDataSet2;
        private System.Windows.Forms.BindingSource phieuDKBindingSource;
        private QLDKHienMauDataSet2TableAdapters.PhieuDKTableAdapter phieuDKTableAdapter;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_deny;
        private System.Windows.Forms.DataGridViewTextBoxColumn mspDangKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDkHienMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDKHienMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHienMauTruocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemDKHienMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHienMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiemVaccineCovid19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNguoiThanDataGridViewTextBoxColumn;
    }
}