using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressIt
{
    public partial class Form1 : Form
    {
        bool running;
        public Form1()
        {
            InitializeComponent();
            running = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NativeMethods.SendF15();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(false == running)
            {
                btnStart.Text = "&Stop";
                timer1.Start();
                running = true;
            }else
            {
                btnStart.Text = "&Start";
                timer1.Stop();
                running = true;
            }
        }
    }
}
