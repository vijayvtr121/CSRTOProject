using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSRTOProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                if(textBox1.Text=="vijay"&&textBox2.Text=="12345")
                {
                    MessageBox.Show("EMPLYOEE Login Successful");
                    Form2 nextForm = new Form2();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Enter valid userid and password");
                }
            }
            else
            {
                if(radioButton2.Checked == true)
                {
                    MessageBox.Show("USER Login Successful");
                    Form3 nextForm = new Form3();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
