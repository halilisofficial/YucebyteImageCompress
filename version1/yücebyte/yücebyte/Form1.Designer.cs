namespace yücebyte
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIndirildi = new System.Windows.Forms.Label();
            this.trckBroKalite = new System.Windows.Forms.TrackBar();
            this.lblKalite = new System.Windows.Forms.Label();
            this.lblkaliteGoster = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBroKalite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(653, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Sıkıştır";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 399);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Resim ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBrowser_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(53, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 343);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnBrowser_click);
            // 
            // lblIndirildi
            // 
            this.lblIndirildi.AutoSize = true;
            this.lblIndirildi.ForeColor = System.Drawing.Color.DarkGray;
            this.lblIndirildi.Location = new System.Drawing.Point(684, 480);
            this.lblIndirildi.Name = "lblIndirildi";
            this.lblIndirildi.Size = new System.Drawing.Size(52, 17);
            this.lblIndirildi.TabIndex = 4;
            this.lblIndirildi.Text = "İndirildi";
            // 
            // trckBroKalite
            // 
            this.trckBroKalite.Location = new System.Drawing.Point(53, 441);
            this.trckBroKalite.Maximum = 100;
            this.trckBroKalite.Name = "trckBroKalite";
            this.trckBroKalite.Size = new System.Drawing.Size(486, 56);
            this.trckBroKalite.TabIndex = 5;
            this.trckBroKalite.Scroll += new System.EventHandler(this.trckBroKalite_Scroll);
            // 
            // lblKalite
            // 
            this.lblKalite.AutoSize = true;
            this.lblKalite.Location = new System.Drawing.Point(62, 410);
            this.lblKalite.Name = "lblKalite";
            this.lblKalite.Size = new System.Drawing.Size(117, 17);
            this.lblKalite.TabIndex = 6;
            this.lblKalite.Text = "Sıkıştırma Kalitesi";
            // 
            // lblkaliteGoster
            // 
            this.lblkaliteGoster.AutoSize = true;
            this.lblkaliteGoster.Location = new System.Drawing.Point(491, 410);
            this.lblkaliteGoster.Name = "lblkaliteGoster";
            this.lblkaliteGoster.Size = new System.Drawing.Size(16, 17);
            this.lblkaliteGoster.TabIndex = 7;
            this.lblkaliteGoster.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(825, 532);
            this.Controls.Add(this.lblkaliteGoster);
            this.Controls.Add(this.lblKalite);
            this.Controls.Add(this.trckBroKalite);
            this.Controls.Add(this.lblIndirildi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Yücebyte Compress";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBroKalite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIndirildi;
        private System.Windows.Forms.TrackBar trckBroKalite;
        private System.Windows.Forms.Label lblKalite;
        private System.Windows.Forms.Label lblkaliteGoster;
    }
}

