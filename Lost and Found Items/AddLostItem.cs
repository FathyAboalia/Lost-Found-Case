using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lost_and_Found_Items
{
    public partial class AddLostItem : Form
    {
        public AddLostItem()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "بطاقة هوية";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("جواز سفر");
                comboBox1.Items.Add("بطاقة شخصية");
                comboBox1.Items.Add("كارنية النادى");
                comboBox1.Items.Add("كارنية النقابة");
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
                textBox2.Text = "";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Text = "رخصة شخصية / قيادة";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            else
                textBox2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton2.Checked)
            {
                textBox2.Text = "بطاقة إئتمانية / فيزا";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            else
                textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "جواز سفر")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("مصرى");
                comboBox2.Items.Add("أمريكى");
                comboBox2.Items.Add("اوروبى");
                comboBox2.Items.Add("أسيوى");
                comboBox2.Items.Add("أخرى");
            }
            else if (comboBox1.Text == "بطاقة شخصية")
            {
                comboBox2.Text = "";
                comboBox2.Enabled = false;
            }
            else if (comboBox1.Text == "كارنية النادى")
            {
                comboBox2.Text = "";
                comboBox2.Enabled = false;
            }
            else if (comboBox1.Text == "كارنية النقابة")
            {
                comboBox2.Text = "";
                comboBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddLostItem_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            comboBox1.Text = "جواز سفر";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
