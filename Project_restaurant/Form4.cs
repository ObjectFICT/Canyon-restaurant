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
    public partial class Form4 : Form
    {
        public Form4(ref ListBox list)
        {
            InitializeComponent();

            for(int i = 0; i < list.Items.Count; i++)
            {
                listBox1.Items.Add(list.Items[i]);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet2.Order_one". При необходимости она может быть перемещена или удалена.
            this.order_oneTableAdapter.Fill(this.database1DataSet2.Order_one);
        }


        private void button1_Click(object sender, EventArgs e) => this.Close();
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
