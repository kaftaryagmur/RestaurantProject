namespace restaurantProject
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            updateButton = new Button();
            textBoxPrice = new TextBox();
            textBoxCalorie = new TextBox();
            textBoxSellByDate = new TextBox();
            textBoxStock = new TextBox();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backButton = new Button();
            buttonChoose = new Button();
            textBoxFile = new TextBox();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.Image = (Image)resources.GetObject("updateButton.Image");
            updateButton.Location = new Point(371, 643);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 29;
            updateButton.Text = "Güncelle";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(44, 598);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 28;
            // 
            // textBoxCalorie
            // 
            textBoxCalorie.BorderStyle = BorderStyle.None;
            textBoxCalorie.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCalorie.Location = new Point(44, 494);
            textBoxCalorie.Name = "textBoxCalorie";
            textBoxCalorie.Size = new Size(125, 27);
            textBoxCalorie.TabIndex = 27;
            // 
            // textBoxSellByDate
            // 
            textBoxSellByDate.BorderStyle = BorderStyle.None;
            textBoxSellByDate.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSellByDate.Location = new Point(44, 388);
            textBoxSellByDate.Name = "textBoxSellByDate";
            textBoxSellByDate.Size = new Size(125, 27);
            textBoxSellByDate.TabIndex = 26;
            // 
            // textBoxStock
            // 
            textBoxStock.BorderStyle = BorderStyle.None;
            textBoxStock.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStock.Location = new Point(44, 287);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(125, 27);
            textBoxStock.TabIndex = 25;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(44, 191);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SkyBlue;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 575);
            label6.Name = "label6";
            label6.Size = new Size(50, 26);
            label6.TabIndex = 23;
            label6.Text = "Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 471);
            label5.Name = "label5";
            label5.Size = new Size(56, 26);
            label5.TabIndex = 22;
            label5.Text = "Kalori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SkyBlue;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 365);
            label4.Name = "label4";
            label4.Size = new Size(270, 26);
            label4.TabIndex = 21;
            label4.Text = "Son Kullanma Tarihi(yyyy-aa-gg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 264);
            label3.Name = "label3";
            label3.Size = new Size(107, 26);
            label3.TabIndex = 20;
            label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 168);
            label2.Name = "label2";
            label2.Size = new Size(83, 26);
            label2.TabIndex = 19;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(411, 40);
            label1.TabIndex = 18;
            label1.Text = "Güncellemek istediğiniz ürün için;";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 689);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.SkyBlue;
            backButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(250, 643);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 30;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // buttonChoose
            // 
            buttonChoose.BackColor = Color.FromArgb(192, 255, 192);
            buttonChoose.Location = new Point(357, 108);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(60, 28);
            buttonChoose.TabIndex = 37;
            buttonChoose.Text = "Seç";
            buttonChoose.UseVisualStyleBackColor = false;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // textBoxFile
            // 
            textBoxFile.BorderStyle = BorderStyle.None;
            textBoxFile.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFile.Location = new Point(44, 108);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.ReadOnly = true;
            textBoxFile.Size = new Size(275, 27);
            textBoxFile.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SkyBlue;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 79);
            label7.Name = "label7";
            label7.Size = new Size(292, 26);
            label7.TabIndex = 35;
            label7.Text = "Hangi dosyadan ürün güncellenecek?";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 684);
            Controls.Add(buttonChoose);
            Controls.Add(textBoxFile);
            Controls.Add(label7);
            Controls.Add(backButton);
            Controls.Add(updateButton);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCalorie);
            Controls.Add(textBoxSellByDate);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Güncelle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateButton;
        private TextBox textBoxPrice;
        private TextBox textBoxCalorie;
        private TextBox textBoxSellByDate;
        private TextBox textBoxStock;
        private TextBox textBoxName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button backButton;
        private Button buttonChoose;
        private TextBox textBoxFile;
        private Label label7;
        private OpenFileDialog openFileDialog1;
    }
}