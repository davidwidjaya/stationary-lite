namespace projekakhir
{
    partial class inventaris
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupBoxTambahBarang = new System.Windows.Forms.GroupBox();
            this.btnDeleteBarang = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStokBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.btnTambahBarang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grupBoxTambahBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBarang,
            this.namaBarang,
            this.hargaBarang,
            this.STOK,
            this.tglMasuk});
            this.dataGridView1.Location = new System.Drawing.Point(301, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(474, 326);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // kodeBarang
            // 
            this.kodeBarang.DataPropertyName = "kodeBarang";
            this.kodeBarang.HeaderText = "KODE";
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.ReadOnly = true;
            this.kodeBarang.Visible = false;
            // 
            // namaBarang
            // 
            this.namaBarang.DataPropertyName = "namaBarang";
            this.namaBarang.HeaderText = "NAMA";
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            // 
            // hargaBarang
            // 
            this.hargaBarang.DataPropertyName = "hargaBarang";
            this.hargaBarang.HeaderText = "HARGA";
            this.hargaBarang.Name = "hargaBarang";
            this.hargaBarang.ReadOnly = true;
            // 
            // STOK
            // 
            this.STOK.DataPropertyName = "stok";
            this.STOK.HeaderText = "STOK";
            this.STOK.Name = "STOK";
            this.STOK.ReadOnly = true;
            // 
            // tglMasuk
            // 
            this.tglMasuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tglMasuk.DataPropertyName = "tglMasuk";
            this.tglMasuk.HeaderText = "TGL";
            this.tglMasuk.Name = "tglMasuk";
            this.tglMasuk.ReadOnly = true;
            // 
            // grupBoxTambahBarang
            // 
            this.grupBoxTambahBarang.Controls.Add(this.btnLogout);
            this.grupBoxTambahBarang.Controls.Add(this.btnDeleteBarang);
            this.grupBoxTambahBarang.Controls.Add(this.btnUpdate);
            this.grupBoxTambahBarang.Controls.Add(this.txtStokBarang);
            this.grupBoxTambahBarang.Controls.Add(this.label5);
            this.grupBoxTambahBarang.Controls.Add(this.txtNamaBarang);
            this.grupBoxTambahBarang.Controls.Add(this.txtHargaBarang);
            this.grupBoxTambahBarang.Controls.Add(this.btnTambahBarang);
            this.grupBoxTambahBarang.Controls.Add(this.label3);
            this.grupBoxTambahBarang.Controls.Add(this.label4);
            this.grupBoxTambahBarang.Location = new System.Drawing.Point(12, 12);
            this.grupBoxTambahBarang.Name = "grupBoxTambahBarang";
            this.grupBoxTambahBarang.Size = new System.Drawing.Size(274, 326);
            this.grupBoxTambahBarang.TabIndex = 8;
            this.grupBoxTambahBarang.TabStop = false;
            this.grupBoxTambahBarang.Text = "Tambah Barang";
            // 
            // btnDeleteBarang
            // 
            this.btnDeleteBarang.Location = new System.Drawing.Point(17, 206);
            this.btnDeleteBarang.Name = "btnDeleteBarang";
            this.btnDeleteBarang.Size = new System.Drawing.Size(251, 34);
            this.btnDeleteBarang.TabIndex = 9;
            this.btnDeleteBarang.Text = "Delete Barang";
            this.btnDeleteBarang.UseVisualStyleBackColor = true;
            this.btnDeleteBarang.Click += new System.EventHandler(this.BtnDeleteBarang_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(17, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(251, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Barang";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtStokBarang
            // 
            this.txtStokBarang.Location = new System.Drawing.Point(94, 89);
            this.txtStokBarang.Name = "txtStokBarang";
            this.txtStokBarang.Size = new System.Drawing.Size(174, 20);
            this.txtStokBarang.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stok :";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(94, 32);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(174, 20);
            this.txtNamaBarang.TabIndex = 4;
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.Location = new System.Drawing.Point(94, 58);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.Size = new System.Drawing.Size(174, 20);
            this.txtHargaBarang.TabIndex = 6;
            // 
            // btnTambahBarang
            // 
            this.btnTambahBarang.Location = new System.Drawing.Point(16, 166);
            this.btnTambahBarang.Name = "btnTambahBarang";
            this.btnTambahBarang.Size = new System.Drawing.Size(251, 34);
            this.btnTambahBarang.TabIndex = 1;
            this.btnTambahBarang.Text = "Tambah Barang";
            this.btnTambahBarang.UseVisualStyleBackColor = true;
            this.btnTambahBarang.Click += new System.EventHandler(this.BtnTambahBarang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga Barang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Barang :";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(192, 297);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // inventaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 350);
            this.Controls.Add(this.grupBoxTambahBarang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "inventaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventaris";
            this.Load += new System.EventHandler(this.Inventaris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grupBoxTambahBarang.ResumeLayout(false);
            this.grupBoxTambahBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grupBoxTambahBarang;
        private System.Windows.Forms.TextBox txtStokBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.Button btnTambahBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteBarang;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglMasuk;
        private System.Windows.Forms.Button btnLogout;
    }
}