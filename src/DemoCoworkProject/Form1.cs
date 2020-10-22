using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RORZE
{
    public partial class Form1 : Form
    {
        #region Private Field
        private ITest test;
        #endregion Private Field

        public Form1()
        {
            InitializeComponent();
            test = new ImpITest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = test.testing();
        }
    }
}
