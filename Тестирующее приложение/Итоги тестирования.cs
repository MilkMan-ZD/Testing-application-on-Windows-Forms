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
    public partial class Итоги_тестирования : Form
    {
        public Итоги_тестирования()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Регистрация.userName = "";
            Регистрация.userFam = "";
            Form3.k = 0;
            Регистрация.b = 0;
            Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = Регистрация.userName + " " + Регистрация.userFam;
            label4.Text = "Ваша оценка:";
            if (Form3.k < 7)
            {
                label1.Text = "2";
            }
            if (Form3.k == 7 || Form3.k == 8)
            {
                label1.Text = "3";
            }
            if (Form3.k == 10 || Form3.k == 11 || Form3.k == 12 || Form3.k == 13 || Form3.k == 9)
            {
                label1.Text = "4";
            }
            if (Form3.k == 14 || Form3.k == 15)
            {
                label1.Text = "5";
            }
        }
    }
}
