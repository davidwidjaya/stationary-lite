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
    public partial class kasir : Form
    {
        public static string tgltrans = "";
        public static int ctr = 0;
        static DataTable dt = new DataTable();
        static DataRow dr = dt.NewRow();
        int index = -1;
        int maxQty = 0;

        public kasir()
        {
            InitializeComponent();
            admin.conn = null;
            dt.Clear();
            dt = new DataTable();
            dt.Columns.Add("No.");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Jumlah");
            gridView_Kasir.DataSource = dt;
        }

        private void refresh_form()
        {
            cmbBarang.Items.Clear();
            numericQty.Value = 0;
            txtJumlah.Text = null;
            lblTanggal.Enabled = false;
            lblTimer.Enabled = false;
            txtJumlah.Enabled = false;
            timerWaktu.Start();
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            lblTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy");

            //for combo box "Barang"
            admin.Connect();
            SqlCommand cmd = new SqlCommand("SELECT kodeBarang,namaBARANG FROM INVENT", admin.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbBarang.Items.Add(reader.GetValue(0) + "-" + reader.GetValue(1));
            }
            reader.Close();
            admin.conn.Close();


        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            ctr++;
            int harga = Int32.Parse(txtHarga.Text);
            int qty = Convert.ToInt32(numericQty.Value);
            int jumlah = 0;
            if (txtJumlah.Text != "")
            {
                jumlah = Int32.Parse(txtJumlah.Text);
            }

            if (cmbBarang.Text != "" && qty > 0 && jumlah > 0 && harga > 0)
            {
                DataRow dr = dt.NewRow();
                dr[0] = ctr;
                dr[1] = cmbBarang.Text.ToString();
                dr[2] = txtHarga.Text;
                dr[3] = numericQty.Value;
                dr[4] = jumlah;
                dt.Rows.Add(dr);
                gridView_Kasir.DataSource = dt;
            }
            else {
                MessageBox.Show("Stok barang habis!");
            }
            maxQty = maxQty - qty;
            numericQty.Maximum = maxQty;
            txtHarga.Text = "0";
            refresh_form();
        }

        private void cmbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
//            maxQty = 0;
            //if there's change in cmb barang, so the price will be change too
            string namaBarang = cmbBarang.Text;
            int kodeBarang = Int32.Parse(namaBarang.Substring(0, namaBarang.IndexOf("-")));

            admin.Connect();
            SqlCommand cmd = new SqlCommand("SELECT hargaBarang,stok FROM INVENT WHERE kodeBarang=@VKODE", admin.conn);
            cmd.Parameters.AddWithValue("@VKODE",kodeBarang);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtHarga.Text = reader.GetValue(0).ToString();
            maxQty = Int32.Parse(reader.GetValue(1).ToString());
            numericQty.Maximum = maxQty;
            reader.Close();
            admin.conn.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            index = gridView_Kasir.CurrentRow.Index;
            int tempMinJum = int.Parse(gridView_Kasir.Rows[index].Cells[3].Value.ToString());
            MessageBox.Show(tempMinJum + "");

            if (index>=0) {
                gridView_Kasir.Rows.RemoveAt(index);
            }
            maxQty = maxQty + tempMinJum;
            refresh_form();
        }

        private void kasir_Load(object sender, EventArgs e)
        {
            refresh_form();
        }

        private void timerWaktu_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            lblTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy");
            tgltrans = DateTime.Now.ToString();
        }

        private void numericQty_ValueChanged(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(numericQty.Value);
            if (qty > 0)
            {
                int harga = Int32.Parse(txtHarga.Text);
                int jumlah = harga * qty;
                txtJumlah.Text = jumlah + "";
            }
        }

        private void btnLakukanPembayaran_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda tidak dapat melakukan perubahan data setelah ini. Apakah anda yakin?", "Warning",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                detailbayar frm = new detailbayar(dt);
                frm.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Close();
        }
    }
}
