using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {

            string ad = k_adi.Text;
            string sifre = k_sifre.Text;
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|ayss.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanicigiris where kullanici='" + k_adi.Text + "' AND sifree='" + k_sifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kullanicipaneli f3 = new kullanicipaneli();
                f3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();


        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giris gec = new giris();
            gec.Show();
            this.Close();
        }
    }
}
