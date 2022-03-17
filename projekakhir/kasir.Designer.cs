namespace projekakhir
{
    partial class kasir
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
            this.gridView_Kasir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grupBoxPemesanan = new System.Windows.Forms.GroupBox();
            this.numericQty = new System.Windows.Forms.NumericUpDown();
            this.btnKeranjang = new System.Windows.Forms.Button();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.cmbBarang = new System.Windows.Forms.ComboBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnLakukanPembayaran = new System.Windows.Forms.Button();
            this.timerWaktu = new System.Windows.Forms.Timer(this.components);
            this.label100 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Kasir)).BeginInit();
            this.grupBoxPemesanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQty)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView_Kasir
            // 
            this.gridView_Kasir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_Kasir.BackgroundColor = System.Drawing.Color.Gold;
            this.gridView_Kasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_Kasir.Location = new System.Drawing.Point(12, 177);
            this.gridView_Kasir.Name = "gridView_Kasir";
            this.gridView_Kasir.ReadOnly = true;
            this.gridView_Kasir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView_Kasir.Size = new System.Drawing.Size(725, 247);
            this.gridView_Kasir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanggal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qty :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Harga :";
            // 
            // grupBoxPemesanan
            // 
            this.grupBoxPemesanan.Controls.Add(this.numericQty);
            this.grupBoxPemesanan.Controls.Add(this.btnKeranjang);
            this.grupBoxPemesanan.Controls.Add(this.txtJumlah);
            this.grupBoxPemesanan.Controls.Add(this.label6);
            this.grupBoxPemesanan.Controls.Add(this.txtHarga);
            this.grupBoxPemesanan.Controls.Add(this.cmbBarang);
            this.grupBoxPemesanan.Controls.Add(this.label3);
            this.grupBoxPemesanan.Controls.Add(this.label5);
            this.grupBoxPemesanan.Controls.Add(this.label4);
            this.grupBoxPemesanan.Location = new System.Drawing.Point(15, 71);
            this.grupBoxPemesanan.Name = "grupBoxPemesanan";
            this.grupBoxPemesanan.Size = new System.Drawing.Size(722, 100);
            this.grupBoxPemesanan.TabIndex = 8;
            this.grupBoxPemesanan.TabStop = false;
            this.grupBoxPemesanan.Text = "Pemesanan";
            // 
            // numericQty
            // 
            this.numericQty.Location = new System.Drawing.Point(250, 38);
            this.numericQty.Name = "numericQty";
            this.numericQty.Size = new System.Drawing.Size(120, 20);
            this.numericQty.TabIndex = 14;
            this.numericQty.ValueChanged += new System.EventHandler(this.numericQty_ValueChanged);
            // 
            // btnKeranjang
            // 
            this.btnKeranjang.Location = new System.Drawing.Point(568, 61);
            this.btnKeranjang.Name = "btnKeranjang";
            this.btnKeranjang.Size = new System.Drawing.Size(148, 27);
            this.btnKeranjang.TabIndex = 13;
            this.btnKeranjang.Text = "MASUKKAN KERANJANG";
            this.btnKeranjang.UseVisualStyleBackColor = true;
            this.btnKeranjang.Click += new System.EventHandler(this.btnKeranjang_Click);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Enabled = false;
            this.txtJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(428, 72);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(107, 20);
            this.txtJumlah.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Jumlah :";
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(428, 37);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(107, 20);
            this.txtHarga.TabIndex = 10;
            // 
            // cmbBarang
            // 
            this.cmbBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarang.FormattingEnabled = true;
            this.cmbBarang.Location = new System.Drawing.Point(59, 37);
            this.cmbBarang.Name = "cmbBarang";
            this.cmbBarang.Size = new System.Drawing.Size(115, 21);
            this.cmbBarang.TabIndex = 8;
            this.cmbBarang.SelectedIndexChanged += new System.EventHandler(this.cmbBarang_SelectedIndexChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(12, 430);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(134, 23);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus Keranjang Terpilih";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnLakukanPembayaran
            // 
            this.btnLakukanPembayaran.Location = new System.Drawing.Point(589, 430);
            this.btnLakukanPembayaran.Name = "btnLakukanPembayaran";
            this.btnLakukanPembayaran.Size = new System.Drawing.Size(148, 27);
            this.btnLakukanPembayaran.TabIndex = 14;
            this.btnLakukanPembayaran.Text = "Lakukan Pembayaran";
            this.btnLakukanPembayaran.UseVisualStyleBackColor = true;
            this.btnLakukanPembayaran.Click += new System.EventHandler(this.btnLakukanPembayaran_Click);
            // 
            // timerWaktu
            // 
            this.timerWaktu.Interval = 1000;
            this.timerWaktu.Tick += new System.EventHandler(this.timerWaktu_Tick);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(17, 41);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(54, 15);
            this.label100.TabIndex = 15;
            this.label100.Text = "Waktu: ";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(73, 42);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(77, 15);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "Diisi waktu";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(73, 15);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(88, 15);
            this.lblTanggal.TabIndex = 17;
            this.lblTanggal.Text = "Diisi tanggal";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(656, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 487);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.btnLakukanPembayaran);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.grupBoxPemesanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView_Kasir);
            this.Name = "kasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kasir";
            this.Load += new System.EventHandler(this.kasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Kasir)).EndInit();
            this.grupBoxPemesanan.ResumeLayout(false);
            this.grupBoxPemesanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gridView_Kasir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grupBoxPemesanan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.ComboBox cmbBarang;
        private System.Windows.Forms.Button btnKeranjang;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnLakukanPembayaran;
        private System.Windows.Forms.Timer timerWaktu;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown numericQty;
        public System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Button btnLogout;
    }
}