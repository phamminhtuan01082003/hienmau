namespace Hiến_máu
{
    partial class frmListResult
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
            this.dGV_ListResult = new System.Windows.Forms.DataGridView();
            this.phieuKQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDKHienMauDataSet1 = new Hiến_máu.QLDKHienMauDataSet1();
            this.qLDKHienMauDataSet = new Hiến_máu.QLDKHienMauDataSet();
            this.qLDKHienMauDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuKQTableAdapter = new Hiến_máu.QLDKHienMauDataSet1TableAdapters.PhieuKQTableAdapter();
            this.btn_detail = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ListResult
            // 
            this.dGV_ListResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListResult.Location = new System.Drawing.Point(89, 101);
            this.dGV_ListResult.Name = "dGV_ListResult";
            this.dGV_ListResult.RowHeadersWidth = 82;
            this.dGV_ListResult.RowTemplate.Height = 33;
            this.dGV_ListResult.Size = new System.Drawing.Size(1011, 323);
            this.dGV_ListResult.TabIndex = 0;
            // 
            // phieuKQBindingSource
            // 
            this.phieuKQBindingSource.DataMember = "PhieuKQ";
            this.phieuKQBindingSource.DataSource = this.qLDKHienMauDataSet1;
            // 
            // qLDKHienMauDataSet1
            // 
            this.qLDKHienMauDataSet1.DataSetName = "QLDKHienMauDataSet1";
            this.qLDKHienMauDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // phieuKQTableAdapter
            // 
            this.phieuKQTableAdapter.ClearBeforeFill = true;
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(732, 497);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(151, 59);
            this.btn_detail.TabIndex = 1;
            this.btn_detail.Text = "Xem chi tiết";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(949, 497);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(151, 59);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frmListResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 605);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.dGV_ListResult);
            this.Name = "frmListResult";
            this.Text = "Lịch sử hiến máu";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDKHienMauDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_ListResult;
        private System.Windows.Forms.BindingSource qLDKHienMauDataSetBindingSource;
        private QLDKHienMauDataSet qLDKHienMauDataSet;
        private QLDKHienMauDataSet1 qLDKHienMauDataSet1;
        private System.Windows.Forms.BindingSource phieuKQBindingSource;
        private QLDKHienMauDataSet1TableAdapters.PhieuKQTableAdapter phieuKQTableAdapter;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_cancel;
    }
}