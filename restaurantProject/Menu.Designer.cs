namespace restaurantProject
{
    partial class MenuForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            pictureBox1 = new PictureBox();
            backButton = new Button();
            comboBoxMainMeal = new ComboBox();
            comboBoxSoup = new ComboBox();
            comboBoxSalad = new ComboBox();
            comboBoxDesert = new ComboBox();
            comboBoxDrink = new ComboBox();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1086, 757);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Location = new Point(976, 712);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // comboBoxMainMeal
            // 
            comboBoxMainMeal.BackColor = Color.LightCyan;
            comboBoxMainMeal.FormattingEnabled = true;
            comboBoxMainMeal.Location = new Point(67, 174);
            comboBoxMainMeal.Name = "comboBoxMainMeal";
            comboBoxMainMeal.Size = new Size(199, 28);
            comboBoxMainMeal.TabIndex = 2;
            // 
            // comboBoxSoup
            // 
            comboBoxSoup.BackColor = Color.LightCyan;
            comboBoxSoup.FormattingEnabled = true;
            comboBoxSoup.Location = new Point(67, 543);
            comboBoxSoup.Name = "comboBoxSoup";
            comboBoxSoup.Size = new Size(199, 28);
            comboBoxSoup.TabIndex = 3;
            // 
            // comboBoxSalad
            // 
            comboBoxSalad.BackColor = Color.LightCyan;
            comboBoxSalad.FormattingEnabled = true;
            comboBoxSalad.Location = new Point(443, 543);
            comboBoxSalad.Name = "comboBoxSalad";
            comboBoxSalad.Size = new Size(199, 28);
            comboBoxSalad.TabIndex = 4;
            // 
            // comboBoxDesert
            // 
            comboBoxDesert.BackColor = Color.LightCyan;
            comboBoxDesert.FormattingEnabled = true;
            comboBoxDesert.Location = new Point(805, 174);
            comboBoxDesert.Name = "comboBoxDesert";
            comboBoxDesert.Size = new Size(199, 28);
            comboBoxDesert.TabIndex = 5;
            // 
            // comboBoxDrink
            // 
            comboBoxDrink.BackColor = Color.LightCyan;
            comboBoxDrink.FormattingEnabled = true;
            comboBoxDrink.Location = new Point(805, 543);
            comboBoxDrink.Name = "comboBoxDrink";
            comboBoxDrink.Size = new Size(199, 28);
            comboBoxDrink.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 753);
            Controls.Add(textBox1);
            Controls.Add(comboBoxDrink);
            Controls.Add(comboBoxDesert);
            Controls.Add(comboBoxSalad);
            Controls.Add(comboBoxSoup);
            Controls.Add(comboBoxMainMeal);
            Controls.Add(backButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menü";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backButton;
        private ComboBox comboBoxMainMeal;
        private ComboBox comboBoxSoup;
        private ComboBox comboBoxSalad;
        private ComboBox comboBoxDesert;
        private ComboBox comboBoxDrink;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}