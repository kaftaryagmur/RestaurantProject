using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantProject
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            textBoxName.Text = "";
            textBoxStock.Text = "";
            textBoxSellByDate.Text = "";
            textBoxCalorie.Text = "";
            textBoxPrice.Text = "";
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            string dosyaIcerik = File.ReadAllText(openFileDialog1.FileName);

            string updateName = textBoxName.Text;
            int newStock = Convert.ToInt32(textBoxStock.Text);
            string newSellByDate = textBoxSellByDate.Text;
            int newCalorie = Convert.ToInt32(textBoxCalorie.Text);
            decimal newPrice = Convert.ToDecimal(textBoxPrice.Text);

            string[] satirlar = dosyaIcerik.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < satirlar.Length; i++)
            {
                string satir = satirlar[i];
                if (satir.Contains(updateName))
                {
                    satir = $"{updateName},{newStock},{newSellByDate},{newCalorie},{newPrice}";
                    satirlar[i] = satir;
                    break;
                }
            }
            string guncelIcerik = string.Join(Environment.NewLine, satirlar);
            File.WriteAllText(openFileDialog1.FileName, guncelIcerik);
            MessageBox.Show("Ürün başarıyla güncellendi.");
            Temizle();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            StorageTransaction back_page = new StorageTransaction();
            back_page.ShowDialog();
            this.Close();
        }
    }
}
