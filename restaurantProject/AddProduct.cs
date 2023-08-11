using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace restaurantProject
{
    public partial class AddProduct : Form
    {
        public AddProduct()
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
        private void addButton_Click(object sender, EventArgs e)
        {
            string dosyaIcerik = File.ReadAllText(openFileDialog1.FileName);

            string name = textBoxName.Text;
            int stock = Convert.ToInt32(textBoxStock.Text);
            string sellByDate = textBoxSellByDate.Text;
            int calorie = Convert.ToInt32(textBoxCalorie.Text);
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            string yeniIcerik = $"{name},{stock},{sellByDate},{calorie},{price}";

            string guncelIcerik = dosyaIcerik + yeniIcerik;
            File.WriteAllText(openFileDialog1.FileName, guncelIcerik);
            MessageBox.Show("Ürün ekleme tamamlandı.");
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
