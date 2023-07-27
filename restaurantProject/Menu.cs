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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 main_page = new Form1();
            main_page.ShowDialog();
            this.Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }


    }
}
