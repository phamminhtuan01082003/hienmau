namespace Hiến_máu
{
    partial class frmUser
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
            this.btn_registor = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registor
            // 
            this.btn_registor.Location = new System.Drawing.Point(104, 124);
            this.btn_registor.Name = "btn_registor";
            this.btn_registor.Size = new System.Drawing.Size(214, 72);
            this.btn_registor.TabIndex = 0;
            this.btn_registor.Text = "Phiếu đăng ký";
            this.btn_registor.UseVisualStyleBackColor = true;
            this.btn_registor.Click += new System.EventHandler(this.btn_registor_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(694, 124);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(214, 72);
            this.btn_info.TabIndex = 1;
            this.btn_info.Text = "Thông tin cá nhân";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(397, 124);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(214, 72);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "Phiếu kết quả";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Location = new System.Drawing.Point(785, 30);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(123, 41);
            this.btn_SignOut.TabIndex = 3;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 614);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_registor);
            this.Name = "frmUser";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registor;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_SignOut;
    }
}