﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeoProgres(sender,e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void GeoProgres(object sender, EventArgs e)
        {
            try
            {
                int B1 = int.Parse(textB.Text);
                int Q = int.Parse(textQ.Text);
                int N = int.Parse(textN.Text);

                double Bn = B1 * Math.Pow(Q, N - 1);
                double sum = (Bn * Q - B1 / Q - 1);
                ResultLab.Text = @"Сума прогресії : "+sum.ToString();
            }
            catch (Exception ex)
            {
                ResultLab.Text = ex.Message;
            }
        }
    }
}
