using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaPoprawa
{
    public partial class aInput : Form
    {
        public aInput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double a, b, c, ans1, ans2, ans3;
            a = double.Parse(aInputBox.Text);
            b = double.Parse(bInput.Text);
            c = double.Parse(cInput.Text);
            ans1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            ans2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            ans3 = (Math.Pow(b, 2) - 4 * a * c);
            ans1.Text = ans1.ToString("n2");
            ans2.Text = ans2.ToString("n2");
            ans3.Text = ans3.ToString("n2");
        }

        private void Tittle_Click(object sender, EventArgs e)
        {
            
        }

        private void Oblicz_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
