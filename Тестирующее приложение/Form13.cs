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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                Form3.k = Form3.k + 1;
            }
            Hide();
            Form14 f = new Form14();
            f.ShowDialog();
            Close();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
        }
    }
}
