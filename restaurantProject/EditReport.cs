using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace restaurantProject
{
    public partial class EditReport : Form
    {
        public EditReport()
        {
            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

            try
            {
                string selectedFilePath = textBoxFile.Text;

                string[] depoLines = File.ReadAllLines(selectedFilePath);

                rtbDepoIcerik.Lines = depoLines;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor alırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            StorageTransaction back_page = new StorageTransaction();
            back_page.ShowDialog();
            this.Close();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            string filePath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = openFileDialog1.FileName;
                filePath = textBoxFile.Text;
            }
        }
    }
}
