using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.SendToBack();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                //this.Hide();
            }
        }
    }
}
