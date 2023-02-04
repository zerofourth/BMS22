using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label5.Visible = false;
            label6.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "admin" || textBox2.Text!="root")
            {

                if(textBox1.Text != "admin")
                {
                    textBox1.BackColor = Color.Salmon;
                    label5.Text = "UserName does not match";
                    label5.Visible = true;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                    label5.Visible = false;
                }
                if (textBox2.Text != "root")
                {
                    textBox2.BackColor = Color.Salmon;
                    label6.Text = "Password does not match";
                    label6.Visible = true;
                }
                else
                {
                    textBox2.BackColor = Color.White;
                    label6.Visible = false;
                }
                //DialogResult res = MessageBox.Show("Invalid credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
             else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
               
                DialogResult res = MessageBox.Show("The username or password cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.activation);//Use your own filename in place of _15035
                player.Play();
                var myForm = new Form1();
                myForm.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Firefox", "https://crpf.gov.in/about-us.htm");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.BackColor = Color.White;
                label5.Text = "UserName Cannot be empty";
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.BackColor = Color.White;
                label6.Text = "Password Cannot be empty";
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }

        }
    }
}
