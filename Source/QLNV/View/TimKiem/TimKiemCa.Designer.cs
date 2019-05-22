namespace QLNV.View.TimKiem
{
    partial class TimKiemCa
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
            this.dtGridTimCa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxChonCa = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.lable = new System.Windows.Forms.Label();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTimCa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridTimCa);
            this.groupBox2.Location = new System.Drawing.Point(13, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(749, 384);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thống Kê";
            // 
            // dtGridTimCa
            // 
            this.dtGridTimCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTimCa.Location = new System.Drawing.Point(8, 38);
            this.dtGridTimCa.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridTimCa.Name = "dtGridTimCa";
            this.dtGridTimCa.Size = new System.Drawing.Size(733, 338);
            this.dtGridTimCa.TabIndex = 8;
            this.dtGridTimCa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridTimCa_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxChonCa);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.tuNgay);
            this.groupBox1.Controls.Add(this.lable);
            this.groupBox1.Controls.Add(this.denNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(749, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn Ca";
            // 
            // cbxChonCa
            // 
            this.cbxChonCa.FormattingEnabled = true;
            this.cbxChonCa.Location = new System.Drawing.Point(7, 34);
            this.cbxChonCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChonCa.Name = "cbxChonCa";
            this.cbxChonCa.Size = new System.Drawing.Size(142, 24);
            this.cbxChonCa.TabIndex = 8;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::QLNV.Properties.Resources.capnhat;
            this.btnThongKe.Location = new System.Drawing.Point(637, 21);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(105, 39);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Tìm Kiếm";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tuNgay
            // 
            this.tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tuNgay.Location = new System.Drawing.Point(191, 36);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(175, 22);
            this.tuNgay.TabIndex = 1;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(187, 18);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(29, 17);
            this.lable.TabIndex = 2;
            this.lable.Text = "Từ:";
            // 
            // denNgay
            // 
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denNgay.Location = new System.Drawing.Point(440, 36);
            this.denNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(172, 22);
            this.denNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // TimKiemCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemCa";
            this.Text = "Tìm Kiếm Ca";
            this.Load += new System.EventHandler(this.TimKiemCa_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTimCa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridTimCa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxChonCa;
    }
}