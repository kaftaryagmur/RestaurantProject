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
    public partial class UpdateMeal : Form
    {
        public UpdateMeal()
        {
            InitializeComponent();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            StorageTransaction back_page = new StorageTransaction();
            back_page.ShowDialog();
            this.Close();
        }
        private void Temizle()
        {
            textBoxName.Text = "";
            comboBoxType.SelectedIndex = 0;
            textBoxIngredients.Text = "";
            textBoxPrice.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string dosyaIcerik = File.ReadAllText(openFileDialog1.FileName);

            string updateName = textBoxName.Text;
            string type = comboBoxType.Text;
            string ingredients = textBoxIngredients.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            string[] satirlar = dosyaIcerik.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < satirlar.Length; i++)
            {
                string satir = satirlar[i];
                if (satir.Contains(updateName))
                {
                    satir = $"{updateName},{type},{ingredients},{price}";
                    satirlar[i] = satir;
                    break;
                }
            }
            string guncelIcerik = string.Join(Environment.NewLine, satirlar);
            File.WriteAllText(openFileDialog1.FileName, guncelIcerik);
            MessageBox.Show("Yemek başarıyla güncellendi.");
            Temizle();
        }
    }
}
