namespace Hiến_máu
{
    partial class frmResult
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dTP_HienMau = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_health = new System.Windows.Forms.TextBox();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(595, 507);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 35);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày thực sự hiến máu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lượng máu đã hiến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tình trạng hiến máu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tình trạng sức khỏe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nơi hiến máu";
            // 
            // dTP_HienMau
            // 
            this.dTP_HienMau.Location = new System.Drawing.Point(335, 92);
            this.dTP_HienMau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_HienMau.Name = "dTP_HienMau";
            this.dTP_HienMau.Size = new System.Drawing.Size(365, 22);
            this.dTP_HienMau.TabIndex = 7;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(335, 142);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(365, 22);
            this.txt_amount.TabIndex = 8;
            // 
            // cbo_status
            // 
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Thành công",
            "Thất bại"});
            this.cbo_status.Location = new System.Drawing.Point(335, 243);
            this.cbo_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(365, 24);
            this.cbo_status.TabIndex = 9;
            // 
            // txt_place
            // 
            this.txt_place.Location = new System.Drawing.Point(335, 294);
            this.txt_place.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(365, 22);
            this.txt_place.TabIndex = 10;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(335, 394);
            this.txt_note.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(365, 79);
            this.txt_note.TabIndex = 12;
            // 
            // txt_health
            // 
            this.txt_health.Location = new System.Drawing.Point(335, 344);
            this.txt_health.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_health.Name = "txt_health";
            this.txt_health.Size = new System.Drawing.Size(365, 22);
            this.txt_health.TabIndex = 13;
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Hiến máu toàn phần",
            "Hiến máu tiểu cầu"});
            this.cbo_type.Location = new System.Drawing.Point(335, 192);
            this.cbo_type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(365, 24);
            this.cbo_type.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loại hiến máu thực sự";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(453, 507);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(105, 35);
            this.btn_confirm.TabIndex = 16;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 612);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_health);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_place);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.dTP_HienMau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmResult";
            this.Text = "Phiếu kết quả";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTP_HienMau;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cbo_status;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox txt_health;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_confirm;
    }
}