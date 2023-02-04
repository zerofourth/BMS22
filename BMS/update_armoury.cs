using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class update_armoury : Form
    {
        public update_armoury()
        {
            InitializeComponent();
            button1.Visible= false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(textBox2.Text) == false && string.IsNullOrEmpty(textBox3.Text) == false && string.IsNullOrEmpty(textBox4.Text) == false && string.IsNullOrEmpty(rep_name.Text) == false )
            {
                if ((new Regex(@"^[A-Za-z]+$")).IsMatch(textBox3.Text) == false )
                {
                    MessageBox.Show("Please enter valid data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string message = "Do you wish to submit the data ? ";
                    string title = "Confirm submission";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {

                    }
                    else if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Item added sucessfully","Confirmation",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        button1.Visible = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please fill all the mandatory details", "Warning", MessageBoxButtons.OK);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_qm.ResetAllControls(this);
            button1.Visible = false;
        }
    }
}
