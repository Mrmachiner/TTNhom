namespace QLNV
{
    partial class FormQuanLyYeuCau
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
            this.gridYeuCau = new System.Windows.Forms.DataGridView();
            this.caTrucIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiCanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caTrucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtTimKiem = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.BtnTaoCa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.yeuCauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caTrucBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridYeuCau
            // 
            this.gridYeuCau.AllowUserToAddRows = false;
            this.gridYeuCau.AllowUserToDeleteRows = false;
            this.gridYeuCau.AutoGenerateColumns = false;
            this.gridYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridYeuCau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caTrucIDDataGridViewTextBoxColumn,
            this.tenCaDataGridViewTextBoxColumn,
            this.batDauDataGridViewTextBoxColumn,
            this.ketThucDataGridViewTextBoxColumn,
            this.nguoiCanDataGridViewTextBoxColumn,
            this.yeuCauDataGridViewTextBoxColumn});
            this.gridYeuCau.DataSource = this.caTrucBindingSource;
            this.gridYeuCau.Location = new System.Drawing.Point(0, 18);
            this.gridYeuCau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridYeuCau.Name = "gridYeuCau";
            this.gridYeuCau.ReadOnly = true;
            this.gridYeuCau.RowTemplate.Height = 24;
            this.gridYeuCau.Size = new System.Drawing.Size(581, 222);
            this.gridYeuCau.TabIndex = 0;
            this.gridYeuCau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridYeuCau_CellClick);
            this.gridYeuCau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridYeuCau_CellContentClick);
            // 
            // caTrucIDDataGridViewTextBoxColumn
            // 
            this.caTrucIDDataGridViewTextBoxColumn.DataPropertyName = "CaTrucID";
            this.caTrucIDDataGridViewTextBoxColumn.HeaderText = "Ca Trực ID";
            this.caTrucIDDataGridViewTextBoxColumn.Name = "caTrucIDDataGridViewTextBoxColumn";
            this.caTrucIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.caTrucIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // tenCaDataGridViewTextBoxColumn
            // 
            this.tenCaDataGridViewTextBoxColumn.DataPropertyName = "TenCa";
            this.tenCaDataGridViewTextBoxColumn.HeaderText = "Tên Ca";
            this.tenCaDataGridViewTextBoxColumn.Name = "tenCaDataGridViewTextBoxColumn";
            this.tenCaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenCaDataGridViewTextBoxColumn.Width = 60;
            // 
            // batDauDataGridViewTextBoxColumn
            // 
            this.batDauDataGridViewTextBoxColumn.DataPropertyName = "BatDau";
            this.batDauDataGridViewTextBoxColumn.HeaderText = "Bắt Đầu";
            this.batDauDataGridViewTextBoxColumn.Name = "batDauDataGridViewTextBoxColumn";
            this.batDauDataGridViewTextBoxColumn.ReadOnly = true;
            this.batDauDataGridViewTextBoxColumn.Width = 130;
            // 
            // ketThucDataGridViewTextBoxColumn
            // 
            this.ketThucDataGridViewTextBoxColumn.DataPropertyName = "KetThuc";
            this.ketThucDataGridViewTextBoxColumn.HeaderText = "Kết Thúc";
            this.ketThucDataGridViewTextBoxColumn.Name = "ketThucDataGridViewTextBoxColumn";
            this.ketThucDataGridViewTextBoxColumn.ReadOnly = true;
            this.ketThucDataGridViewTextBoxColumn.Width = 130;
            // 
            // nguoiCanDataGridViewTextBoxColumn
            // 
            this.nguoiCanDataGridViewTextBoxColumn.DataPropertyName = "NguoiCan";
            this.nguoiCanDataGridViewTextBoxColumn.HeaderText = "Người Cần";
            this.nguoiCanDataGridViewTextBoxColumn.Name = "nguoiCanDataGridViewTextBoxColumn";
            this.nguoiCanDataGridViewTextBoxColumn.ReadOnly = true;
            this.nguoiCanDataGridViewTextBoxColumn.Width = 65;
            // 
            // yeuCauDataGridViewTextBoxColumn
            // 
            this.yeuCauDataGridViewTextBoxColumn.DataPropertyName = "YeuCau";
            this.yeuCauDataGridViewTextBoxColumn.HeaderText = "Yêu Cầu";
            this.yeuCauDataGridViewTextBoxColumn.Name = "yeuCauDataGridViewTextBoxColumn";
            this.yeuCauDataGridViewTextBoxColumn.ReadOnly = true;
            this.yeuCauDataGridViewTextBoxColumn.Width = 75;
            // 
            // caTrucBindingSource
            // 
            // 
            // dtTimKiem
            // 
            this.dtTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTimKiem.Location = new System.Drawing.Point(5, 30);
            this.dtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtTimKiem.Name = "dtTimKiem";
            this.dtTimKiem.Size = new System.Drawing.Size(226, 20);
            this.dtTimKiem.TabIndex = 1;
            this.dtTimKiem.Tag = "";
            this.dtTimKiem.ValueChanged += new System.EventHandler(this.dtTimKiem_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tìm Kiếm:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.dtTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.BtnTaoCa);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QLNV.Properties.Resources.timkiem_small1;
            this.btnTimKiem.Location = new System.Drawing.Point(235, 26);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 33);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Tag = "3";
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLNV.Properties.Resources.sua1;
            this.btnSua.Location = new System.Drawing.Point(369, 26);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Tag = "4";
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLNV.Properties.Resources.xoa_small;
            this.btnXoa.Location = new System.Drawing.Point(437, 26);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 33);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Tag = "5";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // BtnTaoCa
            // 
            this.BtnTaoCa.Image = global::QLNV.Properties.Resources.them;
            this.BtnTaoCa.Location = new System.Drawing.Point(303, 26);
            this.BtnTaoCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnTaoCa.Name = "BtnTaoCa";
            this.BtnTaoCa.Size = new System.Drawing.Size(62, 33);
            this.BtnTaoCa.TabIndex = 9;
            this.BtnTaoCa.Tag = "9";
            this.BtnTaoCa.Text = "Thêm";
            this.BtnTaoCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTaoCa.UseVisualStyleBackColor = true;
            this.BtnTaoCa.Click += new System.EventHandler(this.BtnTaoCa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.gridYeuCau);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 276);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 22);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "Tải Lại....";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yeuCauBindingSource
            // 
            this.yeuCauBindingSource.CurrentChanged += new System.EventHandler(this.yeuCauBindingSource_CurrentChanged);
            // 
            // button1
            // 
            this.button1.Image = global::QLNV.Properties.Resources.them;
            this.button1.Location = new System.Drawing.Point(505, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 14;
            this.button1.Tag = "9";
            this.button1.Text = "Tạo Đợt";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormQuanLyYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormQuanLyYeuCau";
            this.Text = "Quản Lý Yêu Cầu";
            this.Load += new System.EventHandler(this.FormQuanLyYeuCau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caTrucBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridYeuCau;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button BtnTaoCa;
        private System.Windows.Forms.DateTimePicker dtTimKiem;
        private System.Windows.Forms.BindingSource yeuCauBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNguoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource caTrucBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn caTrucIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiCanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeuCauDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}