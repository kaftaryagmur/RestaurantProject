namespace restaurantProject
{
    partial class EditReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReport));
            backButton = new Button();
            reportButton = new Button();
            buttonChoose = new Button();
            textBoxFile = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            rtbDepoIcerik = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.SkyBlue;
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(318, 134);
            backButton.Name = "backButton";
            backButton.Size = new Size(180, 46);
            backButton.TabIndex = 18;
            backButton.Text = "Geri";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // reportButton
            // 
            reportButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reportButton.Image = (Image)resources.GetObject("reportButton.Image");
            reportButton.Location = new Point(127, 134);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(188, 46);
            reportButton.TabIndex = 19;
            reportButton.Text = "Rapor Al";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Click += reportButton_Click;
            // 
            // buttonChoose
            // 
            buttonChoose.BackColor = Color.FromArgb(192, 255, 192);
            buttonChoose.Location = new Point(377, 58);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(94, 42);
            buttonChoose.TabIndex = 25;
            buttonChoose.Text = "Seç";
            buttonChoose.UseVisualStyleBackColor = false;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // textBoxFile
            // 
            textBoxFile.BorderStyle = BorderStyle.FixedSingle;
            textBoxFile.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFile.Location = new Point(22, 64);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.ReadOnly = true;
            textBoxFile.Size = new Size(307, 34);
            textBoxFile.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SkyBlue;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 20);
            label7.Name = "label7";
            label7.Size = new Size(238, 26);
            label7.TabIndex = 23;
            label7.Text = "Hangi dosya raporu alınacak?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 688);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbDepoIcerik
            // 
            rtbDepoIcerik.Location = new Point(54, 226);
            rtbDepoIcerik.Name = "rtbDepoIcerik";
            rtbDepoIcerik.Size = new Size(555, 427);
            rtbDepoIcerik.TabIndex = 26;
            rtbDepoIcerik.Text = "";
            // 
            // EditReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 680);
            Controls.Add(rtbDepoIcerik);
            Controls.Add(reportButton);
            Controls.Add(backButton);
            Controls.Add(buttonChoose);
            Controls.Add(textBoxFile);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rapor Al";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backButton;
        private Button reportButton;
        private Button buttonChoose;
        private TextBox textBoxFile;
        private Label label7;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox rtbDepoIcerik;
    }
}