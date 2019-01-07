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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Submitted");
                Form4 nextForm = new Form4();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else if(radioButton2.Checked == true)
            {

                MessageBox.Show("Submitted");
                Form5 nextForm = new Form5();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            this.Hide();
        }
    }
}
