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
    public partial class MealTransaction : Form
    {
        public MealTransaction()
        {
            InitializeComponent();
        }

        private void buttonKayitEkle_Click(object sender, EventArgs e)
        {
            AddMeal add = new AddMeal();
            add.ShowDialog();
            this.Close();

        }

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            RemoveMeal remove = new RemoveMeal();
            remove.ShowDialog();
            this.Close();
        }

        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            UpdateMeal update = new UpdateMeal();
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
            RestaurantForm back = new RestaurantForm();
            back.ShowDialog();
            this.Close();
        }
    }
}
