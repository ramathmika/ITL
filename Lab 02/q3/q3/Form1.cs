using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary;
            double.TryParse(textBox1.Text, out salary);
            string level = comboBox1.SelectedItem.ToString();
            //textBox2.Text = level;
            if (level == "Level1")
                textBox2.Text = (0.1 * salary).ToString();
            else if (level == "Level2" || level == "Level3" || level == "Level4")
                textBox2.Text = (0.09 * salary).ToString();
            else if (level == "Level5" || level == "Level6" || level == "Level7")
                textBox2.Text = (0.07 * salary).ToString();
            else
                textBox2.Text = (0.05 * salary).ToString();
        }
    }
}
