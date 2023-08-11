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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }
        public void GuncelleSiparisListesi(List<string> siparisler)
        {
            lstSiparis.Items.Clear();
            lstSiparis.Items.AddRange(siparisler.ToArray());
        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(24, 61);
            label3.Text = randomNumber.ToString() + " dk.";
        }
    }
}
