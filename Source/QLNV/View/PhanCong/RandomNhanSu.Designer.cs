namespace QLNV.View
{
    partial class RandomNhanSu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtGridNhanSu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbxCaTruc = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNhanSu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTu);
            this.groupBox1.Controls.Add(this.dtGridNhanSu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(18, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân Sự Khả Thi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(459, 24);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(91, 20);
            this.txtNhanVien.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(377, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Số Nhân Viên:";
            // 
            // dtGridNhanSu
            // 
            this.dtGridNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridNhanSu.Location = new System.Drawing.Point(6, 50);
            this.dtGridNhanSu.Name = "dtGridNhanSu";
            this.dtGridNhanSu.Size = new System.Drawing.Size(548, 195);
            this.dtGridNhanSu.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChon);
            this.groupBox3.Controls.Add(this.cbxCaTruc);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dtNgayTruc);
            this.groupBox3.Location = new System.Drawing.Point(18, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 57);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày Trực";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(459, 19);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 17;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cbxCaTruc
            // 
            this.cbxCaTruc.FormattingEnabled = true;
            this.cbxCaTruc.Location = new System.Drawing.Point(332, 18);
            this.cbxCaTruc.Name = "cbxCaTruc";
            this.cbxCaTruc.Size = new System.Drawing.Size(121, 21);
            this.cbxCaTruc.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(279, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Ca Trực:";
            // 
            // button2
            // 
            this.button2.Image = global::QLNV.Properties.Resources.timkiem_small;
            this.button2.Location = new System.Drawing.Point(134, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xem";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtNgayTruc
            // 
            this.dtNgayTruc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTruc.Location = new System.Drawing.Point(19, 19);
            this.dtNgayTruc.Name = "dtNgayTruc";
            this.dtNgayTruc.Size = new System.Drawing.Size(110, 20);
            this.dtNgayTruc.TabIndex = 12;
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(39, 24);
            this.txtTu.Name = "txtTu";
            this.txtTu.ReadOnly = true;
            this.txtTu.Size = new System.Drawing.Size(116, 20);
            this.txtTu.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ:";
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(229, 24);
            this.txtDen.Name = "txtDen";
            this.txtDen.ReadOnly = true;
            this.txtDen.Size = new System.Drawing.Size(116, 20);
            this.txtDen.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Đến:";
            // 
            // RandomNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RandomNhanSu";
            this.Text = "Chọn Nhân Sự Tự Động";
            this.Load += new System.EventHandler(this.RandomNhanSu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNhanSu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGridNhanSu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtNgayTruc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cbxCaTruc;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label label2;
    }
}