using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирующее_приложение
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            textBox1.Text = "Пример ответа: 1,2,3,4,5,6";
            textBox1.ForeColor = Color.Gray;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Пример ответа: 1,2,3,4,5,6")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4,5,3,1,6,2")
            {
                Form3.k = Form3.k + 1;
            }
                Hide();
                Form8 f = new Form8();
                f.ShowDialog();
                Close();
        }
    }
}
