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
    public partial class LBarangIN : Form
    {
        static SqlConnection conn;
        DataSetBarangIn ds;
        SqlDataAdapter da;
        string kd = "";

        Boolean cek = false;
        public LBarangIN()
        {
            cek = false;

            InitializeComponent();

            admin.Connect();

            da = new SqlDataAdapter("SELECT * FROM TGL", admin.conn);

            ds = new DataSetBarangIn();
            da.Fill(ds, "TGL");

            comboBox.DataSource = ds.Tables[1];
            comboBox.DisplayMember = "TANGGAL";
            comboBox.ValueMember = "KODETGL";

            comboBox.SelectedIndex = 0;

            CrystalReportBarangIn cr = new CrystalReportBarangIn();
            da = new SqlDataAdapter("SELECT * FROM BARANGIN", admin.conn);

            da.Fill(ds, "BARANGIN");

            admin.conn.Close();

            cr.SetDataSource(ds);
            cr.SetParameterValue("KODETGL", comboBox.SelectedValue.ToString());
            cRV.ReportSource = cr;
            cRV.Show();

            cek = true;
        }

        
        private void comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cek == false) { }
            else
            {
                admin.Connect();

                kd = comboBox.SelectedValue.ToString();

                MessageBox.Show(kd);

                CrystalReportBarangIn cr = new CrystalReportBarangIn();
                da = new SqlDataAdapter("SELECT * FROM BARANGIN", admin.conn);

                da.Fill(ds, "BARANGIN");

                admin.conn.Close();

                cr.SetDataSource(ds);
                cr.SetParameterValue("KODETGL", kd);
                cRV.ReportSource = cr;
                cRV.Show();
            }
        }

        private void LBarangIN_Load(object sender, EventArgs e)
        {

        }
    }
}
