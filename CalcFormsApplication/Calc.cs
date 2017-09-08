using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcFormsApplication
{
    public partial class Calc : Form
    {

        public Calc()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if ( ValidateText(textBox1.Text) && ValidateText(textBox2.Text))
            {
                int result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("正しい値を入力してください");
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (ValidateText(textBox1.Text) && ValidateText(textBox2.Text))
            {
                int result = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("正しい値を入力してください");
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (ValidateText(textBox1.Text) && ValidateText(textBox2.Text))
            {
                int result = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("正しい値を入力してください");
            }

        }

        private void div_Click(object sender, EventArgs e)
        {
            if (ValidateText(textBox1.Text) && ValidateText(textBox2.Text))
            {
                if (textBox2.Text == "0")
                {
                    MessageBox.Show("0での除算はできません");
                }
                else
                {
                    int result = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                    textBox3.Text = result.ToString();
                }
            }
            else
            {
                MessageBox.Show("正しい値を入力してください");
            }
        }

        private bool ValidateText(string s)
        {
            //引数cが数字かどうかを判定
            if (!s.All( c => Char.IsDigit(c)))
            {
                return false;
            }
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            return true;
        }

    }
}
