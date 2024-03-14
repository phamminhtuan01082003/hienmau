namespace Hiến_máu
{
    partial class frmAdmin
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
            this.btn_Statis = new System.Windows.Forms.Button();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Statis
            // 
            this.btn_Statis.Location = new System.Drawing.Point(160, 147);
            this.btn_Statis.Name = "btn_Statis";
            this.btn_Statis.Size = new System.Drawing.Size(294, 68);
            this.btn_Statis.TabIndex = 1;
            this.btn_Statis.Text = "Thống kê nguồn cung cấp";
            this.btn_Statis.UseVisualStyleBackColor = true;
            this.btn_Statis.Click += new System.EventHandler(this.btn_Statis_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Location = new System.Drawing.Point(1062, 66);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(181, 61);
            this.btn_SignOut.TabIndex = 4;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(160, 294);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(294, 68);
            this.btn_Accept.TabIndex = 6;
            this.btn_Accept.Text = "Xác nhận phiếu đăng ký";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click_1);
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(160, 455);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(294, 68);
            this.btn_Result.TabIndex = 7;
            this.btn_Result.Text = "Ghi phiếu kết quả";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 746);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.btn_Statis);
            this.Name = "frmAdmin";
            this.Text = "Quản lý người dùng";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Statis;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Result;
    }
}