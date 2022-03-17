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
using System.IO;
namespace projekakhir
{
    public partial class detailbayar : Form
    {
        int total = 0;
        int kembali = 0;
        DateTime dat = new DateTime();

        public detailbayar()
        {
            InitializeComponent();
        }

        public detailbayar(DataTable data)
        {
            InitializeComponent();
            dataGridView_detail.DataSource = data;
            lbl_kembali.Text = 0 + "";
        }

        private void detailbayar_Load(object sender, EventArgs e)
        {
            dataGridView_detail.ClearSelection();
            for (int i = 0; i < dataGridView_detail.Rows.Count; i++) {
                total += Convert.ToInt32(dataGridView_detail.Rows[i].Cells[4].Value);
            }
            lbl_total.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bayar = Convert.ToInt32(txt_bayar.Text);
            kembali = bayar - total;
            lbl_kembali.Text = kembali.ToString();
            
            if (kembali >= 0)
            {
                login frm = new login();
                admin.Connect();
                int kodeNota;
                SqlCommand cmdKodeNota = new SqlCommand("SELECT TOP 1 kodeNota FROM NOTA ORDER BY kodeNota desc", admin.conn);
                SqlDataReader read = cmdKodeNota.ExecuteReader();
                if (read.Read())
                {
                    kodeNota = int.Parse(read.GetValue(0).ToString());
                }
                else {
                    kodeNota = 0;
                }
                read.Close();

                for (int i = 0; i < dataGridView_detail.Rows.Count; i++) {
                    //memasukkan data dari dataGridView ke variable
                    SqlCommand tblkasir = new SqlCommand("INSERT INTO KASIR(kodeUser,kodeBarang,qty,kodeNota,tgltrans) VALUES(@vkodeUser,@vkodeBarang,@vqty,@vkodeNota,@vtgltrans)", admin.conn);

                    string kodeUser = login.user;
                    string kdBarang = dataGridView_detail.Rows[i].Cells[1].Value.ToString();
                    int idxx = kdBarang.IndexOf("-");
                    int kodeBarang = int.Parse(kdBarang.Substring(0, idxx));
                    int qty = Int32.Parse(dataGridView_detail.Rows[i].Cells[3].Value.ToString());
                    tblkasir.Parameters.AddWithValue("@vkodeUser", kodeUser);
                    tblkasir.Parameters.AddWithValue("@vkodeBarang", kodeBarang);
                    tblkasir.Parameters.AddWithValue("@vqty", qty);
                    tblkasir.Parameters.AddWithValue("@vkodeNota", kodeNota+1);
                    tblkasir.Parameters.AddWithValue("@vtgltrans", kasir.tgltrans);
                   
                    tblkasir.ExecuteNonQuery();

                    //UNTUK UPDATE STOK DI INVENTARIS
                    SqlCommand cmdRead = new SqlCommand("select stok from invent where kodebarang = @VKODEBARANG", admin.conn);
                    cmdRead.Parameters.AddWithValue("@VKODEBARANG", kodeBarang);
                    SqlDataReader rd = cmdRead.ExecuteReader();
                    int stokSementara = 0;
                    if (rd.Read())
                    {
                        stokSementara = int.Parse(rd.GetValue(0).ToString());
                        stokSementara = stokSementara - qty;
                    }
                    rd.Close();

                    SqlCommand cmd = new SqlCommand("update invent set stok = @VSTOK where kodeBarang = @VKODEBARANG;", admin.conn);
                    cmd.Parameters.AddWithValue("@VSTOK", stokSementara);
                    cmd.Parameters.AddWithValue("@VKODEBARANG", kodeBarang);
                    cmd.ExecuteNonQuery();

                    admin.conn.Close();

                    //UNTUK INSERT BARANG OUT DI TABEL
                    admin.Connect();
                    SqlCommand cmdBout = new SqlCommand("INSERT INTO BARANGOUT(KODEBARANG,JUMLAH,TGLKELUAR) VALUES (@VKODEBARANG,@VJUMLAH,@VTGLKELUAR)", admin.conn);

                    cmdBout.Parameters.AddWithValue("@VKODEBARANG", kodeBarang);
                    cmdBout.Parameters.AddWithValue("@VJUMLAH", qty);
                    dat = DateTime.Now;
                    cmdBout.Parameters.AddWithValue("@VTGLKELUAR", dat);
                    cmdBout.ExecuteNonQuery();
                }
                SqlCommand tblnota = new SqlCommand("INSERT INTO NOTA(kodeNota,total,bayar,kembali,tgltrans) VALUES(@vkodeNota,@vtotal,@vbayar,@vkembali,@vtgltransnota)", admin.conn);

                tblnota.Parameters.AddWithValue("@vkodeNota", kodeNota + 1);
                tblnota.Parameters.AddWithValue("@vtotal", int.Parse(lbl_total.Text));
                tblnota.Parameters.AddWithValue("@vbayar", int.Parse(txt_bayar.Text));
                tblnota.Parameters.AddWithValue("@vkembali", int.Parse(lbl_kembali.Text));
                tblnota.Parameters.AddWithValue("@vtgltransnota", kasir.tgltrans);
                tblnota.ExecuteNonQuery();
                FormCrystalReportNota.kodeNota = kodeNota+1;
                MessageBox.Show("Transaksi Berhasil!");
                admin.conn.Close();

                //UNTUK REPORT
                FormCrystalReportNota frmNota = new FormCrystalReportNota();
                frmNota.ShowDialog();

                kasir frmm = new kasir();
                frmm.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Maaf, pembayaran anda kurang!", "Gagal Bayar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_bayar.Text = "";
                lbl_kembali.Text = 0+"";
            }
        }

        private void txt_bayar_TextChanged(object sender, EventArgs e)
        {
            int bayar = 0;
            int tempBayar = 0;
            if (txt_bayar.Text != "")
            {
                tempBayar = int.Parse(txt_bayar.Text);
            }


            if (txt_bayar.Text == "" || int.Parse(txt_bayar.Text) < total)
            {
                lbl_kembali.Text = "Pembayaran Kurang";
            }
            else
            {
                bayar = Convert.ToInt32(txt_bayar.Text);
            }

            if (bayar >= total)
            {
                kembali = bayar - total;
                lbl_kembali.Text = kembali.ToString();
            }
        }

        private void dataGridView_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
