namespace restaurantProject
{
    partial class AddMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMeal));
            openFileDialog1 = new OpenFileDialog();
            buttonChoose = new Button();
            textBoxFile = new TextBox();
            label7 = new Label();
            backButton = new Button();
            addButton = new Button();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxIngredients = new TextBox();
            label5 = new Label();
            label3 = new Label();
            comboBoxType = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonChoose
            // 
            buttonChoose.BackColor = Color.FromArgb(192, 255, 192);
            buttonChoose.Location = new Point(325, 138);
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
            textBoxFile.Location = new Point(44, 139);
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
            label7.Location = new Point(44, 114);
            label7.Name = "label7";
            label7.Size = new Size(208, 26);
            label7.TabIndex = 35;
            label7.Text = "Hangi dosyaya eklenecek?";
            // 
            // backButton
            // 
            backButton.BackColor = Color.SkyBlue;
            backButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(250, 647);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 34;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.Location = new Point(367, 647);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 33;
            addButton.Text = "Ekle";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(44, 540);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(151, 27);
            textBoxPrice.TabIndex = 32;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(44, 229);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 27);
            textBoxName.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SkyBlue;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 509);
            label6.Name = "label6";
            label6.Size = new Size(50, 26);
            label6.TabIndex = 27;
            label6.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 200);
            label2.Name = "label2";
            label2.Size = new Size(94, 26);
            label2.TabIndex = 23;
            label2.Text = "Yemek Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(44, 44);
            label1.Name = "label1";
            label1.Size = new Size(384, 40);
            label1.TabIndex = 22;
            label1.Text = "Eklemek istediğiniz yemek için;";
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.BorderStyle = BorderStyle.None;
            textBoxIngredients.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIngredients.Location = new Point(44, 434);
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(151, 27);
            textBoxIngredients.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 405);
            label5.Name = "label5";
            label5.Size = new Size(211, 26);
            label5.TabIndex = 26;
            label5.Text = "Yemek Malzemeleri (a,b,c)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 305);
            label3.Name = "label3";
            label3.Size = new Size(104, 26);
            label3.TabIndex = 38;
            label3.Text = "Yemek Türü";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Çorba", "Meze/Salata", "Ana Yemek", "Sebze Yemeği", "Et Yemeği", "Tatlı", "İçecek" });
            comboBoxType.Location = new Point(44, 334);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 689);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // AddMeal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 684);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(buttonChoose);
            Controls.Add(textBoxFile);
            Controls.Add(label7);
            Controls.Add(backButton);
            Controls.Add(addButton);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxIngredients);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddMeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Ekle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button buttonChoose;
        private TextBox textBoxFile;
        private Label label7;
        private Button backButton;
        private Button addButton;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox textBoxIngredients;
        private Label label5;
        private Label label3;
        private ComboBox comboBoxType;
        private PictureBox pictureBox1;
    }
}