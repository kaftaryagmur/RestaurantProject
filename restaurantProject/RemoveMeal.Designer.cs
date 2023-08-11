namespace restaurantProject
{
    partial class RemoveMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveMeal));
            openFileDialog1 = new OpenFileDialog();
            buttonChoose = new Button();
            textBoxFile = new TextBox();
            label7 = new Label();
            backButton = new Button();
            removeButton = new Button();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            buttonChoose.Location = new Point(347, 182);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(60, 28);
            buttonChoose.TabIndex = 42;
            buttonChoose.Text = "Seç";
            buttonChoose.UseVisualStyleBackColor = false;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // textBoxFile
            // 
            textBoxFile.BorderStyle = BorderStyle.None;
            textBoxFile.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFile.Location = new Point(44, 183);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.ReadOnly = true;
            textBoxFile.Size = new Size(275, 27);
            textBoxFile.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SkyBlue;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 154);
            label7.Name = "label7";
            label7.Size = new Size(208, 26);
            label7.TabIndex = 40;
            label7.Text = "Hangi dosyadan silinecek?";
            // 
            // backButton
            // 
            backButton.BackColor = Color.SkyBlue;
            backButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(214, 597);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 39;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.Image = (Image)resources.GetObject("removeButton.Image");
            removeButton.Location = new Point(326, 597);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(94, 29);
            removeButton.TabIndex = 38;
            removeButton.Text = "Sil";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(45, 280);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 252);
            label2.Name = "label2";
            label2.Size = new Size(94, 26);
            label2.TabIndex = 36;
            label2.Text = "Yemek Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(44, 61);
            label1.Name = "label1";
            label1.Size = new Size(364, 40);
            label1.TabIndex = 35;
            label1.Text = "Silmek istediğiniz yemek için;";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 689);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // RemoveMeal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 684);
            Controls.Add(buttonChoose);
            Controls.Add(textBoxFile);
            Controls.Add(label7);
            Controls.Add(backButton);
            Controls.Add(removeButton);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoveMeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Sil";
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
        private Button removeButton;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}