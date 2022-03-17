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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        public static SqlConnection conn;
        public static void Connect()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\projekakhir\projekakhir\projekakhir\projekakhir\stationalite.mdf;Integrated Security=True");
            conn.Open();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Selamat datang, " + login.user + ".";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            regis frm = new regis();
            frm.ShowDialog();
        }

        private void btnLihatUser_Click(object sender, EventArgs e)
        {
            unreg frm = new unreg();
            frm.ShowDialog();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            laporan frm = new laporan();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Close();
        }
    }
}
