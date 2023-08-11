namespace restaurantProject
{
    partial class UpdateMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMeal));
            backButton = new Button();
            updateButton = new Button();
            label1 = new Label();
            comboBoxType = new ComboBox();
            label3 = new Label();
            buttonChoose = new Button();
            textBoxFile = new TextBox();
            label7 = new Label();
            textBoxPrice = new TextBox();
            textBoxIngredients = new TextBox();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.SkyBlue;
            backButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(250, 643);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 51;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.Image = (Image)resources.GetObject("updateButton.Image");
            updateButton.Location = new Point(371, 643);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 50;
            updateButton.Text = "Güncelle";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(432, 40);
            label1.TabIndex = 39;
            label1.Text = "Güncellemek istediğiniz yemek için;";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Çorba", "Meze/Salata", "Ana Yemek", "Sebze Yemeği", "Et Yemeği", "Tatlı", "İçecek" });
            comboBoxType.Location = new Point(57, 336);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 307);
            label3.Name = "label3";
            label3.Size = new Size(104, 26);
            label3.TabIndex = 61;
            label3.Text = "Yemek Türü";
            // 
            // buttonChoose
            // 
            buttonChoose.BackColor = Color.FromArgb(192, 255, 192);
            buttonChoose.Location = new Point(349, 140);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(60, 28);
            buttonChoose.TabIndex = 60;
            buttonChoose.Text = "Seç";
            buttonChoose.UseVisualStyleBackColor = false;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // textBoxFile
            // 
            textBoxFile.BorderStyle = BorderStyle.None;
            textBoxFile.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFile.Location = new Point(57, 141);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.ReadOnly = true;
            textBoxFile.Size = new Size(275, 27);
            textBoxFile.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SkyBlue;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(57, 112);
            label7.Name = "label7";
            label7.Size = new Size(250, 26);
            label7.TabIndex = 58;
            label7.Text = "Hangi dosyadan güncellenecek?";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(57, 540);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(151, 27);
            textBoxPrice.TabIndex = 57;
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.BorderStyle = BorderStyle.None;
            textBoxIngredients.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIngredients.Location = new Point(57, 436);
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(151, 27);
            textBoxIngredients.TabIndex = 56;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(57, 231);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 27);
            textBoxName.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SkyBlue;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 511);
            label6.Name = "label6";
            label6.Size = new Size(50, 26);
            label6.TabIndex = 54;
            label6.Text = "Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 407);
            label5.Name = "label5";
            label5.Size = new Size(211, 26);
            label5.TabIndex = 53;
            label5.Text = "Yemek Malzemeleri (a,b,c)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 202);
            label2.Name = "label2";
            label2.Size = new Size(94, 26);
            label2.TabIndex = 52;
            label2.Text = "Yemek Adı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 689);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateMeal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 684);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(buttonChoose);
            Controls.Add(textBoxFile);
            Controls.Add(label7);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxIngredients);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(backButton);
            Controls.Add(updateButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateMeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Güncelle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backButton;
        private Button updateButton;
        private Label label1;
        private ComboBox comboBoxType;
        private Label label3;
        private Button buttonChoose;
        private TextBox textBoxFile;
        private Label label7;
        private TextBox textBoxPrice;
        private TextBox textBoxIngredients;
        private TextBox textBoxName;
        private Label label6;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}