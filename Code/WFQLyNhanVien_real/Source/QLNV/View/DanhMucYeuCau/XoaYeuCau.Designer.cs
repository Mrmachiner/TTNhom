namespace QLNV.View.DanhMucYeuCau
{
    partial class XoaYeuCau
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
            this.yeuCauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dtTimKiem = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gridYeuCau = new System.Windows.Forms.DataGridView();
            this.caTrucIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiCanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeuCauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caTrucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caTrucBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // yeuCauBindingSource
            // 
            this.yeuCauBindingSource.DataSource = typeof(QLNV.Model.YeuCau);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tìm Kiếm:";
            // 
            // dtTimKiem
            // 
            this.dtTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTimKiem.Location = new System.Drawing.Point(7, 325);
            this.dtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTimKiem.Name = "dtTimKiem";
            this.dtTimKiem.Size = new System.Drawing.Size(300, 22);
            this.dtTimKiem.TabIndex = 1;
            this.dtTimKiem.Tag = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.gridYeuCau);
            this.groupBox2.Controls.Add(this.dtTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(781, 367);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QLNV.Properties.Resources.timkiem_small1;
            this.btnTimKiem.Location = new System.Drawing.Point(313, 313);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(79, 41);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Tag = "3";
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLNV.Properties.Resources.xoa_small;
            this.btnXoa.Location = new System.Drawing.Point(689, 309);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 41);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Tag = "5";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 313);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 41);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "Tải Lại....";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.gridYeuCau.Location = new System.Drawing.Point(0, 22);
            this.gridYeuCau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridYeuCau.Name = "gridYeuCau";
            this.gridYeuCau.RowTemplate.Height = 24;
            this.gridYeuCau.Size = new System.Drawing.Size(775, 273);
            this.gridYeuCau.TabIndex = 0;
            // 
            // caTrucIDDataGridViewTextBoxColumn
            // 
            this.caTrucIDDataGridViewTextBoxColumn.DataPropertyName = "CaTrucID";
            this.caTrucIDDataGridViewTextBoxColumn.HeaderText = "Ca Trực ID";
            this.caTrucIDDataGridViewTextBoxColumn.Name = "caTrucIDDataGridViewTextBoxColumn";
            this.caTrucIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // tenCaDataGridViewTextBoxColumn
            // 
            this.tenCaDataGridViewTextBoxColumn.DataPropertyName = "TenCa";
            this.tenCaDataGridViewTextBoxColumn.HeaderText = "Tên Ca";
            this.tenCaDataGridViewTextBoxColumn.Name = "tenCaDataGridViewTextBoxColumn";
            this.tenCaDataGridViewTextBoxColumn.Width = 60;
            // 
            // batDauDataGridViewTextBoxColumn
            // 
            this.batDauDataGridViewTextBoxColumn.DataPropertyName = "BatDau";
            this.batDauDataGridViewTextBoxColumn.HeaderText = "Bắt Đầu";
            this.batDauDataGridViewTextBoxColumn.Name = "batDauDataGridViewTextBoxColumn";
            this.batDauDataGridViewTextBoxColumn.Width = 130;
            // 
            // ketThucDataGridViewTextBoxColumn
            // 
            this.ketThucDataGridViewTextBoxColumn.DataPropertyName = "KetThuc";
            this.ketThucDataGridViewTextBoxColumn.HeaderText = "Kết Thúc";
            this.ketThucDataGridViewTextBoxColumn.Name = "ketThucDataGridViewTextBoxColumn";
            this.ketThucDataGridViewTextBoxColumn.Width = 130;
            // 
            // nguoiCanDataGridViewTextBoxColumn
            // 
            this.nguoiCanDataGridViewTextBoxColumn.DataPropertyName = "NguoiCan";
            this.nguoiCanDataGridViewTextBoxColumn.HeaderText = "Người Cần";
            this.nguoiCanDataGridViewTextBoxColumn.Name = "nguoiCanDataGridViewTextBoxColumn";
            this.nguoiCanDataGridViewTextBoxColumn.Width = 65;
            // 
            // yeuCauDataGridViewTextBoxColumn
            // 
            this.yeuCauDataGridViewTextBoxColumn.DataPropertyName = "YeuCau";
            this.yeuCauDataGridViewTextBoxColumn.HeaderText = "Yêu Cầu";
            this.yeuCauDataGridViewTextBoxColumn.Name = "yeuCauDataGridViewTextBoxColumn";
            this.yeuCauDataGridViewTextBoxColumn.Width = 75;
            // 
            // caTrucBindingSource
            // 
            this.caTrucBindingSource.DataSource = typeof(QLNV.Model.CaTruc);
            // 
            // XoaYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 405);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XoaYeuCau";
            this.Text = "Xóa Yêu Cầu";
            this.Load += new System.EventHandler(this.XoaYeuCau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caTrucBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNguoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource yeuCauBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gridYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn caTrucIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiCanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeuCauDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource caTrucBindingSource;
    }
}