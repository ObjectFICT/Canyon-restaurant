using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_restaurant
{
    public partial class Form5 : Form
    {
        public Button temp;
        public Form5(int sum, ref Button butt)
        {
            InitializeComponent();

            label2.Text = Convert.ToString(sum);

            Button_one = butt;
        }

        public Button Button_one
        {
            get => temp;
            set => temp = value;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_one.Enabled = true;
            this.Close();
        }
    }
}
