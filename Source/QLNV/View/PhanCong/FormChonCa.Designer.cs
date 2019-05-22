namespace QLNV.View
{
    partial class FormChonCa
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
            this.cbxChonCa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgCan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGribPhai = new System.Windows.Forms.DataGridView();
            this.Chon1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnPhai = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGridTrai = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountCv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtNgayTruc = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDenNgay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTuNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.canBoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.canBoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxChonCa
            // 
            this.cbxChonCa.FormattingEnabled = true;
            this.cbxChonCa.Location = new System.Drawing.Point(67, 26);
            this.cbxChonCa.Margin = new System.Windows.Forms.Padding(2);
            this.cbxChonCa.Name = "cbxChonCa";
            this.cbxChonCa.Size = new System.Drawing.Size(124, 21);
            this.cbxChonCa.TabIndex = 7;
            this.cbxChonCa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn Ca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNgCan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtBatDau);
            this.groupBox1.Controls.Add(this.dtKetThuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.cbxChonCa);
            this.groupBox1.Location = new System.Drawing.Point(10, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Người Cần:";
            // 
            // txtNgCan
            // 
            this.txtNgCan.Location = new System.Drawing.Point(809, 28);
            this.txtNgCan.Name = "txtNgCan";
            this.txtNgCan.ReadOnly = true;
            this.txtNgCan.Size = new System.Drawing.Size(154, 20);
            this.txtNgCan.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kết Thúc:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bắt Đầu:";
            // 
            // dtBatDau
            // 
            this.dtBatDau.Location = new System.Drawing.Point(324, 27);
            this.dtBatDau.Name = "dtBatDau";
            this.dtBatDau.Size = new System.Drawing.Size(169, 20);
            this.dtBatDau.TabIndex = 11;
            this.dtBatDau.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtKetThuc
            // 
            this.dtKetThuc.Location = new System.Drawing.Point(561, 28);
            this.dtKetThuc.Name = "dtKetThuc";
            this.dtKetThuc.Size = new System.Drawing.Size(176, 20);
            this.dtKetThuc.TabIndex = 10;
            // 
            // btnXem
            // 
            this.btnXem.Image = global::QLNV.Properties.Resources.timkiem_small;
            this.btnXem.Location = new System.Drawing.Point(194, 22);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(65, 27);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGribPhai);
            this.groupBox2.Controls.Add(this.btnTrai);
            this.groupBox2.Controls.Add(this.btnPhai);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(10, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 358);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu Nhân Viên";
            // 
            // dtGribPhai
            // 
            this.dtGribPhai.AllowUserToAddRows = false;
            this.dtGribPhai.AllowUserToDeleteRows = false;
            this.dtGribPhai.AutoGenerateColumns = false;
            this.dtGribPhai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGribPhai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dtGribPhai.DataSource = this.canBoBindingSource2;
            this.dtGribPhai.Location = new System.Drawing.Point(534, 52);
            this.dtGribPhai.Margin = new System.Windows.Forms.Padding(2);
            this.dtGribPhai.Name = "dtGribPhai";
            this.dtGribPhai.RowTemplate.Height = 24;
            this.dtGribPhai.Size = new System.Drawing.Size(462, 291);
            this.dtGribPhai.TabIndex = 7;
            this.dtGribPhai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGribPhai_CellContentClick);
            // 
            // Chon1
            // 
            this.Chon1.HeaderText = "Chon";
            this.Chon1.Name = "Chon1";
            this.Chon1.Width = 49;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CanBoID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 30;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn12.HeaderText = "Họ và Tên";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn13.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 75;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DonViID";
            this.dataGridViewTextBoxColumn14.HeaderText = "Đơn Vị";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 58;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn15.HeaderText = "Chức Vụ";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 58;
            // 
            // canBoBindingSource2
            // 
            this.canBoBindingSource2.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // btnTrai
            // 
            this.btnTrai.Image = global::QLNV.Properties.Resources.chuyenlop_lai;
            this.btnTrai.Location = new System.Drawing.Point(485, 143);
            this.btnTrai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(44, 38);
            this.btnTrai.TabIndex = 3;
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnPhai
            // 
            this.btnPhai.Image = global::QLNV.Properties.Resources.chuyenlop;
            this.btnPhai.Location = new System.Drawing.Point(485, 200);
            this.btnPhai.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(44, 38);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 322);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtGridTrai);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(469, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dữ Liệu Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtGridTrai
            // 
            this.dtGridTrai.AllowUserToAddRows = false;
            this.dtGridTrai.AllowUserToDeleteRows = false;
            this.dtGridTrai.AutoGenerateColumns = false;
            this.dtGridTrai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTrai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.CountCv});
            this.dtGridTrai.DataSource = this.canBoBindingSource;
            this.dtGridTrai.Location = new System.Drawing.Point(4, 2);
            this.dtGridTrai.Margin = new System.Windows.Forms.Padding(2);
            this.dtGridTrai.Name = "dtGridTrai";
            this.dtGridTrai.RowTemplate.Height = 24;
            this.dtGridTrai.Size = new System.Drawing.Size(462, 291);
            this.dtGridTrai.TabIndex = 1;
            this.dtGridTrai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridTrai_CellContentClick);
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chon";
            this.Chon.Name = "Chon";
            this.Chon.Width = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CanBoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Chức Vụ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 58;
            // 
            // CountCv
            // 
            this.CountCv.DataPropertyName = "CountCv";
            this.CountCv.HeaderText = "Lượng Công Việc";
            this.CountCv.Name = "CountCv";
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // dtNgayTruc
            // 
            this.dtNgayTruc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTruc.Location = new System.Drawing.Point(19, 19);
            this.dtNgayTruc.Name = "dtNgayTruc";
            this.dtNgayTruc.Size = new System.Drawing.Size(200, 20);
            this.dtNgayTruc.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDenNgay);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTuNgay);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDot);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dtNgayTruc);
            this.groupBox3.Location = new System.Drawing.Point(10, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1000, 58);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày Trực";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Đến Ngày:";
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Location = new System.Drawing.Point(809, 19);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.ReadOnly = true;
            this.txtDenNgay.Size = new System.Drawing.Size(154, 20);
            this.txtDenNgay.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Từ Ngày:";
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Location = new System.Drawing.Point(583, 19);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.ReadOnly = true;
            this.txtTuNgay.Size = new System.Drawing.Size(154, 20);
            this.txtTuNgay.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trong đợt:";
            // 
            // txtDot
            // 
            this.txtDot.Location = new System.Drawing.Point(375, 19);
            this.txtDot.Name = "txtDot";
            this.txtDot.ReadOnly = true;
            this.txtDot.Size = new System.Drawing.Size(130, 20);
            this.txtDot.TabIndex = 18;
            this.txtDot.TextChanged += new System.EventHandler(this.txtDot_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = global::QLNV.Properties.Resources.timkiem_small;
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Xem";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QLNV.Properties.Resources.them_small;
            this.btnLuu.Location = new System.Drawing.Point(951, 502);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 31);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // canBoBindingSource1
            // 
            this.canBoBindingSource1.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // canBoBindingSource4
            // 
            this.canBoBindingSource4.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // FormChonCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChonCa";
            this.Text = "Phân Công Việc Làm";
            this.Load += new System.EventHandler(this.FormChonCa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.BindingSource canBoBindingSource4;
        private System.Windows.Forms.BindingSource canBoBindingSource1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource canBoBindingSource2;
        private System.Windows.Forms.ComboBox cbxChonCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBatDau;
        private System.Windows.Forms.DateTimePicker dtKetThuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGribPhai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private System.Windows.Forms.DateTimePicker dtNgayTruc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgCan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGridTrai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountCv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDenNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDot;
    }
}