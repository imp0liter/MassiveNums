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
    public partial class Form1 : Form
    {
        int[] array = new int[45]; // объявление массива
        Random random = new Random();
        int a = 1;
        int b = 45;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // создание массива
        {
            int i = 1;
            richTextBox1.Text = "";
            for (i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 999);
                richTextBox1.Text += (array[i].ToString() + " ");

            }
        }

        private void button2_Click(object sender, EventArgs e) // Нахождение максимального элемента в массиве 
        {
            int maxValue = array.Max<int>(); // нахождение методом расширения Max
            richTextBox2.Text = "";
            richTextBox2.Text += (maxValue); // вывод
        }

        private void button3_Click(object sender, EventArgs e) // сортировка по возрастанию
        {
            int i = 1;
            int j = 2;
            richTextBox3.Text = "";
            while (i < array.Length)
            {
                if (array[i - 1] <= array[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    int b = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = b;
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
            for (i = 0; i < array.Length; i++)
                    richTextBox3.Text += (array[i].ToString() + " ");
        }

        private void button4_Click(object sender, EventArgs e) // сортировка по убыванию
        {
            Array.Sort(array);
            Array.Reverse(array);
            int i = 1;
            richTextBox3.Text = "";
            for (i = 0; i < array.Length; i++)
                richTextBox3.Text += (array[i].ToString() + " ");

        }

        private void button7_Click(object sender, EventArgs e) // очистка 
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) // закрыть приложение
        {
                Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e) // переход в другое окно
        {
            this.Hide();
            FormReference formReference = new FormReference();
            formReference.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
