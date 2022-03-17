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
    public partial class regis : Form
    {
        static string kodeuser = "";
        static string username = "";
        static string password = "";
        static int golongan = 0;

        public regis()
        {
            InitializeComponent();
            admin.conn = null;
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            golongan = Int32.Parse(comboGol.SelectedItem.ToString().Substring(0,1));
            kodeuser = golongan + username;

            txtUsername.Text = "";
            txtPassword.Text = "";

            admin.Connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO USERS(KODEUSER,USERNAME,PASSWORD,GOLONGAN) VALUES (@VKODEUSER,@VUSERNAME,@VPASSWORD,@VGOLONGAN)", admin.conn);
            cmd.Parameters.AddWithValue("@VKODEUSER", kodeuser);
            cmd.Parameters.AddWithValue("@VUSERNAME", username);
            cmd.Parameters.AddWithValue("@VPASSWORD", password);
            cmd.Parameters.AddWithValue("@VGOLONGAN", golongan);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("INSERT INTO ABSEN(KODEUSER) VALUES (@VKODEUSER)", admin.conn);
            cmd.Parameters.AddWithValue("@VKODEUSER", kodeuser);
            cmd.ExecuteNonQuery();
            admin.conn.Close();
            MessageBox.Show("Pendaftaran Berhasil");
        }

        private void regis_Load(object sender, EventArgs e)
        {

        }
    }
}
