namespace QLNV.View
{
    partial class FormTKCanBo
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
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCanBo = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaCanBo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGridThongKe = new System.Windows.Forms.DataGridView();
            this.NgayTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTrucBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTrucKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // tuNgay
            // 
            this.tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tuNgay.Location = new System.Drawing.Point(14, 44);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(175, 22);
            this.tuNgay.TabIndex = 1;
            this.tuNgay.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // denNgay
            // 
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denNgay.Location = new System.Drawing.Point(207, 44);
            this.denNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(172, 22);
            this.denNgay.TabIndex = 1;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(10, 26);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(29, 17);
            this.lable.TabIndex = 2;
            this.lable.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxCanBo);
            this.groupBox1.Controls.Add(this.tuNgay);
            this.groupBox1.Controls.Add(this.lable);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.denNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(736, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn cán bộ";
            // 
            // cbxCanBo
            // 
            this.cbxCanBo.FormattingEnabled = true;
            this.cbxCanBo.Location = new System.Drawing.Point(386, 43);
            this.cbxCanBo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCanBo.Name = "cbxCanBo";
            this.cbxCanBo.Size = new System.Drawing.Size(233, 24);
            this.cbxCanBo.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::QLNV.Properties.Resources.capnhat;
            this.btnThongKe.Location = new System.Drawing.Point(624, 37);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(105, 40);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.txtMaCanBo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtChucVu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtGridThongKe);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(736, 430);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thống Kê";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(469, 50);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(249, 22);
            this.dtNgaySinh.TabIndex = 15;
            this.dtNgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtMaCanBo
            // 
            this.txtMaCanBo.Enabled = false;
            this.txtMaCanBo.Location = new System.Drawing.Point(316, 50);
            this.txtMaCanBo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCanBo.Name = "txtMaCanBo";
            this.txtMaCanBo.ReadOnly = true;
            this.txtMaCanBo.Size = new System.Drawing.Size(132, 22);
            this.txtMaCanBo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Cán Bộ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Location = new System.Drawing.Point(161, 50);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(132, 22);
            this.txtChucVu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chức Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = " Ngày Sinh:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtGridThongKe
            // 
            this.dtGridThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayTruc,
            this.GioTrucBatDau,
            this.GioTrucKetThuc});
            this.dtGridThongKe.Location = new System.Drawing.Point(4, 82);
            this.dtGridThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridThongKe.Name = "dtGridThongKe";
            this.dtGridThongKe.Size = new System.Drawing.Size(724, 338);
            this.dtGridThongKe.TabIndex = 8;
            // 
            // NgayTruc
            // 
            this.NgayTruc.DataPropertyName = "NgayTruc";
            this.NgayTruc.HeaderText = "Ngày Trực";
            this.NgayTruc.Name = "NgayTruc";
            // 
            // GioTrucBatDau
            // 
            this.GioTrucBatDau.DataPropertyName = "GioTrucBatDau";
            this.GioTrucBatDau.HeaderText = "Giờ Bắt Đầu";
            this.GioTrucBatDau.Name = "GioTrucBatDau";
            // 
            // GioTrucKetThuc
            // 
            this.GioTrucKetThuc.DataPropertyName = "GioTrucKetThuc";
            this.GioTrucKetThuc.HeaderText = "Giờ Kết Thúc";
            this.GioTrucKetThuc.Name = "GioTrucKetThuc";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSoLuong.Location = new System.Drawing.Point(12, 50);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(120, 22);
            this.txtSoLuong.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lượng Cán Bộ Cần";
            // 
            // FormTKCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTKCanBo";
            this.Text = "Thống Kê Cán Bộ";
            this.Load += new System.EventHandler(this.FormTKCanBo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCanBo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridThongKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtMaCanBo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTrucBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTrucKetThuc;
    }
}