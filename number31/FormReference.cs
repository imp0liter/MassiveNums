using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // класс для доступа к локальным и удалённым процессам, здесь он для перехода по ссылке на кнопке Razr

namespace number31
{
    public partial class FormReference : Form
    {
        public FormReference()
        {
            InitializeComponent();
        }

        private void FormReference_Load(object sender, EventArgs e)
        {
            
        }

        private void Exit(object sender, EventArgs e) // закрыть приложение
        {
            Application.Exit();
        }

        private void back(object sender, EventArgs e) // переход в другое окно
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void Razr(object sender, EventArgs e) // Переход на страницу разрабочика для связи с ним
        {
            Process.Start("https://vk.com/imp0lite");
        }

        private void Spravka(object sender, EventArgs e) // справочный материал по пользованию программой
        {
            Spravka reference = new Spravka();
            reference.Show();
        }
    }
}
