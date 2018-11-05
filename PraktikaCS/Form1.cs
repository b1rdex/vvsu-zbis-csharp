using System;
using System.Windows.Forms;

namespace PraktikaCS
{
    public partial class Form1 : Form
    {
        void graph()
        {
            double a, b, c = 0;
            a = getValue(boxA);
            b = getValue(boxB);
            c = getValue(boxC);
            int maxX = Convert.ToInt16(getValue(boxX));
            if (a == 0)
            {
                MessageBox.Show("Коэффициент a не может равняться 0", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maxX == 0)
            {
                MessageBox.Show("Максимальное x не может равняться 0", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2 newForm = new Form2(a, b, c, maxX * 2);
                newForm.Show();
            }
        }

        private double getValue(TextBox box)
        {
            try
            {
                return Convert.ToDouble(box.Text.Replace('.', ',').Replace(" ", ""));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильное значение коэффициента", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph();
        }
    }
}
