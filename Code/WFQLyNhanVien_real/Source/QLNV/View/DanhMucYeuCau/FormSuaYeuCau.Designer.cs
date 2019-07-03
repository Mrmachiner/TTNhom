namespace QLNV.View
{
    partial class FormSuaYeuCau
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoNguoiLam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxChonCa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QLNV.Properties.Resources.them_small;
            this.btnLuu.Location = new System.Drawing.Point(222, 86);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 31);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng Người:";
            // 
            // txtSoNguoiLam
            // 
            this.txtSoNguoiLam.Location = new System.Drawing.Point(121, 63);
            this.txtSoNguoiLam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoNguoiLam.Name = "txtSoNguoiLam";
            this.txtSoNguoiLam.Size = new System.Drawing.Size(157, 20);
            this.txtSoNguoiLam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Yêu Cầu:";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(119, 12);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(157, 20);
            this.dtNgayNhap.TabIndex = 9;
            this.dtNgayNhap.ValueChanged += new System.EventHandler(this.dtNgayNhap_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ca Trực";
            // 
            // cbxChonCa
            // 
            this.cbxChonCa.FormattingEnabled = true;
            this.cbxChonCa.Location = new System.Drawing.Point(119, 37);
            this.cbxChonCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxChonCa.Name = "cbxChonCa";
            this.cbxChonCa.Size = new System.Drawing.Size(157, 21);
            this.cbxChonCa.TabIndex = 10;
            // 
            // FormSuaYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 125);
            this.Controls.Add(this.cbxChonCa);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoNguoiLam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSuaYeuCau";
            this.Text = "Thêm/Sửa Yêu Cầu";
            this.Load += new System.EventHandler(this.FormSuaYeuCau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoNguoiLam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxChonCa;
    }
}