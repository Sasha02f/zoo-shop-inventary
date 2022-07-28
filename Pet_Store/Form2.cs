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
    public partial class Form2 : Form
    {
        public decimal Category
        {
            set { this.category.Value = value; }
            get { return this.category.Value; }
        }
        public string NameT
        {
            set { this.name.Text = value; }
            get { return this.name.Text; }
        }
        public decimal Number
        {
            set { this.number.Value = value; }
            get { return this.number.Value; }
        }
        public decimal Price
        {
            set { this.price.Value = value; }
            get { return this.price.Value; }
        }
        public string Producer
        {
            set { this.producer.Text = value; }
            get { return this.producer.Text; }
        }
        decimal id;
        public decimal ID
        {
            set { id = value; }
            get { return id; }
        }
        Form opener;
        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            opener.Enabled = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2HSGGU6M\MSSQLSERVER01;Initial Catalog=Pet_shop;Integrated Security=True");
            connection.Open();
            try
            {
                
                SqlCommand command = new SqlCommand("update Goods " +
                                                    "set CategoryID = @CatID, " +
                                                    "Name = @Name, " +
                                                    "Number = @Number, " +
                                                    "Price = @Price, " +
                                                    "Producer = @Producer " +
                                                    "where ID = @ID", connection);
                command.Parameters.AddWithValue("@CatID", Category);
                command.Parameters.AddWithValue("@Name", NameT);
                command.Parameters.AddWithValue("@Number", Number);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Producer", Producer);
                command.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                SqlDataReader dataReader = command.ExecuteReader();
                data.Load(dataReader);
                connection.Close();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                connection.Close();
            }
        }
    }
}
