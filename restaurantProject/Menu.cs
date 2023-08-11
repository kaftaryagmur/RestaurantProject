using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace restaurantProject
{
    public partial class MenuForm : Form
    {
        private List<string> choosenDish;
        private Siparis orderForm;
        private List<string> vegetableDishList;
        private List<string> meatDishList;
        private List<string> mainDishList;
        private List<string> soupList;
        private List<string> sideDishList;
        private List<string> dessertList;
        private List<string> drinkList;

        public MenuForm()
        {
            InitializeComponent();
            choosenDish = new List<string>();
            orderForm = new Siparis();

            vegetableDishList = new List<string>
            {
                "Yoğurtlu Ispanak",
                "Fırında Karnabahar",
                "Taze Fasulye",
                "Biber Dolması",
                "Patates Musakka",
                "Ispanaklı Patates Köftesi",
                "Kabak Mücveri",
                "Patlıcan Musakka",
                "Kabak Dolması",
                "Zeytinyağlı Yaprak Sarma"
            };
            meatDishList = new List<string>
            {
                "Patlıcan Kebabı",
                "Mantarlı Piliç Roti",
                "Hindi Sote",
                "Etli Nohut",
                "Avcı Usülü Tavuk",
                "Tavuk Şiş Kebabı",
                "Etli Patlıcan Yemeği",
                "Dana Sote",
                "Köfte Izgara",
                "Kuzu Tandır"
            };

            mainDishList = new List<string>
            {
                "Kremalı Makarna",
                "Pirinç Pilavı",
                "Bulgur Pilavı",
                "Yoğurtlu Makarna",
                "Soslu Makarna",
                "Ispanaklı Börek",
                "Nohutlu Pilav",
                "Sebzeli Bulgur Pilavı",
                "Patatesli Börek",
                "Kıymalı Su Böreği"
            };
            soupList = new List<string>
            {
                "Mercimek Çorbası",
                "Ezogelin Çorbası",
                "Domates Çorbası",
                "Arpa Şehriye Çorbası",
                "Yoğurt Çorbası",
                "Mantar Çorbası",
                "Tarhana Çorbası",
                "İşkembe Çorbası",
                "Kremalı Mantar Çorbası",
                "Tavuklu Şehriye Çorbası"
            };
            sideDishList = new List<string>
            {
                "Humus",
                "Arpa Şehriye Salatası",
                "Haydari",
                "Cacık",
                "Mevsim Salata",
                "Yoğurtlu Havuç Tarator",
                "Acılı Ezme",
                "Yoğurtlu Semizotu Salatası",
                "Yoğurtlu Köz Patlıcan",
                "Çoban Salata"
            };
            dessertList = new List<string>
            {
                "Baklava",
                "Kadayıf",
                "Revani",
                "Sütlaç",
                "Dondurma",
                "Şekerpare",
                "Trileçe",
                "Muhallebi",
                "Tiramisu",
                "Profiterol"
            };
            drinkList = new List<string>
            {
                "Ayran",
                "Limonata",
                "Karadut",
                "Meyve Suyu",
                "Soğuk Çay",
                "Maden Suyu",
                "Naneli Limonata",
                "Ayva Şerbeti",
                "Şalgam Suyu",
                "Gazoz"
            };
            Assignment(vegetableCheckBox, vegetableDishList);
            Assignment(meatCheckBox, meatDishList);
            Assignment(mainDishCheckBox, mainDishList);
            Assignment(sideDishCheckBox, sideDishList);
            Assignment(soupCheckBox, soupList);
            Assignment(drinkCheckBox, drinkList);
            Assignment(dessertCheckBox, dessertList);


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void MenuForm_Load1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Assignment(CheckBox checkBox, List<string> yemekListesi)
        {
            if (yemekListesi.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(yemekListesi.Count);
                checkBox.Text = yemekListesi[index];
                yemekListesi.RemoveAt(index);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 main_page = new Form1();
            main_page.ShowDialog();
            this.Close();
        }

        private void buttonSiparis_Click(object sender, EventArgs e)
        {
            choosenDish.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    choosenDish.Add(checkBox.Text);
                }
            }
            orderForm.GuncelleSiparisListesi(choosenDish);
            orderForm.ShowDialog();
        }

        private string GetIngredientsForMeal(string mealName)
        {
            string filePath = "C:/Users/kafta/source/restaurantProject/restaurantProject/Yemek.txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 4 && parts[0].Trim() == mealName)
                {
                    string icerik = richTextBox1.Text;
                    string yeni_icerik = mealName + parts[2].Trim() + ", " + parts[3] + ", " + parts[4] + ", " + parts[5];
                    string güncel_icerik = icerik + "\n" + yeni_icerik;

                    return güncel_icerik;
                }
            }

            return "Malzemeler bulunamadı.";
        }
        private void vegetableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vegetableCheckBox != null && vegetableCheckBox.Checked)
            {
                string selectedMeal = vegetableCheckBox.Text;
                string ingredients = GetIngredientsForMeal(selectedMeal);

                richTextBox1.Text = ingredients;
            }
        }

        private void meatCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            string selectedMeal = meatCheckBox.Text;
            string ingredients = GetIngredientsForMeal(selectedMeal);

            richTextBox1.Text = ingredients;

        }

        private void mainDishCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            string selectedMeal = mainDishCheckBox.Text;
            string ingredients = GetIngredientsForMeal(selectedMeal);

            richTextBox1.Text = ingredients;

        }

        private void soupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string selectedMeal = soupCheckBox.Text;
            string ingredients = GetIngredientsForMeal(selectedMeal);

            richTextBox1.Text = ingredients;
        }

        private void sideDishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string selectedMeal = sideDishCheckBox.Text;
            string ingredients = GetIngredientsForMeal(selectedMeal);

            richTextBox1.Text = ingredients;
        }

        private void drinkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string icerik = richTextBox1.Text;
            string yeni_icerik = drinkCheckBox.Text;

            richTextBox1.Text = icerik + "\n" + yeni_icerik;
        }

        private void dessertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string selectedMeal = dessertCheckBox.Text;
            string ingredients = GetIngredientsForMeal(selectedMeal);

            richTextBox1.Text = ingredients;
        }
    }
}
