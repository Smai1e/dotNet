﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_lab_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void btnOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
