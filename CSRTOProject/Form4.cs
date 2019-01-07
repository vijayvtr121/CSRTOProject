using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
namespace CSRTOProject
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\imjAY\source\repos\CSRTOProject\CSRTOProject\Database1.mdf;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox5.Text = openFileDialog1.FileName;
                string picpath = openFileDialog1.FileName.ToString();
                textBox5.Text = picpath;
                pictureBox1.ImageLocation = picpath;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imageBT = null;
            FileStream fs = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageBT = br.ReadBytes((int)fs.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Licence values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "',@pic,'" + textBox6.Text + "')";
            cmd.Parameters.Add(new SqlParameter("@pic", imageBT));
            cmd.ExecuteNonQuery();

            MessageBox.Show("saved");
            con.Close();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }
    }
}
