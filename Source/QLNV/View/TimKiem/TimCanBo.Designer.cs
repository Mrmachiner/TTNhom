namespace QLNV.View
{
    partial class TimCanBo
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCanBo = new System.Windows.Forms.ComboBox();
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.lable = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridThongKe = new System.Windows.Forms.DataGridView();
            this.NgayTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTrucBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(658, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn cán bộ";
            // 
            // cbxCanBo
            // 
            this.cbxCanBo.FormattingEnabled = true;
            this.cbxCanBo.Location = new System.Drawing.Point(297, 44);
            this.cbxCanBo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCanBo.Name = "cbxCanBo";
            this.cbxCanBo.Size = new System.Drawing.Size(233, 24);
            this.cbxCanBo.TabIndex = 4;
            // 
            // tuNgay
            // 
            this.tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tuNgay.Location = new System.Drawing.Point(14, 44);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(114, 22);
            this.tuNgay.TabIndex = 1;
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
            // btnThongKe
            // 
            this.btnThongKe.Image = global::QLNV.Properties.Resources.capnhat;
            this.btnThongKe.Location = new System.Drawing.Point(535, 38);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(105, 40);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // denNgay
            // 
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denNgay.Location = new System.Drawing.Point(161, 45);
            this.denNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(111, 22);
            this.denNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridThongKe);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 357);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch Trực";
            // 
            // dtGridThongKe
            // 
            this.dtGridThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayTruc,
            this.GioTrucBatDau});
            this.dtGridThongKe.Location = new System.Drawing.Point(14, 22);
            this.dtGridThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridThongKe.Name = "dtGridThongKe";
            this.dtGridThongKe.Size = new System.Drawing.Size(627, 316);
            this.dtGridThongKe.TabIndex = 9;
            this.dtGridThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridThongKe_CellContentClick);
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
            this.GioTrucBatDau.HeaderText = "Giờ (ca)";
            this.GioTrucBatDau.Name = "GioTrucBatDau";
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // TimCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TimCanBo";
            this.Text = "Tìm Cán Bộ";
            this.Load += new System.EventHandler(this.TimCanBo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCanBo;
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTrucBatDau;
    }
}