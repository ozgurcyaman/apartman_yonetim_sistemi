namespace WindowsFormsApp1
{
    partial class yonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetici));
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.adi = new Ambiance.Ambiance_TextBox();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.parola = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(28, 36);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(121, 25);
            this.ambiance_Label1.TabIndex = 0;
            this.ambiance_Label1.Text = "Kullanıcı Adı:";
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(28, 84);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(54, 25);
            this.ambiance_Label2.TabIndex = 1;
            this.ambiance_Label2.Text = "Şifre:";
            // 
            // adi
            // 
            this.adi.BackColor = System.Drawing.Color.Transparent;
            this.adi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.adi.ForeColor = System.Drawing.Color.DimGray;
            this.adi.Location = new System.Drawing.Point(177, 36);
            this.adi.MaxLength = 32767;
            this.adi.Multiline = false;
            this.adi.Name = "adi";
            this.adi.ReadOnly = false;
            this.adi.Size = new System.Drawing.Size(180, 33);
            this.adi.TabIndex = 2;
            this.adi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.adi.UseSystemPasswordChar = false;
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(177, 133);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(180, 40);
            this.iTalk_Button_11.TabIndex = 4;
            this.iTalk_Button_11.Text = "Giris";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola.Location = new System.Drawing.Point(177, 88);
            this.parola.MaxLength = 6;
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(180, 27);
            this.parola.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(437, 27);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 185);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.iTalk_Button_11);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.ambiance_Label2);
            this.Controls.Add(this.ambiance_Label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYS | Yönetici Girişi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_TextBox adi;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
    }
}