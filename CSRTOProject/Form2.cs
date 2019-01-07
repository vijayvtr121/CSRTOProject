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

namespace CSRTOProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Registration1' table. You can move, or remove it, as needed.
            this.registration1TableAdapter.Fill(this.database1DataSet1.Registration1);
            // TODO: This line of code loads data into the 'database1DataSet.Licence' table. You can move, or remove it, as needed.
            this.licenceTableAdapter.Fill(this.database1DataSet.Licence);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            string myConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\imjAY\source\repos\CSRTOProject\CSRTOProject\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(myConnectionString);
            comando.Connection = conn;
            comando.CommandText = "SELECT COUNT(*) FROM Licence";
            conn.Open();
            textBox1.Text = comando.ExecuteScalar().ToString();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            string myConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\imjAY\source\repos\CSRTOProject\CSRTOProject\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(myConnectionString);
            comando.Connection = conn;
            comando.CommandText = "SELECT COUNT(*) FROM Registration1";
            conn.Open();
            textBox2.Text = comando.ExecuteScalar().ToString();
            conn.Close();
        }
    }
}
