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
    public partial class LMasterBarang : Form
    {
        static SqlConnection conn;
        
        public LMasterBarang()
        {
            InitializeComponent();
        }

        private void LMasterBarang_Load(object sender, EventArgs e)
        {
            admin.Connect();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM INVENT", admin.conn);
            DataSetMasterBarang ds = new DataSetMasterBarang();

            da.Fill(ds, "INVENT");

            admin.conn.Close();

            CrystalReportMasterBarang cr = new CrystalReportMasterBarang();

            cr.SetDataSource(ds);

            cRV.ReportSource = cr;

            cRV.Show();
        }

        private void cRV_Load(object sender, EventArgs e)
        {

        }
    }
}
