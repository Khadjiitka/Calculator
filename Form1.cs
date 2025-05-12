using System;
using System.Drawing;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  this.Load += Form1_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single a, b, c = 0;
            if (Single.TryParse(textBox1.Text, out a) && Single.TryParse(textBox2.Text, out b))
            {
                switch (comboBox1.SelectedItem)
                {
                    case "+": c = a + b; break;
                    case "-": c = a - b; break;
                    case "*": c = a * b; break;
                    case "/": c = b != 0 ? a / b : Single.NaN; break;
                    default: MessageBox.Show("Choose operation!"); return;
                }
                MessageBox.Show($"{c}");
            }
            else MessageBox.Show("Error! Please enter a valid nuber!");
        }

    }
}