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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                Form3.k = Form3.k + 1;
            }
            Hide();
            Form13 f = new Form13();
            f.ShowDialog();
            Close();
        }
    }
}
