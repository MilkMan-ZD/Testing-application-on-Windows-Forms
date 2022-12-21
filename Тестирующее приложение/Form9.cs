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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            textBox1.Text = "Пример ответа: линейный";
            textBox1.ForeColor = Color.Gray;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
            "линейный",
            "комбинированный",
            "разветвляющийся",
            "циклический"
        };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "комбинированный")
            {
                Form3.k = Form3.k + 1;
            }
                Hide();
                Form10 f = new Form10();
                f.ShowDialog();
                Close();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Пример ответа: линейный")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
