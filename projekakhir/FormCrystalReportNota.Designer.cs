namespace projekakhir
{
    partial class FormCrystalReportNota
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
            this.crystalReportViewerNota = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerNota
            // 
            this.crystalReportViewerNota.ActiveViewIndex = -1;
            this.crystalReportViewerNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerNota.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerNota.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerNota.Name = "crystalReportViewerNota";
            this.crystalReportViewerNota.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerNota.TabIndex = 0;
            // 
            // FormCrystalReportNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerNota);
            this.Name = "FormCrystalReportNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCrystalReportNota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCrystalReportNota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerNota;
    }
}