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
            buttonSiparis = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            vegetableCheckBox = new CheckBox();
            meatCheckBox = new CheckBox();
            mainDishCheckBox = new CheckBox();
            soupCheckBox = new CheckBox();
            dessertCheckBox = new CheckBox();
            sideDishCheckBox = new CheckBox();
            drinkCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SkyBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1100, 767);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderColor = Color.SteelBlue;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(976, 712);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // buttonSiparis
            // 
            buttonSiparis.BackColor = Color.FromArgb(192, 255, 192);
            buttonSiparis.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiparis.Location = new Point(866, 712);
            buttonSiparis.Name = "buttonSiparis";
            buttonSiparis.Size = new Size(94, 29);
            buttonSiparis.TabIndex = 9;
            buttonSiparis.Text = "Sipariş Ver";
            buttonSiparis.UseVisualStyleBackColor = false;
            buttonSiparis.Click += buttonSiparis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(435, 320);
            label1.Name = "label1";
            label1.Size = new Size(57, 26);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SteelBlue;
            textBox1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(430, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 36);
            textBox1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightCyan;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(296, 612);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(502, 120);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "Yemek Adı / Malzemeler :";
            // 
            // vegetableCheckBox
            // 
            vegetableCheckBox.AutoSize = true;
            vegetableCheckBox.BackgroundImage = (Image)resources.GetObject("vegetableCheckBox.BackgroundImage");
            vegetableCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            vegetableCheckBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            vegetableCheckBox.Location = new Point(67, 161);
            vegetableCheckBox.Name = "vegetableCheckBox";
            vegetableCheckBox.Size = new Size(175, 30);
            vegetableCheckBox.TabIndex = 21;
            vegetableCheckBox.Text = "vegetableCheckBox";
            vegetableCheckBox.UseVisualStyleBackColor = true;
            vegetableCheckBox.CheckedChanged += vegetableCheckBox_CheckedChanged;
            // 
            // meatCheckBox
            // 
            meatCheckBox.AutoSize = true;
            meatCheckBox.BackgroundImage = (Image)resources.GetObject("meatCheckBox.BackgroundImage");
            meatCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            meatCheckBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            meatCheckBox.Location = new Point(65, 218);
            meatCheckBox.Name = "meatCheckBox";
            meatCheckBox.Size = new Size(144, 30);
            meatCheckBox.TabIndex = 22;
            meatCheckBox.Text = "meatCheckBox";
            meatCheckBox.UseVisualStyleBackColor = true;
            meatCheckBox.CheckedChanged += meatCheckBox_CheckedChanged;
            // 
            // mainDishCheckBox
            // 
            mainDishCheckBox.AutoSize = true;
            mainDishCheckBox.BackgroundImage = (Image)resources.GetObject("mainDishCheckBox.BackgroundImage");
            mainDishCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            mainDishCheckBox.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mainDishCheckBox.Location = new Point(67, 274);
            mainDishCheckBox.Name = "mainDishCheckBox";
            mainDishCheckBox.Size = new Size(189, 27);
            mainDishCheckBox.TabIndex = 23;
            mainDishCheckBox.Text = "mainDishCheckBox";
            mainDishCheckBox.UseVisualStyleBackColor = true;
            mainDishCheckBox.CheckedChanged += mainDishCheckBox_CheckedChanged;
            // 
            // soupCheckBox
            // 
            soupCheckBox.AutoSize = true;
            soupCheckBox.BackgroundImage = (Image)resources.GetObject("soupCheckBox.BackgroundImage");
            soupCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            soupCheckBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            soupCheckBox.Location = new Point(65, 531);
            soupCheckBox.Name = "soupCheckBox";
            soupCheckBox.Size = new Size(138, 30);
            soupCheckBox.TabIndex = 24;
            soupCheckBox.Text = "soupCheckBox";
            soupCheckBox.UseVisualStyleBackColor = true;
            soupCheckBox.CheckedChanged += soupCheckBox_CheckedChanged;
            // 
            // dessertCheckBox
            // 
            dessertCheckBox.AutoSize = true;
            dessertCheckBox.BackgroundImage = (Image)resources.GetObject("dessertCheckBox.BackgroundImage");
            dessertCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            dessertCheckBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dessertCheckBox.Location = new Point(828, 159);
            dessertCheckBox.Name = "dessertCheckBox";
            dessertCheckBox.Size = new Size(158, 30);
            dessertCheckBox.TabIndex = 26;
            dessertCheckBox.Text = "dessertCheckBox";
            dessertCheckBox.UseVisualStyleBackColor = true;
            dessertCheckBox.CheckedChanged += dessertCheckBox_CheckedChanged;
            // 
            // sideDishCheckBox
            // 
            sideDishCheckBox.AutoSize = true;
            sideDishCheckBox.BackgroundImage = (Image)resources.GetObject("sideDishCheckBox.BackgroundImage");
            sideDishCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            sideDishCheckBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sideDishCheckBox.Location = new Point(462, 531);
            sideDishCheckBox.Name = "sideDishCheckBox";
            sideDishCheckBox.Size = new Size(164, 30);
            sideDishCheckBox.TabIndex = 27;
            sideDishCheckBox.Text = "sideDishCheckBox";
            sideDishCheckBox.UseVisualStyleBackColor = true;
            sideDishCheckBox.CheckedChanged += sideDishCheckBox_CheckedChanged;
            // 
            // drinkCheckBox
            // 
            drinkCheckBox.AutoSize = true;
            drinkCheckBox.BackgroundImage = (Image)resources.GetObject("drinkCheckBox.BackgroundImage");
            drinkCheckBox.BackgroundImageLayout = ImageLayout.Stretch;
            drinkCheckBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            drinkCheckBox.Location = new Point(828, 541);
            drinkCheckBox.Name = "drinkCheckBox";
            drinkCheckBox.Size = new Size(146, 30);
            drinkCheckBox.TabIndex = 28;
            drinkCheckBox.Text = "drinkCheckBox";
            drinkCheckBox.UseVisualStyleBackColor = true;
            drinkCheckBox.CheckedChanged += drinkCheckBox_CheckedChanged;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 753);
            Controls.Add(drinkCheckBox);
            Controls.Add(sideDishCheckBox);
            Controls.Add(dessertCheckBox);
            Controls.Add(soupCheckBox);
            Controls.Add(mainDishCheckBox);
            Controls.Add(meatCheckBox);
            Controls.Add(vegetableCheckBox);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonSiparis);
            Controls.Add(backButton);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menü";
            Load += MenuForm_Load1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backButton;
        private Button buttonSiparis;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox1;
        private CheckBox vegetableCheckBox;
        private CheckBox meatCheckBox;
        private CheckBox mainDishCheckBox;
        private CheckBox soupCheckBox;
        private CheckBox drinkCheckBox;
        private CheckBox dessertCheckBox;
        private CheckBox sideDishCheckBox;
        private CheckBox checkBox2;
    }
}