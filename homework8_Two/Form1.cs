using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8_Two
{
    //Михаил Анкудинов

    //Создайте простую форму на котором свяжите свойство Text 
    //элемента TextBox со свойством Value элемента NumericUpDown


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Text<->Value";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Value = decimal.Parse(textBox1.Text);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Некорректный ввод: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Некорректный ввод: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //numericUpDown1.Select(0, numericUpDown1.Text.Length); 
        }
    }
}
