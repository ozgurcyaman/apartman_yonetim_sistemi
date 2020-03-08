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
    public partial class kullanicipaneli : Form
    {
        public kullanicipaneli()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|ayss.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void kullanicipaneli_Load(object sender, EventArgs e)
        {
            
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
          



        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {

           
        }

        private void iTalk_Button_21_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From bilgier", baglanti);

            dtst.Clear();
            adtr.Fill(dtst, "bilgier");

            dataGridView1.DataSource = dtst.Tables["bilgier"];
            adtr.Dispose();

            baglanti.Close();

        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giris xx = new giris();
            xx.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
