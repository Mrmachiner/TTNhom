namespace TTCSDL.View
{
    partial class FormDSDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGridNhapDiem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKTp = new System.Windows.Forms.TextBox();
            this.txtKTe = new System.Windows.Forms.TextBox();
            this.txtKTw = new System.Windows.Forms.TextBox();
            this.txtDiemTN = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SBD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDot = new System.Windows.Forms.ComboBox();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.danhSachThuBaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNhapDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuBaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGridNhapDiem);
            this.groupBox1.Location = new System.Drawing.Point(7, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu";
            // 
            // dtGridNhapDiem
            // 
            this.dtGridNhapDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridNhapDiem.Location = new System.Drawing.Point(6, 26);
            this.dtGridNhapDiem.Name = "dtGridNhapDiem";
            this.dtGridNhapDiem.RowTemplate.Height = 24;
            this.dtGridNhapDiem.Size = new System.Drawing.Size(1272, 265);
            this.dtGridNhapDiem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Điểm Của Thí Sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtKTp);
            this.groupBox2.Controls.Add(this.txtKTe);
            this.groupBox2.Controls.Add(this.txtKTw);
            this.groupBox2.Controls.Add(this.txtDiemTN);
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.txtSBD);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SBD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxDot);
            this.groupBox2.Controls.Add(this.btnNhapDiem);
            this.groupBox2.Location = new System.Drawing.Point(7, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1219, 369);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(616, 276);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 32);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "KT File Word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "KT File Excel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "KT File PPT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Điểm Trắc Nghiệm";
            // 
            // txtKTp
            // 
            this.txtKTp.Location = new System.Drawing.Point(603, 206);
            this.txtKTp.Name = "txtKTp";
            this.txtKTp.Size = new System.Drawing.Size(100, 22);
            this.txtKTp.TabIndex = 7;
            // 
            // txtKTe
            // 
            this.txtKTe.Location = new System.Drawing.Point(603, 157);
            this.txtKTe.Name = "txtKTe";
            this.txtKTe.Size = new System.Drawing.Size(100, 22);
            this.txtKTe.TabIndex = 8;
            // 
            // txtKTw
            // 
            this.txtKTw.Location = new System.Drawing.Point(603, 106);
            this.txtKTw.Name = "txtKTw";
            this.txtKTw.Size = new System.Drawing.Size(100, 22);
            this.txtKTw.TabIndex = 9;
            // 
            // txtDiemTN
            // 
            this.txtDiemTN.Location = new System.Drawing.Point(603, 49);
            this.txtDiemTN.Name = "txtDiemTN";
            this.txtDiemTN.Size = new System.Drawing.Size(100, 22);
            this.txtDiemTN.TabIndex = 10;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Enabled = false;
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(5, 150);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaySinh.TabIndex = 6;
            // 
            // txtSBD
            // 
            this.txtSBD.Location = new System.Drawing.Point(5, 105);
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.ReadOnly = true;
            this.txtSBD.Size = new System.Drawing.Size(167, 22);
            this.txtSBD.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(6, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(167, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Sinh";
            // 
            // SBD
            // 
            this.SBD.AutoSize = true;
            this.SBD.Location = new System.Drawing.Point(5, 85);
            this.SBD.Name = "SBD";
            this.SBD.Size = new System.Drawing.Size(36, 17);
            this.SBD.TabIndex = 4;
            this.SBD.Text = "SBD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đợt";
            // 
            // cbxDot
            // 
            this.cbxDot.FormattingEnabled = true;
            this.cbxDot.Location = new System.Drawing.Point(9, 209);
            this.cbxDot.Name = "cbxDot";
            this.cbxDot.Size = new System.Drawing.Size(102, 24);
            this.cbxDot.TabIndex = 2;
            this.cbxDot.SelectedIndexChanged += new System.EventHandler(this.cbxDot_SelectedIndexChanged);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(1093, 330);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(120, 33);
            this.btnNhapDiem.TabIndex = 1;
            this.btnNhapDiem.Text = "Nhập Điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // danhSachThuBaiBindingSource
            // 
            this.danhSachThuBaiBindingSource.DataSource = typeof(TTCSDL.DanhSachThuBai);
            // 
            // FormDSDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDSDiem";
            this.Text = "Danh Sách";
            this.Load += new System.EventHandler(this.FormNhapDiem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNhapDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuBaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGridNhapDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDot;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKTp;
        private System.Windows.Forms.TextBox txtKTe;
        private System.Windows.Forms.TextBox txtKTw;
        private System.Windows.Forms.TextBox txtDiemTN;
        private System.Windows.Forms.BindingSource danhSachThuBaiBindingSource;
    }
}