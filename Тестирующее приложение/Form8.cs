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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true && checkBox8.Checked == true && checkBox7.Checked == true)
            {
                Form3.k = Form3.k + 1;
            }            
                Hide();
                Form9 f = new Form9();
                f.ShowDialog();
                Close();            
        }
    }
}
