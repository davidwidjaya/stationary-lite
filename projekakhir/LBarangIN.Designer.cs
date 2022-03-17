namespace projekakhir
{
    partial class LBarangIN
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
            this.cRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cRV
            // 
            this.cRV.ActiveViewIndex = -1;
            this.cRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRV.Location = new System.Drawing.Point(0, 0);
            this.cRV.Name = "cRV";
            this.cRV.Size = new System.Drawing.Size(778, 375);
            this.cRV.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(484, 5);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged_1);
            // 
            // LBarangIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 375);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.cRV);
            this.Name = "LBarangIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBarangIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LBarangIN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRV;
        private System.Windows.Forms.ComboBox comboBox;
    }
}