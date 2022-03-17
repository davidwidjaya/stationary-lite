namespace projekakhir
{
    partial class FormLapNota
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gridViewDetail = new System.Windows.Forms.DataGridView();
            this.clmnKodeNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnKembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTglTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date :";
            // 
            // timeFrom
            // 
            this.timeFrom.Location = new System.Drawing.Point(78, 20);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(142, 20);
            this.timeFrom.TabIndex = 2;
            // 
            // timeTo
            // 
            this.timeTo.Location = new System.Drawing.Point(320, 20);
            this.timeTo.Name = "timeTo";
            this.timeTo.Size = new System.Drawing.Size(142, 20);
            this.timeTo.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(483, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnKodeNota,
            this.clmnTotal,
            this.clmnBayar,
            this.clmnKembali,
            this.clmnTglTrans});
            this.gridViewDetail.Location = new System.Drawing.Point(12, 48);
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDetail.Size = new System.Drawing.Size(776, 294);
            this.gridViewDetail.TabIndex = 5;
            this.gridViewDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDetail_CellDoubleClick);
            // 
            // clmnKodeNota
            // 
            this.clmnKodeNota.DataPropertyName = "kodeNota";
            this.clmnKodeNota.HeaderText = "Kode Nota";
            this.clmnKodeNota.Name = "clmnKodeNota";
            // 
            // clmnTotal
            // 
            this.clmnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTotal.DataPropertyName = "total";
            this.clmnTotal.HeaderText = "Total";
            this.clmnTotal.Name = "clmnTotal";
            // 
            // clmnBayar
            // 
            this.clmnBayar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnBayar.DataPropertyName = "bayar";
            this.clmnBayar.HeaderText = "Bayar";
            this.clmnBayar.Name = "clmnBayar";
            // 
            // clmnKembali
            // 
            this.clmnKembali.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnKembali.DataPropertyName = "kembali";
            this.clmnKembali.HeaderText = "Kembalian";
            this.clmnKembali.Name = "clmnKembali";
            // 
            // clmnTglTrans
            // 
            this.clmnTglTrans.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTglTrans.DataPropertyName = "tglTrans";
            this.clmnTglTrans.HeaderText = "Tgl Trans.";
            this.clmnTglTrans.Name = "clmnTglTrans";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(713, 348);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormLapNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridViewDetail);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.timeTo);
            this.Controls.Add(this.timeFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLapNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Lap_Nota";
            this.Load += new System.EventHandler(this.FormLapNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.DateTimePicker timeTo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView gridViewDetail;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnKodeNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnKembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTglTrans;
    }
}