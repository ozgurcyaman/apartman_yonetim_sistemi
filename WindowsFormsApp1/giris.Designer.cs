namespace WindowsFormsApp1
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.ambiance_Button_21 = new Ambiance.Ambiance_Button_2();
            this.SuspendLayout();
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(33, 246);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(405, 92);
            this.monoFlat_Button1.TabIndex = 3;
            this.monoFlat_Button1.Text = "Çıkış";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(33, 132);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(405, 92);
            this.iTalk_Button_21.TabIndex = 2;
            this.iTalk_Button_21.Text = "Kullanıcı Girişi";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // ambiance_Button_21
            // 
            this.ambiance_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_Button_21.Image = null;
            this.ambiance_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_21.Location = new System.Drawing.Point(33, 23);
            this.ambiance_Button_21.Name = "ambiance_Button_21";
            this.ambiance_Button_21.Size = new System.Drawing.Size(405, 92);
            this.ambiance_Button_21.TabIndex = 0;
            this.ambiance_Button_21.Text = "Yönetici Girişi";
            this.ambiance_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_21.Click += new System.EventHandler(this.ambiance_Button_21_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.monoFlat_Button1);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.ambiance_Button_21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYS | Giris Sayfasi";
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_Button_2 ambiance_Button_21;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
    }
}

