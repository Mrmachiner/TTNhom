namespace QLNV.View
{
    partial class FormTKCa
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKetThuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtGridThongKe = new System.Windows.Forms.DataGridView();
            this.NgayTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGioBatDau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCaTruc = new System.Windows.Forms.ComboBox();
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.lable = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKetThuc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtGridThongKe);
            this.groupBox2.Controls.Add(this.txtGioBatDau);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(692, 456);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thống Kê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chi Tiết Các Ca Trực";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(316, 50);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(132, 22);
            this.txtSoLuong.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng Số Ca Trực";
            // 
            // txtKetThuc
            // 
            this.txtKetThuc.Enabled = false;
            this.txtKetThuc.Location = new System.Drawing.Point(161, 50);
            this.txtKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetThuc.Name = "txtKetThuc";
            this.txtKetThuc.ReadOnly = true;
            this.txtKetThuc.Size = new System.Drawing.Size(132, 22);
            this.txtKetThuc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giờ Kết Thúc";
            // 
            // dtGridThongKe
            // 
            this.dtGridThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayTruc,
            this.SoNguoi});
            this.dtGridThongKe.Location = new System.Drawing.Point(4, 98);
            this.dtGridThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridThongKe.Name = "dtGridThongKe";
            this.dtGridThongKe.Size = new System.Drawing.Size(680, 358);
            this.dtGridThongKe.TabIndex = 8;
            this.dtGridThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridThongKe_CellContentClick);
            this.dtGridThongKe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridThongKe_CellMouseClick);
            // 
            // NgayTruc
            // 
            this.NgayTruc.DataPropertyName = "NgayTruc";
            this.NgayTruc.HeaderText = "Ngày Trực";
            this.NgayTruc.Name = "NgayTruc";
            // 
            // SoNguoi
            // 
            this.SoNguoi.DataPropertyName = "SoNguoi";
            this.SoNguoi.HeaderText = "Số Người Làm";
            this.SoNguoi.Name = "SoNguoi";
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.Enabled = false;
            this.txtGioBatDau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGioBatDau.Location = new System.Drawing.Point(12, 50);
            this.txtGioBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.ReadOnly = true;
            this.txtGioBatDau.Size = new System.Drawing.Size(120, 22);
            this.txtGioBatDau.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giờ Bắt Đầu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxCaTruc);
            this.groupBox1.Controls.Add(this.tuNgay);
            this.groupBox1.Controls.Add(this.lable);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.denNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(692, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn Ca";
            // 
            // cbxCaTruc
            // 
            this.cbxCaTruc.FormattingEnabled = true;
            this.cbxCaTruc.Location = new System.Drawing.Point(382, 49);
            this.cbxCaTruc.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCaTruc.Name = "cbxCaTruc";
            this.cbxCaTruc.Size = new System.Drawing.Size(169, 24);
            this.cbxCaTruc.TabIndex = 4;
            this.cbxCaTruc.SelectedIndexChanged += new System.EventHandler(this.cbxCaTruc_SelectedIndexChanged);
            // 
            // tuNgay
            // 
            this.tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tuNgay.Location = new System.Drawing.Point(10, 50);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(175, 22);
            this.tuNgay.TabIndex = 1;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(6, 32);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(29, 17);
            this.lable.TabIndex = 2;
            this.lable.Text = "Từ:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::QLNV.Properties.Resources.capnhat;
            this.btnThongKe.Location = new System.Drawing.Point(573, 40);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(112, 41);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click_1);
            // 
            // denNgay
            // 
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denNgay.Location = new System.Drawing.Point(203, 50);
            this.denNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(172, 22);
            this.denNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // FormTKCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTKCa";
            this.Text = "Thống Kê Theo Ca";
            this.Load += new System.EventHandler(this.FormTKCa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKetThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtGridThongKe;
        private System.Windows.Forms.TextBox txtGioBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCaTruc;
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
    }
}