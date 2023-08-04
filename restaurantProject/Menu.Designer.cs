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
            vegetableCheckBox = new CheckBox();
            meatCheckBox = new CheckBox();
            soupCheckBox = new CheckBox();
            sideDishCheckBox = new CheckBox();
            dessertCheckBox = new CheckBox();
            drinkCheckBox = new CheckBox();
            mainDishCheckBox = new CheckBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -3);
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
            backButton.Text = "Ana Sayfa";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // buttonSiparis
            // 
            buttonSiparis.Location = new Point(866, 712);
            buttonSiparis.Name = "buttonSiparis";
            buttonSiparis.Size = new Size(94, 29);
            buttonSiparis.TabIndex = 9;
            buttonSiparis.Text = "Sipariş Ver";
            buttonSiparis.UseVisualStyleBackColor = true;
            buttonSiparis.Click += buttonSiparis_Click;
            // 
            // vegetableCheckBox
            // 
            vegetableCheckBox.AutoSize = true;
            vegetableCheckBox.Location = new Point(87, 168);
            vegetableCheckBox.Name = "vegetableCheckBox";
            vegetableCheckBox.Size = new Size(101, 24);
            vegetableCheckBox.TabIndex = 10;
            vegetableCheckBox.Text = "checkBox1";
            vegetableCheckBox.UseVisualStyleBackColor = true;
            // 
            // meatCheckBox
            // 
            meatCheckBox.AutoSize = true;
            meatCheckBox.Location = new Point(87, 225);
            meatCheckBox.Name = "meatCheckBox";
            meatCheckBox.Size = new Size(101, 24);
            meatCheckBox.TabIndex = 11;
            meatCheckBox.Text = "checkBox2";
            meatCheckBox.UseVisualStyleBackColor = true;
            // 
            // soupCheckBox
            // 
            soupCheckBox.AutoSize = true;
            soupCheckBox.Location = new Point(110, 561);
            soupCheckBox.Name = "soupCheckBox";
            soupCheckBox.Size = new Size(101, 24);
            soupCheckBox.TabIndex = 12;
            soupCheckBox.Text = "checkBox3";
            soupCheckBox.UseVisualStyleBackColor = true;
            // 
            // sideDishCheckBox
            // 
            sideDishCheckBox.AutoSize = true;
            sideDishCheckBox.Location = new Point(491, 561);
            sideDishCheckBox.Name = "sideDishCheckBox";
            sideDishCheckBox.Size = new Size(101, 24);
            sideDishCheckBox.TabIndex = 13;
            sideDishCheckBox.Text = "checkBox4";
            sideDishCheckBox.UseVisualStyleBackColor = true;
            // 
            // dessertCheckBox
            // 
            dessertCheckBox.AutoSize = true;
            dessertCheckBox.Location = new Point(859, 191);
            dessertCheckBox.Name = "dessertCheckBox";
            dessertCheckBox.Size = new Size(101, 24);
            dessertCheckBox.TabIndex = 14;
            dessertCheckBox.Text = "checkBox5";
            dessertCheckBox.UseVisualStyleBackColor = true;
            // 
            // drinkCheckBox
            // 
            drinkCheckBox.AutoSize = true;
            drinkCheckBox.Location = new Point(859, 561);
            drinkCheckBox.Name = "drinkCheckBox";
            drinkCheckBox.Size = new Size(101, 24);
            drinkCheckBox.TabIndex = 15;
            drinkCheckBox.Text = "checkBox6";
            drinkCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainDishCheckBox
            // 
            mainDishCheckBox.AutoSize = true;
            mainDishCheckBox.Location = new Point(87, 281);
            mainDishCheckBox.Name = "mainDishCheckBox";
            mainDishCheckBox.Size = new Size(101, 24);
            mainDishCheckBox.TabIndex = 16;
            mainDishCheckBox.Text = "checkBox1";
            mainDishCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 329);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 18;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 753);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(mainDishCheckBox);
            Controls.Add(drinkCheckBox);
            Controls.Add(dessertCheckBox);
            Controls.Add(sideDishCheckBox);
            Controls.Add(soupCheckBox);
            Controls.Add(meatCheckBox);
            Controls.Add(vegetableCheckBox);
            Controls.Add(buttonSiparis);
            Controls.Add(backButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private CheckBox vegetableCheckBox;
        private CheckBox meatCheckBox;
        private CheckBox soupCheckBox;
        private CheckBox sideDishCheckBox;
        private CheckBox dessertCheckBox;
        private CheckBox drinkCheckBox;
        private CheckBox mainDishCheckBox;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
    }
}