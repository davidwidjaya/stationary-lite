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
    public partial class inventaris : Form
    {
        static DateTime dat;

        string tKode = "";
        string kod = "-";
        string nam;
        string har;
        string sto;
        string tglKode = "";


        static SqlConnection conn;
        public inventaris()
        {
            InitializeComponent();
            cariKodeTGL();
        }

        public void refresh()
        {
            txtHargaBarang.Text = "";
            txtNamaBarang.Text = "";
            txtStokBarang.Text = "";
        }

        public void update()
        {
            admin.Connect();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM INVENT", admin.conn);

            da.Fill(ds, "INVENT");
            dataGridView1.DataSource = ds.Tables["INVENT"];

            admin.conn.Close();
        }

        public int cekKdB()
        {
            tKode = "";

            admin.Connect();

            SqlCommand cmd = new SqlCommand("SELECT KODEBARANG FROM BARANGIN", admin.conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tKode = reader.GetValue(0) + "";
            }

            reader.Close();
            admin.conn.Close();

            if (tKode == "")
            {
                return 1;
            }
            else
            {
                return int.Parse(tKode);
            }
        }

        private void Inventaris_Load(object sender, EventArgs e)
        {
            update();
        }

        public string cariKodeTGL()
        {
            admin.Connect();

            string tgl = DateTime.Now.ToString("MM" + "/" + "dd" + "/" + "yyyy");
            //string tgl = "12/11/2019";

            SqlCommand cmd = new SqlCommand("SELECT kodeTGL From TGL WHERE TANGGAL = @tgl", admin.conn);
            cmd.Parameters.AddWithValue("@tgl", tgl);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tglKode = reader.GetValue(0) + "";
            }
            reader.Close();
            tglKode = tglKode + "";

            if (!tglKode.Equals(""))
            {
                return tglKode;
            }
            else
            {
                admin.conn.Close();
                admin.Connect();

                SqlCommand cmd2 = new SqlCommand("INSERT INTO TGL(Tanggal) values(@tgl)", admin.conn);
                cmd2.Parameters.AddWithValue("@tgl", tgl);

                cmd2.ExecuteNonQuery();
                return cariKodeTGL();
            }
        }

        private void BtnTambahBarang_Click(object sender, EventArgs e)
        {
            string nmB = txtNamaBarang.Text;
            string st = txtStokBarang.Text;
            string hr = txtHargaBarang.Text;

            refresh();

            admin.Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO BARANGIN(NAMABARANG,STOK,kodeTGL) VALUES (@NAMABARANG,@STOK,@KDTGL)", admin.conn);

            cmd.Parameters.AddWithValue("@NAMABARANG", nmB);
            cmd.Parameters.AddWithValue("@STOK", st);

            string kTgl = cariKodeTGL();

            cmd.Parameters.AddWithValue("@KDTGL", kTgl);

            cmd.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("INSERT INTO INVENT(KODEBARANG, NAMABARANG, HARGABARANG, STOK, TGLMASUK) VALUES (@KODEBARANG, @NAMABARANG, @HARGABARANG, @STOK, @TGLMASUK)", admin.conn);

            cmd3.Parameters.AddWithValue("@KODEBARANG", cekKdB());
            cmd3.Parameters.AddWithValue("@NAMABARANG", nmB);
            cmd3.Parameters.AddWithValue("@HARGABARANG", hr);
            cmd3.Parameters.AddWithValue("@STOK", st);

            dat = DateTime.Now;
            cmd3.Parameters.AddWithValue("@TGLMASUK", dat);

            cmd3.ExecuteNonQuery();

            update();
            admin.conn.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!kod.Equals("-"))
            {
                string nmB = txtNamaBarang.Text;
                string st = txtStokBarang.Text;
                string hr = txtHargaBarang.Text;

                admin.Connect();

                SqlCommand cmd = new SqlCommand("UPDATE INVENT SET NAMABARANG = @NMB, HARGABARANG = @HRB, STOK = @STK, TGLMASUK = @KTG WHERE KODEBARANG = @KDBA", admin.conn);

                cmd.Parameters.AddWithValue("@NMB", nmB);
                cmd.Parameters.AddWithValue("@STK", st);
                cmd.Parameters.AddWithValue("@HRB", hr);

                string datee = cariKodeTGL();
                cmd.Parameters.AddWithValue("@KTG", datee);
                cmd.Parameters.AddWithValue("@KDBA", kod);

                cmd.ExecuteNonQuery();
                admin.conn.Close();

                refresh();
                update();

                kod = "-";
            }
            else
            {
                MessageBox.Show("Silahkan pilih item terlebih dahulu!");
            }
        }

        private void BtnDeleteBarang_Click(object sender, EventArgs e)
        {
            if (!kod.Equals("-"))
            {
                admin.Connect();

                SqlCommand cmd = new SqlCommand("DELETE FROM INVENT WHERE KODEBARANG = @KDBA", admin.conn);
                cmd.Parameters.AddWithValue("@KDBA", kod);

                cmd.ExecuteNonQuery();
                admin.conn.Close();

                refresh();
                update();

                kod = "-";
            }
            else
            {
                MessageBox.Show("Silahkan pilih item terlebih dahulu!");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = e.RowIndex;

            //memasukkan data dari dataGridView ke variable
            kod = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            nam = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            har = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            sto = dataGridView1.Rows[idx].Cells[3].Value.ToString();

            txtNamaBarang.Text = nam;
            txtHargaBarang.Text = har;
            txtStokBarang.Text = sto;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Close();
        }
    }
}
