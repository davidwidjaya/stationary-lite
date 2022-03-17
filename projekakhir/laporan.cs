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
    public partial class laporan : Form
    {
        public laporan()
        {
            InitializeComponent();
        }

        private void btnLaporAbsensi_Click(object sender, EventArgs e)
        {
            Labsensi frm = new Labsensi();
            frm.ShowDialog();
        }

        private void btnLaporPenjualan_Click(object sender, EventArgs e)
        {
            LPenjualan frm = new LPenjualan();
            frm.ShowDialog();
        }

        private void btnLaporBMasuk_Click(object sender, EventArgs e)
        {
            LBarangIN frm = new LBarangIN();
            frm.ShowDialog();
        }

        private void btnLaporMasterBarang_Click(object sender, EventArgs e)
        {
            LMasterBarang frm = new LMasterBarang();
            frm.ShowDialog();
        }

        private void btnLaporBKeluar_Click(object sender, EventArgs e)
        {
            FormLapNota frmNota = new FormLapNota();
            frmNota.ShowDialog();
        }

        private void laporan_Load(object sender, EventArgs e)
        {

        }
    }
}
