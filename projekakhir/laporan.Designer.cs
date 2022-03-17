namespace projekakhir
{
    partial class laporan
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
            this.btnLaporPenjualan = new System.Windows.Forms.Button();
            this.btnLaporAbsensi = new System.Windows.Forms.Button();
            this.btnLaporBKeluar = new System.Windows.Forms.Button();
            this.btnLaporBMasuk = new System.Windows.Forms.Button();
            this.btnLaporMasterBarang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaporPenjualan
            // 
            this.btnLaporPenjualan.Location = new System.Drawing.Point(70, 33);
            this.btnLaporPenjualan.Name = "btnLaporPenjualan";
            this.btnLaporPenjualan.Size = new System.Drawing.Size(106, 75);
            this.btnLaporPenjualan.TabIndex = 0;
            this.btnLaporPenjualan.Text = "Laporan Barang Keluar";
            this.btnLaporPenjualan.UseVisualStyleBackColor = true;
            this.btnLaporPenjualan.Click += new System.EventHandler(this.btnLaporPenjualan_Click);
            // 
            // btnLaporAbsensi
            // 
            this.btnLaporAbsensi.Location = new System.Drawing.Point(182, 114);
            this.btnLaporAbsensi.Name = "btnLaporAbsensi";
            this.btnLaporAbsensi.Size = new System.Drawing.Size(106, 75);
            this.btnLaporAbsensi.TabIndex = 1;
            this.btnLaporAbsensi.Text = "Laporan Absensi Pegawai";
            this.btnLaporAbsensi.UseVisualStyleBackColor = true;
            this.btnLaporAbsensi.Click += new System.EventHandler(this.btnLaporAbsensi_Click);
            // 
            // btnLaporBKeluar
            // 
            this.btnLaporBKeluar.Location = new System.Drawing.Point(70, 114);
            this.btnLaporBKeluar.Name = "btnLaporBKeluar";
            this.btnLaporBKeluar.Size = new System.Drawing.Size(106, 75);
            this.btnLaporBKeluar.TabIndex = 2;
            this.btnLaporBKeluar.Text = "Laporan Penjualan";
            this.btnLaporBKeluar.UseVisualStyleBackColor = true;
            this.btnLaporBKeluar.Click += new System.EventHandler(this.btnLaporBKeluar_Click);
            // 
            // btnLaporBMasuk
            // 
            this.btnLaporBMasuk.Location = new System.Drawing.Point(182, 33);
            this.btnLaporBMasuk.Name = "btnLaporBMasuk";
            this.btnLaporBMasuk.Size = new System.Drawing.Size(106, 75);
            this.btnLaporBMasuk.TabIndex = 3;
            this.btnLaporBMasuk.Text = "Laporan Barang Masuk";
            this.btnLaporBMasuk.UseVisualStyleBackColor = true;
            this.btnLaporBMasuk.Click += new System.EventHandler(this.btnLaporBMasuk_Click);
            // 
            // btnLaporMasterBarang
            // 
            this.btnLaporMasterBarang.Location = new System.Drawing.Point(129, 195);
            this.btnLaporMasterBarang.Name = "btnLaporMasterBarang";
            this.btnLaporMasterBarang.Size = new System.Drawing.Size(106, 75);
            this.btnLaporMasterBarang.TabIndex = 4;
            this.btnLaporMasterBarang.Text = "Laporan Master Barang";
            this.btnLaporMasterBarang.UseVisualStyleBackColor = true;
            this.btnLaporMasterBarang.Click += new System.EventHandler(this.btnLaporMasterBarang_Click);
            // 
            // laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 301);
            this.Controls.Add(this.btnLaporMasterBarang);
            this.Controls.Add(this.btnLaporBMasuk);
            this.Controls.Add(this.btnLaporBKeluar);
            this.Controls.Add(this.btnLaporAbsensi);
            this.Controls.Add(this.btnLaporPenjualan);
            this.Name = "laporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laporan";
            this.Load += new System.EventHandler(this.laporan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaporPenjualan;
        private System.Windows.Forms.Button btnLaporAbsensi;
        private System.Windows.Forms.Button btnLaporBKeluar;
        private System.Windows.Forms.Button btnLaporBMasuk;
        private System.Windows.Forms.Button btnLaporMasterBarang;
    }
}