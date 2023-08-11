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

namespace restaurantProject
{
    public partial class RemoveProduct : Form
    {

        public RemoveProduct()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            textBoxName.Text = "";

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

        private void removeButton_Click(object sender, EventArgs e)
        {
            string dosyaIcerik = File.ReadAllText(openFileDialog1.FileName);
            string name = textBoxName.Text;

            string[] satirlar = dosyaIcerik.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string yeniIcerik = "";

            foreach (string satir in satirlar)
            {
                if (!satir.Contains(name))
                {
                    yeniIcerik += satir + Environment.NewLine;
                }
            }
            File.WriteAllText(openFileDialog1.FileName, yeniIcerik);
            Temizle();
            MessageBox.Show("Ürün silme tamamlandı.");

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StorageTransaction back_page = new StorageTransaction();
            back_page.ShowDialog();
            this.Close();
        }

    }
}


