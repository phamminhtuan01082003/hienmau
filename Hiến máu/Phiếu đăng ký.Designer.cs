namespace Hiến_máu
{
    partial class frmRegister
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_time = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_place = new System.Windows.Forms.ComboBox();
            this.chienDichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKHienMauDataSet = new Hiến_máu.QLDKHienMauDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_covid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.lbl_phieudk = new System.Windows.Forms.Label();
            this.chienDichTableAdapter = new Hiến_máu.QLDKHienMauDataSetTableAdapters.ChienDichTableAdapter();
            this.qLDKHienMauDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chienDichBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtaGV_campaign = new System.Windows.Forms.DataGridView();
            this.tenChienDichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sloganLogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chienDichBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.chienDichBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_finish = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Lastdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.chienDichBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_campaign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1196, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(136, 44);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(578, 65);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(571, 31);
            this.txt_search.TabIndex = 5;
            // 
            // dTP_Date
            // 
            this.dTP_Date.Location = new System.Drawing.Point(91, 113);
            this.dTP_Date.Name = "dTP_Date";
            this.dTP_Date.Size = new System.Drawing.Size(401, 31);
            this.dTP_Date.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày đăng ký";
            // 
            // cbo_time
            // 
            this.cbo_time.FormattingEnabled = true;
            this.cbo_time.Items.AddRange(new object[] {
            "06H-08H",
            "08H-10H",
            "10H-12H",
            "12H-14H",
            "14H-16H",
            "16H-18H"});
            this.cbo_time.Location = new System.Drawing.Point(91, 309);
            this.cbo_time.Name = "cbo_time";
            this.cbo_time.Size = new System.Drawing.Size(401, 33);
            this.cbo_time.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thời gian dự kiến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa điểm đăng ký";
            // 
            // cbo_place
            // 
            this.cbo_place.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chienDichBindingSource, "diaChi", true));
            this.cbo_place.FormattingEnabled = true;
            this.cbo_place.Location = new System.Drawing.Point(91, 409);
            this.cbo_place.Name = "cbo_place";
            this.cbo_place.Size = new System.Drawing.Size(401, 33);
            this.cbo_place.TabIndex = 11;
            // 
            // chienDichBindingSource
            // 
            this.chienDichBindingSource.DataMember = "ChienDich";
            this.chienDichBindingSource.DataSource = this.qLDKHienMauDataSet;
            // 
            // qLDKHienMauDataSet
            // 
            this.qLDKHienMauDataSet.DataSetName = "QLDKHienMauDataSet";
            this.qLDKHienMauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tiêm vaccine Covid-19";
            // 
            // cbo_covid
            // 
            this.cbo_covid.FormattingEnabled = true;
            this.cbo_covid.Items.AddRange(new object[] {
            "Đã tiêm",
            "Chưa tiêm"});
            this.cbo_covid.Location = new System.Drawing.Point(91, 609);
            this.cbo_covid.Name = "cbo_covid";
            this.cbo_covid.Size = new System.Drawing.Size(401, 33);
            this.cbo_covid.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số điện thoại người thân";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(91, 709);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(401, 31);
            this.txt_phonenumber.TabIndex = 16;
            // 
            // lbl_phieudk
            // 
            this.lbl_phieudk.AutoSize = true;
            this.lbl_phieudk.BackColor = System.Drawing.Color.Silver;
            this.lbl_phieudk.Location = new System.Drawing.Point(827, 658);
            this.lbl_phieudk.Name = "lbl_phieudk";
            this.lbl_phieudk.Size = new System.Drawing.Size(0, 25);
            this.lbl_phieudk.TabIndex = 17;
            // 
            // chienDichTableAdapter
            // 
            this.chienDichTableAdapter.ClearBeforeFill = true;
            // 
            // qLDKHienMauDataSetBindingSource
            // 
            this.qLDKHienMauDataSetBindingSource.DataSource = this.qLDKHienMauDataSet;
            this.qLDKHienMauDataSetBindingSource.Position = 0;
            // 
            // chienDichBindingSource1
            // 
            this.chienDichBindingSource1.DataMember = "ChienDich";
            this.chienDichBindingSource1.DataSource = this.qLDKHienMauDataSetBindingSource;
            // 
            // dtaGV_campaign
            // 
            this.dtaGV_campaign.AutoGenerateColumns = false;
            this.dtaGV_campaign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGV_campaign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenChienDichDataGridViewTextBoxColumn,
            this.sloganLogoDataGridViewTextBoxColumn,
            this.ngayThangDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.diaChiEmailDataGridViewTextBoxColumn,
            this.webDataGridViewTextBoxColumn});
            this.dtaGV_campaign.DataSource = this.chienDichBindingSource3;
            this.dtaGV_campaign.Location = new System.Drawing.Point(578, 151);
            this.dtaGV_campaign.Name = "dtaGV_campaign";
            this.dtaGV_campaign.RowHeadersWidth = 82;
            this.dtaGV_campaign.RowTemplate.Height = 33;
            this.dtaGV_campaign.Size = new System.Drawing.Size(754, 466);
            this.dtaGV_campaign.TabIndex = 1;
            // 
            // tenChienDichDataGridViewTextBoxColumn
            // 
            this.tenChienDichDataGridViewTextBoxColumn.DataPropertyName = "tenChienDich";
            this.tenChienDichDataGridViewTextBoxColumn.HeaderText = "Tên chiến dịch";
            this.tenChienDichDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tenChienDichDataGridViewTextBoxColumn.Name = "tenChienDichDataGridViewTextBoxColumn";
            this.tenChienDichDataGridViewTextBoxColumn.Width = 150;
            // 
            // sloganLogoDataGridViewTextBoxColumn
            // 
            this.sloganLogoDataGridViewTextBoxColumn.DataPropertyName = "slogan, logo";
            this.sloganLogoDataGridViewTextBoxColumn.HeaderText = "Slogan";
            this.sloganLogoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sloganLogoDataGridViewTextBoxColumn.Name = "sloganLogoDataGridViewTextBoxColumn";
            this.sloganLogoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayThangDataGridViewTextBoxColumn
            // 
            this.ngayThangDataGridViewTextBoxColumn.DataPropertyName = "ngayThang";
            this.ngayThangDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.ngayThangDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ngayThangDataGridViewTextBoxColumn.Name = "ngayThangDataGridViewTextBoxColumn";
            this.ngayThangDataGridViewTextBoxColumn.Width = 80;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "thoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "Giờ";
            this.thoiGianDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.Width = 70;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 250;
            // 
            // diaChiEmailDataGridViewTextBoxColumn
            // 
            this.diaChiEmailDataGridViewTextBoxColumn.DataPropertyName = "diaChiEmail";
            this.diaChiEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.diaChiEmailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.diaChiEmailDataGridViewTextBoxColumn.Name = "diaChiEmailDataGridViewTextBoxColumn";
            this.diaChiEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // webDataGridViewTextBoxColumn
            // 
            this.webDataGridViewTextBoxColumn.DataPropertyName = "web";
            this.webDataGridViewTextBoxColumn.HeaderText = "Website";
            this.webDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.webDataGridViewTextBoxColumn.Name = "webDataGridViewTextBoxColumn";
            this.webDataGridViewTextBoxColumn.Width = 150;
            // 
            // chienDichBindingSource3
            // 
            this.chienDichBindingSource3.DataMember = "ChienDich";
            this.chienDichBindingSource3.DataSource = this.qLDKHienMauDataSetBindingSource;
            // 
            // chienDichBindingSource2
            // 
            this.chienDichBindingSource2.DataMember = "ChienDich";
            this.chienDichBindingSource2.DataSource = this.qLDKHienMauDataSetBindingSource;
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(1061, 716);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(271, 56);
            this.btn_finish.TabIndex = 18;
            this.btn_finish.Text = "Hoàn tất đăng ký";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày đăng ký trước đó";
            // 
            // dtp_Lastdate
            // 
            this.dtp_Lastdate.Location = new System.Drawing.Point(91, 211);
            this.dtp_Lastdate.Name = "dtp_Lastdate";
            this.dtp_Lastdate.Size = new System.Drawing.Size(401, 31);
            this.dtp_Lastdate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(573, 658);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Trạng thái đăng ký:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Loại đăng ký";
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Hiến máu toàn phần",
            "Hiến máu tiểu cầu"});
            this.cbo_type.Location = new System.Drawing.Point(91, 509);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(401, 33);
            this.cbo_type.TabIndex = 22;
            // 
            // chienDichBindingSource4
            // 
            this.chienDichBindingSource4.DataMember = "ChienDich";
            this.chienDichBindingSource4.DataSource = this.qLDKHienMauDataSetBindingSource;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 811);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_Lastdate);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.lbl_phieudk);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_covid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_place);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTP_Date);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtaGV_campaign);
            this.Name = "frmRegister";
            this.Text = "Phiếu đăng ký hiến máu";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_campaign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chienDichBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DateTimePicker dTP_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_place;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_covid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.Label lbl_phieudk;
        private System.Windows.Forms.BindingSource chienDichBindingSource;
        private QLDKHienMauDataSetTableAdapters.ChienDichTableAdapter chienDichTableAdapter;
        private QLDKHienMauDataSet qLDKHienMauDataSet;
        private System.Windows.Forms.BindingSource chienDichBindingSource1;
        private System.Windows.Forms.BindingSource qLDKHienMauDataSetBindingSource;
        private System.Windows.Forms.DataGridView dtaGV_campaign;
        private System.Windows.Forms.BindingSource chienDichBindingSource2;
        private System.Windows.Forms.BindingSource chienDichBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChienDichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sloganLogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Lastdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.BindingSource chienDichBindingSource4;
    }
}