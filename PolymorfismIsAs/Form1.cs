﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorfismIsAs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A obj;
            if (rbA.Checked)
            {
                obj = new A();
            }
            else
            {
                obj = new B();
            }

            if (obj is B)
            {
                B bObj = (obj as B);
                tbDescription.Text = bObj.Description();
            }
            else 
            {
                tbDescription.Text = obj.Description();
            }
            
        }
    }
}
