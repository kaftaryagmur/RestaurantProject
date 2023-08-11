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
    public partial class AddMeal : Form
    {
        public AddMeal()
        {
            InitializeComponent();
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
        private void addButton_Click(object sender, EventArgs e)
        {

            string dosyaIcerik = File.ReadAllText(openFileDialog1.FileName);

            string name = textBoxName.Text;
            string type = comboBoxType.Text;
            string ingredients = textBoxIngredients.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            string yeniIcerik = $"{name},{type},{ingredients},{price}";

            string guncelIcerik = dosyaIcerik + yeniIcerik;
            File.WriteAllText(openFileDialog1.FileName, guncelIcerik);
            MessageBox.Show("Yemek listeye eklendi.");
            Temizle();
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
