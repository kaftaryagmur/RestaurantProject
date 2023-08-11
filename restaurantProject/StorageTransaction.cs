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
    public partial class StorageTransaction : Form
    {
        public StorageTransaction()
        {
            InitializeComponent();
        }
        private void buttonKayitEkle_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.ShowDialog();
            this.Close();
        }
        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            RemoveProduct delete = new RemoveProduct();
            delete.ShowDialog();
            this.Close();
        }
        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            UpdateProduct update = new UpdateProduct();
            update.ShowDialog();
            this.Close();
        }
        private void buttonRapor_Click(object sender, EventArgs e)
        {
            EditReport report = new EditReport();
            report.ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            RestaurantForm back_page = new RestaurantForm();
            back_page.ShowDialog();
            this.Close();
        }
    }
}
