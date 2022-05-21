using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    //Angel McDaniel
    public partial class Activity8 : Form
    {
        public Activity8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Calories from Fat: " + FatCalories(int.Parse(textBox1.Text));
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            label2.Text = "Calories from Carbs: " + CarbCalories(int.Parse(textBox2.Text));
        }

        private static int FatCalories(int Fat)
        {
            return Fat * 9;
        }

        private static int CarbCalories(int Carbs)
        {
            return Carbs * 4;
        }
    }
}
