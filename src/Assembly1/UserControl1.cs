﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RORZE.Assembly
{
    public partial class UserControl1 : UserControl, IUcOutput
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        string IUcOutput.Text
        {
            get { return this.textBox1.Text; }
        }
    }
}
