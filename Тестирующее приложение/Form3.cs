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
    public partial class Form3 : Form
    {
        static public int k = 0;
        public Form3()
        {
            InitializeComponent();
            textBox1.Text = "Пример ответа: А1,Б2,В3,Г4";
            textBox1.ForeColor = Color.Gray;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "А1,Б2,В4,Г3")
            {
                Form3.k = Form3.k + 1;
            }           
                Hide();
                Form4 f = new Form4();
                f.ShowDialog();
                Close();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Пример ответа: А1,Б2,В3,Г4")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
