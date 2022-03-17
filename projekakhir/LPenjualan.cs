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
    public partial class LPenjualan : Form
    {
        DataSetBarangKeluar ds;

        public LPenjualan()
        {
            InitializeComponent();
            admin.conn = null;
        }

        private void LPenjualan_Load(object sender, EventArgs e)
        {
            admin.Connect();

            ds = new DataSetBarangKeluar();
            SqlDataAdapter da = new SqlDataAdapter("select * from BARANGIN", admin.conn);
            da.Fill(ds, "BARANGIN");

            //menampilkan data didalam combobox
            cmb_namaBarang.DataSource = ds.Tables[0];
            cmb_namaBarang.DisplayMember = "namaBarang";
            cmb_namaBarang.ValueMember = "kodeBarang";

            cmb_namaBarang.SelectedIndex = 0;
            string kodeBarang = cmb_namaBarang.SelectedValue.ToString();

            CrystalReportBarangKeluar cr = new CrystalReportBarangKeluar();
            //DateTime sourceFrom = dateFrom.Value;
            //String resultFrom = sourceFrom.ToString("dd/mm/yyyy HH:mm:ss");
            //DateTime sourceTo = dateFrom.Value;
            //String resultTo = sourceTo.ToString("dd/mm/yyyy HH:mm:ss");
            //da = new SqlDataAdapter("select * from BARANGOUT WHERE tglKeluar BETWEEN '" + resultFrom + "' AND '" + resultTo + "'", admin.conn);
            da = new SqlDataAdapter("select * from BARANGOUT", admin.conn);
            da.Fill(ds, "BARANGOUT");
            admin.conn.Close();
            cr.SetDataSource(ds);
            cr.SetParameterValue("kodeBarang", kodeBarang);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Show();

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kodeBarang = cmb_namaBarang.SelectedValue.ToString();
            //MessageBox.Show(kodeBarang);
            CrystalReportBarangKeluar cr = new CrystalReportBarangKeluar();

            cr.SetDataSource(ds);
            cr.SetParameterValue("kodeBarang", kodeBarang);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Show();
        }
    }
}
