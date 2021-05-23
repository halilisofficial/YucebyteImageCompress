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
            this.trckbroBoyut = new System.Windows.Forms.TrackBar();
            this.lblBoyutlandir = new System.Windows.Forms.Label();
            this.lblBoyutDeger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBroKalite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbroBoyut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(769, 441);
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
            this.button2.Location = new System.Drawing.Point(769, 404);
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
            this.lblIndirildi.Location = new System.Drawing.Point(794, 480);
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
            this.lblkaliteGoster.ForeColor = System.Drawing.Color.Red;
            this.lblkaliteGoster.Location = new System.Drawing.Point(491, 410);
            this.lblkaliteGoster.Name = "lblkaliteGoster";
            this.lblkaliteGoster.Size = new System.Drawing.Size(16, 17);
            this.lblkaliteGoster.TabIndex = 7;
            this.lblkaliteGoster.Text = "0";
            // 
            // trckbroBoyut
            // 
            this.trckbroBoyut.LargeChange = 10;
            this.trckbroBoyut.Location = new System.Drawing.Point(790, 68);
            this.trckbroBoyut.Maximum = 100;
            this.trckbroBoyut.Minimum = 10;
            this.trckbroBoyut.Name = "trckbroBoyut";
            this.trckbroBoyut.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckbroBoyut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trckbroBoyut.Size = new System.Drawing.Size(56, 116);
            this.trckbroBoyut.SmallChange = 10;
            this.trckbroBoyut.TabIndex = 5;
            this.trckbroBoyut.TickFrequency = 10;
            this.trckbroBoyut.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trckbroBoyut.Value = 100;
            this.trckbroBoyut.Scroll += new System.EventHandler(this.trckbroBoyut_Scroll);
            // 
            // lblBoyutlandir
            // 
            this.lblBoyutlandir.AutoSize = true;
            this.lblBoyutlandir.Location = new System.Drawing.Point(778, 31);
            this.lblBoyutlandir.Name = "lblBoyutlandir";
            this.lblBoyutlandir.Size = new System.Drawing.Size(105, 17);
            this.lblBoyutlandir.TabIndex = 9;
            this.lblBoyutlandir.Text = "Boyutlandır (%)";
            // 
            // lblBoyutDeger
            // 
            this.lblBoyutDeger.AutoSize = true;
            this.lblBoyutDeger.Location = new System.Drawing.Point(803, 187);
            this.lblBoyutDeger.Name = "lblBoyutDeger";
            this.lblBoyutDeger.Size = new System.Drawing.Size(32, 17);
            this.lblBoyutDeger.TabIndex = 10;
            this.lblBoyutDeger.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(901, 532);
            this.Controls.Add(this.lblBoyutDeger);
            this.Controls.Add(this.lblBoyutlandir);
            this.Controls.Add(this.trckbroBoyut);
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
            ((System.ComponentModel.ISupportInitialize)(this.trckbroBoyut)).EndInit();
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
        private System.Windows.Forms.TrackBar trckbroBoyut;
        private System.Windows.Forms.Label lblBoyutlandir;
        private System.Windows.Forms.Label lblBoyutDeger;
    }
}

