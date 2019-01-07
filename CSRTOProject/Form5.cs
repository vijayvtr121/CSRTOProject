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
using System.IO;

namespace CSRTOProject
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\imjAY\source\repos\CSRTOProject\CSRTOProject\Database1.mdf;Integrated Security=True");
        private SqlInfoMessageEventHandler con_InfoMessage;

        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Registration1 values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+comboBox1.Text+ "','" + comboBox2.Text + "','"+textBox4.Text+"','"+textBox5.Text+"','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("submitted");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand();
            string myConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\imjAY\source\repos\CSRTOProject\CSRTOProject\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(myConnectionString);
            comando.Connection = conn;
            comando.CommandText = "SELECT * FROM Registration1";
            conn.Open();
            textBox7.Text = comando.ExecuteScalar().ToString();
            conn.Close();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 openForm = new Form3();
            openForm.Show();
           


        }
    }
    
}
