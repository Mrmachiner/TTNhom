namespace QLNV.View.TimKiem
{
    partial class LichTrucf
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
            this.dtGridLich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLich)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridLich
            // 
            this.dtGridLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridLich.Location = new System.Drawing.Point(12, 22);
            this.dtGridLich.Name = "dtGridLich";
            this.dtGridLich.RowTemplate.Height = 24;
            this.dtGridLich.Size = new System.Drawing.Size(476, 296);
            this.dtGridLich.TabIndex = 0;
            this.dtGridLich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LichTrucf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 330);
            this.Controls.Add(this.dtGridLich);
            this.Name = "LichTrucf";
            this.Text = "LịchTrực";
            this.Load += new System.EventHandler(this.LichTrucf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridLich;
    }
}