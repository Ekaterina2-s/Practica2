using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PerfomOperation(Func<object, object, object> value)
        {
            throw new NotImplementedException();
        }

        private void PerfomOperation(Func<double, double, double> operation)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = operation(num1, num2);
                label1.Text = $"Результат: {result}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerfomOperation((a, b) => a + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerfomOperation((a, b) => a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerfomOperation((a, b) => a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PerfomOperation((a, b) =>
            {
                if (b == 0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return 0;
                }
                return a / b;
            });
        }
    }
}
