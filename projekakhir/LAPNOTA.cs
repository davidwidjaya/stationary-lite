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
    public partial class FormLapNota : Form
    {
        public FormLapNota()
        {
            InitializeComponent();
            admin.Connect();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            admin.Connect();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NOTA WHERE tglTrans BETWEEN '" + timeFrom.Value + "' AND '" + timeTo.Value + "'", admin.conn);
            da.Fill(ds, "NOTA");
            gridViewDetail.DataSource = ds.Tables["NOTA"];
            admin.conn.Close();
        }


        private void gridViewDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            int kodeNota = Int32.Parse(gridViewDetail.Rows[idx].Cells[0].Value.ToString());
            FormCrystalReportNota.kodeNota = kodeNota;
            FormCrystalReportNota frmnota = new FormCrystalReportNota();
            frmnota.ShowDialog();
        }

        private void FormLapNota_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormCrystalReportNota frmnota = new FormCrystalReportNota();
            frmnota.ShowDialog();
        }
    }
}
