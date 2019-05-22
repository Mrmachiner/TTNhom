namespace QLNV.View.TimKiem
{
    partial class TimKiemNgay
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
            this.dtGridThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.lable = new System.Windows.Forms.Label();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridThongKe);
            this.groupBox2.Location = new System.Drawing.Point(16, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(629, 384);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thống Kê";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtGridThongKe
            // 
            this.dtGridThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridThongKe.Location = new System.Drawing.Point(4, 23);
            this.dtGridThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridThongKe.Name = "dtGridThongKe";
            this.dtGridThongKe.Size = new System.Drawing.Size(607, 338);
            this.dtGridThongKe.TabIndex = 8;
            this.dtGridThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridThongKe_CellContentClick);
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
            this.groupBox1.Size = new System.Drawing.Size(629, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::QLNV.Properties.Resources.capnhat;
            this.btnThongKe.Location = new System.Drawing.Point(506, 30);
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
            this.tuNgay.Location = new System.Drawing.Point(27, 38);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(175, 22);
            this.tuNgay.TabIndex = 1;
            this.tuNgay.ValueChanged += new System.EventHandler(this.tuNgay_ValueChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(23, 20);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(29, 17);
            this.lable.TabIndex = 2;
            this.lable.Text = "Từ:";
            this.lable.Click += new System.EventHandler(this.lable_Click);
            // 
            // denNgay
            // 
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denNgay.Location = new System.Drawing.Point(276, 38);
            this.denNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(172, 22);
            this.denNgay.TabIndex = 1;
            this.denNgay.ValueChanged += new System.EventHandler(this.denNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TimKiemNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimKiemNgay";
            this.Text = "Tím Kiếm Theo Ngày";
            this.Load += new System.EventHandler(this.TimKiemNgay_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label label2;
    }
}