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
            orderForm = new Siparis(this);
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
                "Mantarlı Pirinç Roti",
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
                "Patlıcan Salatası",
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
                "Gazoz",
            };
            Assignment(vegetableCheckBox, vegetableDishList);
            Assignment(meatCheckBox, meatDishList);
            Assignment(mainDishCheckBox, mainDishList);
            Assignment(soupCheckBox, soupList);
            Assignment(sideDishCheckBox, sideDishList);
            Assignment(dessertCheckBox, dessertList);
            Assignment(drinkCheckBox, drinkList);

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

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 main_page = new Form1();
            main_page.ShowDialog();
            this.Close();
        }


    }
}
