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
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            

            string ad = adi.Text;
            string sifre = parola.Text;
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|ayss.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admingiris where kadi='" + adi.Text + "' AND sifre='" + parola.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adminpanel f2 = new adminpanel();
                f2.Show();
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
            giris gecc = new giris();
            gecc.Show();
            this.Close();
        }
    }
}
