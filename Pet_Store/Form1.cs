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

namespace Pet_Store
{

    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2HSGGU6M\MSSQLSERVER01;
                                                     Initial Catalog=Pet_shop;
                                                     Integrated Security=True");
        


        public Form1()
        {
            InitializeComponent();
            connection.Open();
            SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                "from Goods A, Category B " +
                                                "where CategoryID = B.ID and Number = 0", connection);
            DataTable data = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            data.Load(dataReader);
            connection.Close();
            dataGridView1.DataSource = data.DefaultView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                "from Goods A, Category B " +
                                                "where CategoryID = B.ID and A.Name like '" + textBox1.Text + "%'", connection);
            DataTable data = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            data.Load(dataReader);
            connection.Close();
            dataGridView1.DataSource = data.DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                    "from Goods A, Category B" +
                                                    " where CategoryID = B.ID and CategoryID in " +
                                                    "(select ID from Category " +
                                                    "where Animal = 1)", connection);
                DataTable data = new DataTable();
                SqlDataReader dataReader = command.ExecuteReader();
                data.Load(dataReader);
                connection.Close();
                dataGridView1.DataSource = data.DefaultView;
                GoodsSearch.Enabled = false;
                textBox1.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                    "from Goods A, Category B " +
                                                    "where CategoryID = B.ID and CategoryID in " +
                                                    "(select ID from Category where Animal = 0)", connection);
                DataTable data = new DataTable();
                SqlDataReader dataReader = command.ExecuteReader();
                data.Load(dataReader);
                connection.Close();
                dataGridView1.DataSource = data.DefaultView;
                GoodsSearch.Enabled = false;
                textBox1.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                GoodsSearch.Enabled = false;
                textBox1.Enabled = false;
                connection.Open();
                SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer from Goods A, Category B " +
                                                    "where CategoryID = B.ID and Number = 0", connection);
                DataTable data = new DataTable();
                SqlDataReader dataReader = command.ExecuteReader();
                data.Load(dataReader);
                connection.Close();
                dataGridView1.DataSource = data.DefaultView;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                GoodsSearch.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Goods " +
                                                "VALUES (@CategoryID," +
                                                "@Name," +
                                                "@Number," +
                                                "@Price," +
                                                "@Producer)", connection);

                cmd.Parameters.AddWithValue("@CategoryID", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@Name", textBox3.Text);
                cmd.Parameters.AddWithValue("@Number", numericUpDown2.Value);
                cmd.Parameters.AddWithValue("@Price", numericUpDown3.Value);
                cmd.Parameters.AddWithValue("@Producer", textBox2.Text);

                cmd.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                    "from Goods A, Category B " +
                                                    "where CategoryID = B.ID", connection);
                DataTable data = new DataTable();
                SqlDataReader dataReader = command.ExecuteReader();
                data.Load(dataReader);
                connection.Close();
                dataGridView1.DataSource = data.DefaultView;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                connection.Close();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви дійсно бажаєте видалити виділені рядки?", "Видалення рядків", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command;
                DataTable data;
                SqlDataReader dataReader;
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    command = new SqlCommand("delete from Goods where ID = " + item.Cells[0].Value, connection);
                    data = new DataTable();
                    dataReader = command.ExecuteReader();
                    data.Load(dataReader);
                }
                command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                         "from Goods A, Category B " +
                                         "where CategoryID = B.ID", connection);
                data = new DataTable();
                dataReader = command.ExecuteReader();
                data.Load(dataReader);
                connection.Close();
                dataGridView1.DataSource = data.DefaultView;
            }
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer from Goods A, Category B " +
                                                "where CategoryID = B.ID", connection);
            DataTable data = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            data.Load(dataReader);
            dataGridView1.DataSource = data.DefaultView;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Animal");
            comboBox1.Items.Add("non Animal");
            comboBox1.Items.Add("Out of stock");
            comboBox1.Items.Add("Search by Name");

            command = new SqlCommand("select distinct ID, Name from Category", connection);
            data = new DataTable();
            dataReader = command.ExecuteReader();
            data.Load(dataReader);
            connection.Close();
            dataGridView2.DataSource = data.DefaultView;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = dataGridView1.SelectedRows[0];
            //Form2 fm2 = new Form2(this);
            using (var fm2 = new Form2(this))
            {
                fm2.Category = decimal.Parse(item.Cells[1].Value.ToString());
                fm2.NameT = item.Cells[3].Value.ToString().Trim();
                fm2.Number = decimal.Parse(item.Cells[4].Value.ToString());
                fm2.Price = decimal.Parse(item.Cells[5].Value.ToString());
                fm2.Producer = item.Cells[6].Value.ToString().Trim();
                fm2.ID = decimal.Parse(item.Cells[0].Value.ToString());
                fm2.ShowDialog();  // execution of Form1 stops until Form2 is closed
            }
            connection.Open();
            SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                "from Goods A, Category B " +
                                                "where CategoryID = B.ID", connection);
            DataTable data = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            data.Load(dataReader);
            connection.Close();
            dataGridView1.DataSource = data.DefaultView;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Default_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                "from Goods A, Category B " +
                                                "where CategoryID = B.ID", connection);
            DataTable data = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            data.Load(dataReader);
            dataGridView1.DataSource = data.DefaultView;
            connection.Close();
        }

        private void CatSearch_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = dataGridView2.SelectedRows[0];
            connection.Open();
            SqlCommand command = new SqlCommand("select A.ID, CategoryID, B.Name as Category, A.Name, Number, Price, Producer " +
                                                "from Goods A, Category B " +
                                                "where CategoryID = B.ID and CategoryID = "+item.Cells[0].Value, connection);
            DataTable data = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            data.Load(dataReader);
            dataGridView1.DataSource = data.DefaultView;
            connection.Close();
        }
    }
}