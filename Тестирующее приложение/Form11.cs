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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            textBox1.Text = "Пример ответа: 1,2,3";
            textBox1.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                Form3.k = Form3.k + 1;
            }
            Hide();
            Form12 f = new Form12();
            f.ShowDialog();
            Close();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Пример ответа: 1,2,3")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
