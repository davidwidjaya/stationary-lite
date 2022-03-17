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
    public partial class Labsensi : Form
    {
        static SqlConnection conn;
        static DataSetAbsen ds;
        public Labsensi()
        {
            InitializeComponent();
        }

        private void Labsensi_Load(object sender, EventArgs e)
        {
            //admin.Connect();
            //DataSet ds = new DataSet();

            //SqlDataAdapter da = new SqlDataAdapter("select  t.* from absen t where t.tglLogin = (select max(tglLogin) from absen i where i.kodeUser = t.kodeUser)",admin.conn);
            //da.Fill(ds, "ABSEN");
            //dataGridView1.DataSource = ds.Tables["ABSEN"];

            ////da = new SqlDataAdapter("SELECT TGLLOGIN FROM ABSEN", conn);
            ////da.Fill(ds, "ABSEN");
            ////dataGridView1.DataSource = ds.Tables["ABSEN"];
            //admin.conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            admin.Connect();
            ds = new DataSetAbsen();
            string dt = dateTimePicker1.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from absen where datediff(day, tglLogin,'" + dt + "') = 0", admin.conn);
            da.Fill(ds, "ABSEN");

            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds.Tables["ABSEN"]);
            crystalReportViewer.ReportSource = cr;
            crystalReportViewer.Show();
            ////tampilkan data di dalam combobox
            //cmbFilterDate.DataSource = ds.Tables["ABSEN"];
            //cmbFilterDate.DisplayMember = "tglLogin";
            //cmbFilterDate.ValueMember = "kodeUser";

            //cmbFilterDate.SelectedIndex = 0;
            //string tgl = cmbFilterDate.SelectedValue.ToString();

            admin.conn.Close();
        }
    }
}
