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
    public partial class Form1 : Form
    {
       static public int b = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1.b = Регистрация.b + 1;
            if (b==1)
            {
                MessageBox.Show("Вы не прошли регистрацию");
            }
            else
            {
                Hide();
                Form3 f = new Form3();
                f.ShowDialog();
                Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Регистрация t = new Регистрация();
            t.ShowDialog();
            Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            О_программе t = new О_программе();
            t.ShowDialog();
            Close();
        }
    }
}
