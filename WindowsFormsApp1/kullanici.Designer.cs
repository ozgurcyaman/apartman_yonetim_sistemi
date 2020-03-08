namespace WindowsFormsApp1
{
    partial class kullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici));
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.k_adi = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.k_sifre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(175, 131);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(180, 40);
            this.iTalk_Button_11.TabIndex = 9;
            this.iTalk_Button_11.Text = "Giris";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // k_adi
            // 
            this.k_adi.BackColor = System.Drawing.Color.Transparent;
            this.k_adi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.k_adi.ForeColor = System.Drawing.Color.DimGray;
            this.k_adi.Location = new System.Drawing.Point(175, 34);
            this.k_adi.MaxLength = 32767;
            this.k_adi.Multiline = false;
            this.k_adi.Name = "k_adi";
            this.k_adi.ReadOnly = false;
            this.k_adi.Size = new System.Drawing.Size(180, 33);
            this.k_adi.TabIndex = 7;
            this.k_adi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.k_adi.UseSystemPasswordChar = false;
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(26, 82);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(54, 25);
            this.ambiance_Label2.TabIndex = 6;
            this.ambiance_Label2.Text = "Şifre:";
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(26, 34);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(121, 25);
            this.ambiance_Label1.TabIndex = 5;
            this.ambiance_Label1.Text = "Kullanıcı Adı:";
            // 
            // k_sifre
            // 
            this.k_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.k_sifre.Location = new System.Drawing.Point(175, 86);
            this.k_sifre.MaxLength = 6;
            this.k_sifre.Name = "k_sifre";
            this.k_sifre.PasswordChar = '*';
            this.k_sifre.Size = new System.Drawing.Size(180, 27);
            this.k_sifre.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(437, 27);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 185);
            this.Controls.Add(this.k_sifre);
            this.Controls.Add(this.iTalk_Button_11);
            this.Controls.Add(this.k_adi);
            this.Controls.Add(this.ambiance_Label2);
            this.Controls.Add(this.ambiance_Label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYS | Kullanıcı Girişi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private Ambiance.Ambiance_TextBox k_adi;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private System.Windows.Forms.TextBox k_sifre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
    }
}