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
    public partial class Form3 : Form
    {
        static string ConstStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mi\Desktop\Project_restaurant\Project_restaurant\Database1.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConstStr);

        public string ID__;

        public Form3(string ID_)
        {
            InitializeComponent();
            Text = "Table " + ID_;
            label1.Text = "Table " + ID_;
            ID = ID_;
            button1.Enabled = false;
        }

        public string ID
        {
            get => ID__;
            set => ID__ = value;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.database1DataSet1.Dishes);

            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) => listBox1.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

        private void button1_Click(object sender, EventArgs e)
        {
            int SumOrder = 0, ID_Client = 0;
            string ID_Dish = "";

            connection.Open();

            SqlCommand InsertComand_1 = connection.CreateCommand();
            InsertComand_1.CommandText = "INSERT INTO Client values(" + ID + ",'" + textBox1.Text + "')";
            InsertComand_1.ExecuteNonQuery();

            connection.Close();

            textBox1.Enabled = false;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                connection.Open();

                SqlCommand SelectComand_1 = new SqlCommand("SELECT Cost_Dish FROM Dishes where Name_Dish = '" + listBox1.Items[i] + "'", connection);
                SqlDataReader Reader_1 = SelectComand_1.ExecuteReader();

                if (Reader_1.HasRows)
                {
                    while (Reader_1.Read())
                    {
                        object Cost = Reader_1.GetValue(0);
                        SumOrder += Convert.ToInt32(Cost);
                    }
                }

                connection.Close();
            }

            connection.Open();

            SqlCommand SelectComand_2 = new SqlCommand("SELECT Id_Client FROM Client where Name = '" + textBox1.Text + "'", connection);
            SqlDataReader Reader_2 = SelectComand_2.ExecuteReader();

            if (Reader_2.HasRows)
            {
                while (Reader_2.Read())
                {
                    object id = Reader_2.GetValue(0);
                    ID_Client += Convert.ToInt32(id);
                }
            }

            connection.Close();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                ID_Dish += listBox1.Items[i];

                if (i != listBox1.Items.Count - 1)
                {
                    ID_Dish += ",";
                }
            }

            connection.Open();

            SqlCommand InsertComand_2 = connection.CreateCommand();
            InsertComand_2.CommandText = "INSERT INTO Order_one values('" + ID_Client + "','" + ID_Dish + "','" + SumOrder + "','" + ID + "')";
            InsertComand_2.ExecuteNonQuery();

            connection.Close();

            button1.Enabled = false;
            textBox1.Clear();
            
            connection.Open();

            SqlCommand SelectComand_3 = new SqlCommand("commit", connection);
            
            connection.Close();

            Form4 Form = new Form4(ref listBox1);
            Form.Show();

            listBox1.Items.Clear();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SumOrder = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                connection.Open();

                SqlCommand SelectComand_1 = new SqlCommand("SELECT Cost_Dish FROM Dishes where Name_Dish = '" + listBox1.Items[i] + "'", connection);
                SqlDataReader Reader_1 = SelectComand_1.ExecuteReader();

                if (Reader_1.HasRows)
                {
                    while (Reader_1.Read())
                    {
                        object Cost = Reader_1.GetValue(0);
                        SumOrder += Convert.ToInt32(Cost);
                    }
                }

                connection.Close();
            }

            Form5 Form = new Form5(SumOrder, ref button1);
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
