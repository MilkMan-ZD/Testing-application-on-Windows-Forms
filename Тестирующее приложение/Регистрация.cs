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
    public partial class Регистрация : Form
    {
      static public int b = 0;
        static public string userName;
        static public string userFam;
        public Регистрация()
        {
            InitializeComponent();
            textBox1.Text = "Введите имя";
            textBox2.Text = "Введите фамилию";
            textBox2.ForeColor = Color.Gray;
            textBox1.ForeColor = Color.Gray;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите фамилию")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите фамилию";
                textBox2.ForeColor = Color.Gray;
            }
        }
        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите имя";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "" || textBox1.Text == "" && textBox1.Text == "" || textBox1.Text == "Введите имя" && textBox2.Text == "Введите фамилию" || textBox1.Text == "Введите имя"|| textBox2.Text == "Введите фамилию")
            {
                MessageBox.Show("Вы не прошли регистрацию, заполните все предоставленные поля");
            }
            else
            {
                userName = textBox2.Text;
                userFam = textBox1.Text;
                Регистрация.b = Регистрация.b + 1;
                Hide();
                Form1 t = new Form1();
                t.ShowDialog();
                Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 t = new Form1();
            t.ShowDialog();
            Close();
        }
    }
}
