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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }       
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                Form3.k = Form3.k + 1;
            }
            Hide();
            Form5 f = new Form5();
            f.ShowDialog();
            Close();
        }
    }
}
