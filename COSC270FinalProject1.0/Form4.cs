﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC270FinalProject1._0
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://www.gutenberg.org/");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
