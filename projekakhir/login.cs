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
    public partial class login : Form
    {
        public static string user = "";
        public static string password = "";
        public static Boolean founded = false;
        static DateTime dt;
        static string kodeUser;
        static string cekKodeUser;
        static string cekUser;
        static string cekPass;
        static SqlConnection conn;
        public static string kode_kasir = "";
        public static Boolean cekKetemuAbsen = false;
        static string dateHour;
        static int dateHourInt;
        static string dateMenit;

        public login()
        {
            InitializeComponent();
            txtUsername.Focus();
            dateHour = DateTime.Now.Hour.ToString();
            dateHourInt = int.Parse(dateHour);
            dateMenit = DateTime.Now.Minute.ToString();
//            MessageBox.Show(dateHour);

            admin.Connect();
            if (dateHourInt >= 17)
            {
                dt = DateTime.Now;
                DataSet dsAbsen = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select u.kodeUser, max(a.tglLogin) from ABSEN a, USERS u where datediff(day, a.tglLogin, '12/10/2019') = 0 and u.kodeUser = a.kodeUser group by u.kodeUser having MAX(a.tglLogin) > 0", admin.conn);
                da.Fill(dsAbsen, "ABSEN");
                DataSet dsUser = new DataSet();
                SqlDataAdapter da2 = new SqlDataAdapter("select kodeUser from USERS", admin.conn);
                da2.Fill(dsUser, "USERS");
                for (int i = 0; i < dsUser.Tables[0].Rows.Count; i++)
                {
                    //MessageBox.Show(dsUser.Tables[0].Rows[i]["kodeUser"].ToString() + " isi di users");

                    for (int j = 0; j < dsAbsen.Tables[0].Rows.Count; j++)
                    {
                        if (dsUser.Tables[0].Rows[i]["kodeUser"].ToString().Equals(dsAbsen.Tables[0].Rows[j]["kodeUser"].ToString()))
                        {
                            cekKetemuAbsen = true;
                            j = dsAbsen.Tables[0].Rows.Count;
                        }
                        else if (j == dsAbsen.Tables[0].Rows.Count - 1 && cekKetemuAbsen == false)
                        {
                            string addNUllAbsen = dsUser.Tables[0].Rows[i]["kodeUser"].ToString();
                            //MessageBox.Show("Tambahkan user " + dsUser.Tables[0].Rows[i]["kodeUser"].ToString() + " ke tabel absen dengan tgl NULL.");
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO ABSEN(KODEUSER, TGLLOGIN) VALUES (@VKODEUSER, @VTGLLOGIN)", admin.conn);
                            cmd2.Parameters.AddWithValue("@VKODEUSER", addNUllAbsen);
                            cmd2.Parameters.AddWithValue("@VTGLLOGIN", dt);

                            cmd2.ExecuteNonQuery();
                        }
                    }
                    cekKetemuAbsen = false;
                }
            }
            admin.conn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dateHour = DateTime.Now.Hour.ToString();
            dateHourInt = int.Parse(dateHour);
            dateMenit = DateTime.Now.Minute.ToString();
//            MessageBox.Show(dateHour);
            if (dateHourInt > 1)
            {
                user = txtUsername.Text;
                password = txtPassword.Text;

                admin.Connect();
                SqlCommand cmd = new SqlCommand("SELECT KODEUSER,USERNAME,PASSWORD FROM USERS", admin.conn);
                SqlCommand cmd2 = new SqlCommand("INSERT INTO ABSEN(KODEUSER, TGLLOGIN) VALUES (@VKODEUSER, @VTGLLOGIN)", admin.conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    kodeUser = rd.GetValue(0).ToString();
                    cekUser = rd.GetValue(1).ToString();
                    cekPass = rd.GetValue(2).ToString();
                    dt = DateTime.Now;

                    if (cekUser.Equals(user) && cekPass.Equals(password))
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        if (kodeUser.Substring(0, 1).Equals("1"))
                        {
                            kode_kasir = kodeUser;
                            admin frm = new admin();
                            frm.ShowDialog();
                        }
                        else if (kodeUser.Substring(0, 1).Equals("2"))
                        {
                            kode_kasir = kodeUser;
                            inventaris frm = new inventaris();
                            frm.ShowDialog();
                        }
                        else if (kodeUser.Substring(0, 1).Equals("3"))
                        {
                            kode_kasir = kodeUser;
                            kasir frm = new kasir();
                            frm.ShowDialog();
                        }

                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        labelError.Visible = false;
                        cekKodeUser = kodeUser;
                        founded = true;
                    }
                }
                rd.Close();

                if (founded == false)
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    labelError.Visible = true;
                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    founded = false;
                    admin.conn.Close();
                    admin.conn.Open();

                    cmd2.Parameters.AddWithValue("@VKODEUSER", cekKodeUser);
                    cmd2.Parameters.AddWithValue("@VTGLLOGIN", dt);

                    cmd2.ExecuteNonQuery();
                }
                admin.conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
