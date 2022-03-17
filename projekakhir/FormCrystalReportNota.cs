using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projekakhir
{
    public partial class FormCrystalReportNota : Form
    {
        public FormCrystalReportNota()
        {
            InitializeComponent();
        }

        public static int kodeNota = 0;

        private void FormCrystalReportNota_Load(object sender, EventArgs e)
        {
            DataSetNota dsnota = new DataSetNota();
            admin.Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM INVENT",admin.conn);
            da.Fill(dsnota,"INVENT");
            da = new SqlDataAdapter("SELECT * FROM KASIR", admin.conn);
            da.Fill(dsnota, "KASIR");
            da = new SqlDataAdapter("SELECT * FROM NOTA", admin.conn);
            da.Fill(dsnota, "NOTA");

            CrystalReportNota crNota = new CrystalReportNota();
            crNota.SetDataSource(dsnota);
            crNota.SetParameterValue("kodeNota", kodeNota);
            crystalReportViewerNota.ReportSource = crNota;
            crystalReportViewerNota.Show();
            admin.conn.Close();
        }
    }
}
