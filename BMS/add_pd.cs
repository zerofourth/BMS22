using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BMS
{
    public partial class add_pd : Form
    {
        public add_pd()
        {
            InitializeComponent();
        }

        private void add_pd_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https:/www.google.com");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) == false && string.IsNullOrEmpty(lastname.Text) == false && string.IsNullOrEmpty(address_rtb.Text) == false && string.IsNullOrEmpty(dob.Text) == false && string.IsNullOrEmpty(forceno.Text) == false && string.IsNullOrEmpty(doj.Text) == false)
            {
                if ((new Regex(@"^[A-Za-z]+$")).IsMatch(firstname.Text) == false || (new Regex(@"^[A-Za-z]+$")).IsMatch(lastname.Text) == false || (new Regex(@"^(0|[1-9][0-9]*)$")).IsMatch(forceno.Text) == false)
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
                        MessageBox.Show("Data has been succesfully submitted ", "Submission succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please fill all the mandatory details", "Warning", MessageBoxButtons.OK);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 12;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void rank_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void trade_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void paygrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
    }
}
