namespace projekakhir
{
    partial class detailbayar
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
            this.dataGridView_detail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bayar = new System.Windows.Forms.TextBox();
            this.lbl_kembali = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_detail
            // 
            this.dataGridView_detail.AllowUserToAddRows = false;
            this.dataGridView_detail.AllowUserToDeleteRows = false;
            this.dataGridView_detail.AllowUserToResizeColumns = false;
            this.dataGridView_detail.AllowUserToResizeRows = false;
            this.dataGridView_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_detail.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detail.Location = new System.Drawing.Point(12, 81);
            this.dataGridView_detail.Name = "dataGridView_detail";
            this.dataGridView_detail.ReadOnly = true;
            this.dataGridView_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_detail.Size = new System.Drawing.Size(573, 150);
            this.dataGridView_detail.TabIndex = 0;
            this.dataGridView_detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_detail_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detail Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(180, 252);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kembali";
            // 
            // txt_bayar
            // 
            this.txt_bayar.Location = new System.Drawing.Point(183, 285);
            this.txt_bayar.Name = "txt_bayar";
            this.txt_bayar.Size = new System.Drawing.Size(149, 20);
            this.txt_bayar.TabIndex = 6;
            this.txt_bayar.TextChanged += new System.EventHandler(this.txt_bayar_TextChanged);
            // 
            // lbl_kembali
            // 
            this.lbl_kembali.AutoSize = true;
            this.lbl_kembali.Location = new System.Drawing.Point(180, 326);
            this.lbl_kembali.Name = "lbl_kembali";
            this.lbl_kembali.Size = new System.Drawing.Size(0, 13);
            this.lbl_kembali.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bayar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailbayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_kembali);
            this.Controls.Add(this.txt_bayar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_detail);
            this.Name = "detailbayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detailbayar";
            this.Load += new System.EventHandler(this.detailbayar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bayar;
        private System.Windows.Forms.Label lbl_kembali;
        private System.Windows.Forms.Button button1;
    }
}