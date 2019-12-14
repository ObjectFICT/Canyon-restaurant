using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_restaurant
{
    public partial class Form2 : Form
    {
        static string ConstStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mi\Desktop\Project_restaurant\Project_restaurant\Database1.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConstStr);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void UpdateStatusTable(string NumberTable)
        {
            connection.Open();

            SqlCommand UpdateComand = connection.CreateCommand();
            UpdateComand.CommandText = "Update Status_Table SET Status = 0 where id_table = " + NumberTable;
            UpdateComand.ExecuteNonQuery();

            connection.Close();
        }

        private void CreateWindowOrder(string ID)
        {
            Form3 form = new Form3(ID);
            form.Show();

            connection.Open();
          
            SqlCommand UpdateComand = connection.CreateCommand();
            UpdateComand.CommandText = "Update Status_Table SET Status = 1 where id_table = " + ID;
            UpdateComand.ExecuteNonQuery();

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e) { CreateWindowOrder("1"); button1.Enabled = false; }

        private void button2_Click(object sender, EventArgs e) { CreateWindowOrder("2"); button2.Enabled = false; }

        private void button3_Click(object sender, EventArgs e) { CreateWindowOrder("3"); button3.Enabled = false; }       

        private void button4_Click(object sender, EventArgs e) { CreateWindowOrder("4"); button4.Enabled = false; }   

        private void button5_Click(object sender, EventArgs e) { CreateWindowOrder("5"); button5.Enabled = false; }


        private void button7_Click(object sender, EventArgs e) { UpdateStatusTable("1"); button1.Enabled = true; }

        private void button6_Click(object sender, EventArgs e) { UpdateStatusTable("2"); button2.Enabled = true; }

        private void button8_Click(object sender, EventArgs e) { UpdateStatusTable("3"); button3.Enabled = true; }

        private void button9_Click(object sender, EventArgs e) { UpdateStatusTable("4"); button4.Enabled = true; }

        private void button10_Click(object sender, EventArgs e) { UpdateStatusTable("5"); button5.Enabled = true; }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
