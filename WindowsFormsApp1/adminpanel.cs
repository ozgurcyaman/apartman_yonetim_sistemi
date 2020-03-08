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
    public partial class adminpanel : Form
    {
        
        public adminpanel()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
    
        void KisiListele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|ayss.mdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From bilgier", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }
        private void adminpanel_Load(object sender, EventArgs e)
        {
            KisiListele();

        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                isim.Text = row.Cells["ad"].Value.ToString();
                soyisim.Text = row.Cells["soyad"].Value.ToString();
                dno.Text = row.Cells["daire_no"].Value.ToString();
                borc.Text = row.Cells["borc"].Value.ToString();
                
            }

        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {

            string sorgu = "Update bilgier Set ad=@ad,soyad=@soyad,daire_no=@daire_no Where borc=@borc";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", isim.Text);
            komut.Parameters.AddWithValue("@soyad", soyisim.Text);
            komut.Parameters.AddWithValue("@daire_no", dno.Text);
            komut.Parameters.AddWithValue("@borc", Convert.ToInt32(borc.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        private void ansaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giris yenii = new giris();
            yenii.Show();
            this.Close();

        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            
            string ekle = "insert into bilgier(ad,soyad,daire_no,borc) values (@ad,@soyad,@daire_no,@borc)";
            komut = new OleDbCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@ad", isim.Text);
            komut.Parameters.AddWithValue("@soyad", soyisim.Text);
            komut.Parameters.AddWithValue("@daire_no", dno.Text);
            komut.Parameters.AddWithValue("@borc", borc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
            MessageBox.Show("Kayıt Eklenmiştir");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("delete from bilgier where ad='" + dataGridView1.CurrentRow.Cells["ad"].Value + "'", baglanti);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                KisiListele();
            }
            else MessageBox.Show("Silme İptal Edildi");

        }

        private void adminpanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

}
    
