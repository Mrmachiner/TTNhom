namespace QLNV.View
{
    partial class frmQuanLyDot
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridData = new System.Windows.Forms.DataGridView();
            this.dotCongViecIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongNguoiCanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dotCongViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotCongViecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLNV.Properties.Resources.them;
            this.btnThem.Location = new System.Drawing.Point(639, 18);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLNV.Properties.Resources.xoa_small;
            this.btnXoa.Location = new System.Drawing.Point(710, 18);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 34);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Công Việc";
            // 
            // dtGridData
            // 
            this.dtGridData.AutoGenerateColumns = false;
            this.dtGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dotCongViecIDDataGridViewTextBoxColumn,
            this.ngayBatDauDataGridViewTextBoxColumn,
            this.ngayKetThucDataGridViewTextBoxColumn,
            this.luongNguoiCanDataGridViewTextBoxColumn});
            this.dtGridData.DataSource = this.dotCongViecBindingSource;
            this.dtGridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridData.Location = new System.Drawing.Point(3, 16);
            this.dtGridData.Name = "dtGridData";
            this.dtGridData.Size = new System.Drawing.Size(794, 356);
            this.dtGridData.TabIndex = 0;
            this.dtGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridData_CellContentClick);
            // 
            // dotCongViecIDDataGridViewTextBoxColumn
            // 
            this.dotCongViecIDDataGridViewTextBoxColumn.DataPropertyName = "DotCongViecID";
            this.dotCongViecIDDataGridViewTextBoxColumn.HeaderText = "Mã Đợt Công Việc";
            this.dotCongViecIDDataGridViewTextBoxColumn.Name = "dotCongViecIDDataGridViewTextBoxColumn";
            // 
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.HeaderText = "Ngày Bắt Đầu";
            this.ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            // 
            // ngayKetThucDataGridViewTextBoxColumn
            // 
            this.ngayKetThucDataGridViewTextBoxColumn.DataPropertyName = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.HeaderText = "Ngày Kết Thúc";
            this.ngayKetThucDataGridViewTextBoxColumn.Name = "ngayKetThucDataGridViewTextBoxColumn";
            // 
            // luongNguoiCanDataGridViewTextBoxColumn
            // 
            this.luongNguoiCanDataGridViewTextBoxColumn.DataPropertyName = "LuongNguoiCan";
            this.luongNguoiCanDataGridViewTextBoxColumn.HeaderText = "Lượng Người Cần";
            this.luongNguoiCanDataGridViewTextBoxColumn.Name = "luongNguoiCanDataGridViewTextBoxColumn";
            // 
            // dotCongViecBindingSource
            // 
            this.dotCongViecBindingSource.DataSource = typeof(QLNV.Model.DotCongViec);
            // 
            // frmQuanLyDot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyDot";
            this.Text = "Quản Lý Đợt Công Việc";
            this.Load += new System.EventHandler(this.frmQuanLyDot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotCongViecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridData;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotCongViecIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongNguoiCanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dotCongViecBindingSource;
    }
}