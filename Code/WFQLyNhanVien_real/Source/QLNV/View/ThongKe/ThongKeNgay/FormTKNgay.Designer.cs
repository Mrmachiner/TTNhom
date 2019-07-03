namespace QLNV.View
{
    partial class FormTKNgay
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridThongKe = new System.Windows.Forms.DataGridView();
            this.dtDanhSanh = new System.Windows.Forms.DataGridView();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCanBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSLNguoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSLViec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.lable = new System.Windows.Forms.Label();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.caTrucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caTrucIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeuCauIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiCanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caTrucBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridThongKe);
            this.groupBox2.Controls.Add(this.dtDanhSanh);
            this.groupBox2.Controls.Add(this.txtSLNguoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSLViec);
            this.groupBox2.Location = new System.Drawing.Point(16, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1172, 453);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thống Kê";
            // 
            // dtGridThongKe
            // 
            this.dtGridThongKe.AllowUserToAddRows = false;
            this.dtGridThongKe.AllowUserToOrderColumns = true;
            this.dtGridThongKe.AutoGenerateColumns = false;
            this.dtGridThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caTrucIDDataGridViewTextBoxColumn,
            this.yeuCauIDDataGridViewTextBoxColumn,
            this.tenCaDataGridViewTextBoxColumn,
            this.batDauDataGridViewTextBoxColumn,
            this.nguoiCanDataGridViewTextBoxColumn});
            this.dtGridThongKe.DataSource = this.caTrucBindingSource;
            this.dtGridThongKe.Location = new System.Drawing.Point(587, 53);
            this.dtGridThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridThongKe.Name = "dtGridThongKe";
            this.dtGridThongKe.Size = new System.Drawing.Size(559, 366);
            this.dtGridThongKe.TabIndex = 8;
            this.dtGridThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridThongKe_CellContentClick);
            this.dtGridThongKe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ChiTiet);
            // 
            // dtDanhSanh
            // 
            this.dtDanhSanh.AllowUserToAddRows = false;
            this.dtDanhSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.NgaySinh,
            this.ChucVu,
            this.MaCanBo});
            this.dtDanhSanh.Location = new System.Drawing.Point(11, 53);
            this.dtDanhSanh.Margin = new System.Windows.Forms.Padding(4);
            this.dtDanhSanh.Name = "dtDanhSanh";
            this.dtDanhSanh.ReadOnly = true;
            this.dtDanhSanh.Size = new System.Drawing.Size(568, 366);
            this.dtDanhSanh.TabIndex = 1;
            this.dtDanhSanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDanhSanh_CellContentClick);
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // MaCanBo
            // 
            this.MaCanBo.DataPropertyName = "MaCanBo";
            this.MaCanBo.HeaderText = "Cán Bộ ID";
            this.MaCanBo.Name = "MaCanBo";
            this.MaCanBo.ReadOnly = true;
            // 
            // txtSLNguoi
            // 
            this.txtSLNguoi.Location = new System.Drawing.Point(117, 21);
            this.txtSLNguoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLNguoi.Name = "txtSLNguoi";
            this.txtSLNguoi.ReadOnly = true;
            this.txtSLNguoi.Size = new System.Drawing.Size(171, 22);
            this.txtSLNguoi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số người làm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lượng Cán Bộ Cần";
            // 
            // txtSLViec
            // 
            this.txtSLViec.Location = new System.Drawing.Point(724, 22);
            this.txtSLViec.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLViec.Name = "txtSLViec";
            this.txtSLViec.ReadOnly = true;
            this.txtSLViec.Size = new System.Drawing.Size(148, 22);
            this.txtSLViec.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.tuNgay);
            this.groupBox1.Controls.Add(this.lable);
            this.groupBox1.Controls.Add(this.denNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1172, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::QLNV.Properties.Resources.capnhat;
            this.btnThongKe.Location = new System.Drawing.Point(712, 25);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(105, 39);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tuNgay
            // 
            this.tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tuNgay.Location = new System.Drawing.Point(204, 30);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(175, 22);
            this.tuNgay.TabIndex = 1;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(152, 37);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(29, 17);
            this.lable.TabIndex = 2;
            this.lable.Text = "Từ:";
            // 
            // denNgay
            // 
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denNgay.Location = new System.Drawing.Point(496, 30);
            this.denNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(172, 22);
            this.denNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // caTrucBindingSource
            // 
            this.caTrucBindingSource.DataSource = typeof(QLNV.Model.CaTruc);
            // 
            // caTrucIDDataGridViewTextBoxColumn
            // 
            this.caTrucIDDataGridViewTextBoxColumn.DataPropertyName = "CaTrucID";
            this.caTrucIDDataGridViewTextBoxColumn.HeaderText = "CaTrucID";
            this.caTrucIDDataGridViewTextBoxColumn.Name = "caTrucIDDataGridViewTextBoxColumn";
            // 
            // yeuCauIDDataGridViewTextBoxColumn
            // 
            this.yeuCauIDDataGridViewTextBoxColumn.DataPropertyName = "YeuCauID";
            this.yeuCauIDDataGridViewTextBoxColumn.HeaderText = "YeuCauID";
            this.yeuCauIDDataGridViewTextBoxColumn.Name = "yeuCauIDDataGridViewTextBoxColumn";
            // 
            // tenCaDataGridViewTextBoxColumn
            // 
            this.tenCaDataGridViewTextBoxColumn.DataPropertyName = "TenCa";
            this.tenCaDataGridViewTextBoxColumn.HeaderText = "TenCa";
            this.tenCaDataGridViewTextBoxColumn.Name = "tenCaDataGridViewTextBoxColumn";
            // 
            // batDauDataGridViewTextBoxColumn
            // 
            this.batDauDataGridViewTextBoxColumn.DataPropertyName = "BatDau";
            this.batDauDataGridViewTextBoxColumn.HeaderText = "BatDau";
            this.batDauDataGridViewTextBoxColumn.Name = "batDauDataGridViewTextBoxColumn";
            // 
            // nguoiCanDataGridViewTextBoxColumn
            // 
            this.nguoiCanDataGridViewTextBoxColumn.DataPropertyName = "NguoiCan";
            this.nguoiCanDataGridViewTextBoxColumn.HeaderText = "NguoiCan";
            this.nguoiCanDataGridViewTextBoxColumn.Name = "nguoiCanDataGridViewTextBoxColumn";
            // 
            // FormTKNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTKNgay";
            this.Text = "Thống Kê Theo Ngày";
            this.Load += new System.EventHandler(this.FormTKNgay_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caTrucBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txtSLNguoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLViec;
        private System.Windows.Forms.DataGridView dtGridThongKe;
        private System.Windows.Forms.DataGridView dtDanhSanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCanBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn caTrucIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeuCauIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiCanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource caTrucBindingSource;
    }
}