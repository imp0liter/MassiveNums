using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number31
{
    public partial class FormReference : Form
    {
        public FormReference()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) // закрыть приложение
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) // переход в другое окно
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
