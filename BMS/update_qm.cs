using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class update_qm : Form
    {
        public update_qm()
        {
            InitializeComponent();
            label7.Visible=false;
            button1.Visible=false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox3.Text)|| string.IsNullOrEmpty(rep_name.Text))
            {
                label7.Visible=true;
                label7.ForeColor = Color.DarkRed;
                label7.Text = "The fields cannot be empty!";
            }
            else
            {
                label7.Visible = true;
                label7.ForeColor= Color.DarkGreen;
                label7.Text = "Submission Sucessful!";
                button1.Visible = true;

               

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label7.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_qm.ResetAllControls(this);
            button1.Visible= false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(1999, 1, 11);
            dateTimePicker1.MaxDate = DateTime.Today;

            // Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < 0) {
                numericUpDown1.Value= 0;
            }
            else if(numericUpDown1.Value > 1000 ){
                numericUpDown1.Value= 1000;
            }
            numericUpDown1.Maximum = 100;
            numericUpDown1.Minimum = 0;
        }
    }

}
