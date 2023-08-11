namespace restaurantProject
{
    partial class StorageTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageTransaction));
            buttonKayitEkle = new Button();
            buttonKayitSil = new Button();
            buttonKayitGuncelle = new Button();
            buttonRapor = new Button();
            pictureBox1 = new PictureBox();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonKayitEkle
            // 
            buttonKayitEkle.BackgroundImage = (Image)resources.GetObject("buttonKayitEkle.BackgroundImage");
            buttonKayitEkle.BackgroundImageLayout = ImageLayout.Stretch;
            buttonKayitEkle.FlatStyle = FlatStyle.Flat;
            buttonKayitEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKayitEkle.Location = new Point(97, 555);
            buttonKayitEkle.Name = "buttonKayitEkle";
            buttonKayitEkle.Size = new Size(140, 48);
            buttonKayitEkle.TabIndex = 1;
            buttonKayitEkle.Text = "Kayıt Ekle";
            buttonKayitEkle.UseVisualStyleBackColor = true;
            buttonKayitEkle.Click += buttonKayitEkle_Click;
            // 
            // buttonKayitSil
            // 
            buttonKayitSil.BackgroundImage = (Image)resources.GetObject("buttonKayitSil.BackgroundImage");
            buttonKayitSil.BackgroundImageLayout = ImageLayout.Stretch;
            buttonKayitSil.FlatStyle = FlatStyle.Flat;
            buttonKayitSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKayitSil.Location = new Point(336, 555);
            buttonKayitSil.Name = "buttonKayitSil";
            buttonKayitSil.Size = new Size(140, 48);
            buttonKayitSil.TabIndex = 2;
            buttonKayitSil.Text = "Kayıt Sil";
            buttonKayitSil.UseVisualStyleBackColor = true;
            buttonKayitSil.Click += buttonKayitSil_Click;
            // 
            // buttonKayitGuncelle
            // 
            buttonKayitGuncelle.BackgroundImage = (Image)resources.GetObject("buttonKayitGuncelle.BackgroundImage");
            buttonKayitGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            buttonKayitGuncelle.FlatStyle = FlatStyle.Flat;
            buttonKayitGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKayitGuncelle.Location = new Point(587, 555);
            buttonKayitGuncelle.Name = "buttonKayitGuncelle";
            buttonKayitGuncelle.Size = new Size(140, 48);
            buttonKayitGuncelle.TabIndex = 3;
            buttonKayitGuncelle.Text = "Kayıt Güncelle";
            buttonKayitGuncelle.UseVisualStyleBackColor = true;
            buttonKayitGuncelle.Click += buttonKayitGuncelle_Click;
            // 
            // buttonRapor
            // 
            buttonRapor.BackColor = SystemColors.ActiveCaptionText;
            buttonRapor.BackgroundImage = (Image)resources.GetObject("buttonRapor.BackgroundImage");
            buttonRapor.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRapor.FlatStyle = FlatStyle.Flat;
            buttonRapor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRapor.Location = new Point(821, 555);
            buttonRapor.Name = "buttonRapor";
            buttonRapor.Size = new Size(140, 48);
            buttonRapor.TabIndex = 4;
            buttonRapor.Text = "Rapor Al";
            buttonRapor.UseVisualStyleBackColor = false;
            buttonRapor.Click += buttonRapor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1082, 756);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.SkyBlue;
            backButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(944, 712);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 31;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // StorageTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 753);
            Controls.Add(backButton);
            Controls.Add(buttonRapor);
            Controls.Add(buttonKayitGuncelle);
            Controls.Add(buttonKayitSil);
            Controls.Add(buttonKayitEkle);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StorageTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Depo İşlemleri";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonKayitEkle;
        private Button buttonKayitSil;
        private Button buttonKayitGuncelle;
        private Button buttonRapor;
        private PictureBox pictureBox1;
        private Button backButton;
    }
}