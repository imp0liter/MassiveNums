﻿using System;
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
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void Spravka_Load(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e) // закрыть справку
        {
            this.Hide();
            FormReference formReference = new FormReference();
            formReference.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
