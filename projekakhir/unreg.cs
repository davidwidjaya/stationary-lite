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
    public partial class unreg : Form
    {
        static string kodeUser = "";
        public unreg()
        {
            InitializeComponent();
            admin.conn = null;
        }

        private void unreg_Load(object sender, EventArgs e)
        {
            admin.Connect();
            DataSet ds = new DataSet();

//            SqlDataAdapter da = new SqlDataAdapter("select  t.* from absen t where t.tglLogin = (select max(tglLogin) from absen i where i.kodeUser = t.kodeUser)", conn);
            SqlDataAdapter da = new SqlDataAdapter("select kodeuser, username,golongan from users", admin.conn);
            da.Fill(ds, "USERS");
            dataGridView1.DataSource = ds.Tables["USERS"];

            //da = new SqlDataAdapter("SELECT TGLLOGIN FROM ABSEN", conn);
            //da.Fill(ds, "ABSEN");
            //dataGridView1.DataSource = ds.Tables["ABSEN"];
            admin.conn.Close();
        }

        private void btnUnreg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda akan menghapus seluruh data user ini. Apakah anda yakin?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                admin.Connect();
                SqlCommand cmd = new SqlCommand("DELETE FROM USERS WHERE KODEUSER = @VKODEUSER", admin.conn);
                cmd.Parameters.AddWithValue("@VKODEUSER", kodeUser);
                cmd.ExecuteNonQuery();
                admin.conn.Close();
                DialogResult = MessageBox.Show("Berhasil");
                unreg ug = new unreg();
                ug.ShowDialog();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int idx = e.RowIndex;

            ////memasukkan data dari dataGridView ke variable
            //kodeUser = dataGridView1.Rows[idx].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = e.RowIndex;

            //memasukkan data dari dataGridView ke variable
            kodeUser = dataGridView1.Rows[idx].Cells[0].Value.ToString();
        }
    }
}
