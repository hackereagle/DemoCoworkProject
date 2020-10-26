using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RORZE.Assembly;

namespace RORZE
{
    public partial class Form1 : Form
    {
        #region Private Field
        private ITest test;
        private IUcOutput ucOutput;
        #endregion Private Field

        public Form1()
        {
            InitializeComponent();
            test = new ImpITest();
            ucOutput = new UserControl1();
            ((UserControl)this.ucOutput).Location = new System.Drawing.Point(31, 37);
            ((UserControl)this.ucOutput).Name = "userControl11";
            ((UserControl)this.ucOutput).Size = new System.Drawing.Size(129, 102);
            ((UserControl)this.ucOutput).TabIndex = 1;
            this.Controls.Add((UserControl)ucOutput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = test.testing();
            this.label1.Text = ucOutput.Text;
        }
    }
}
