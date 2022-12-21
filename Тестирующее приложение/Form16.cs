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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            textBox1.Text = "Пример ответа: 1,2,3,4,5,6,7";
            textBox1.ForeColor = Color.Gray;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4,6,2,5,7,1" || textBox1.Text == "4,6,5,2,7,1")
            {
                Form3.k = Form3.k + 1;
            }
            Hide();
            Form17 f = new Form17();
            f.ShowDialog();
            Close();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Пример ответа: 1,2,3,4,5,6,7")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
