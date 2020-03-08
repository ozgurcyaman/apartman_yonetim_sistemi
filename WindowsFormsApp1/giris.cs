using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void monoFlat_TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.No)
            {
                
            }
            if (mesaj == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            
            yonetici yeni = new yonetici();
            yeni.Show();
            this.Hide();
              
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            kullanici x = new kullanici();
            x.Show();
            this.Hide();

        }
    }
}
