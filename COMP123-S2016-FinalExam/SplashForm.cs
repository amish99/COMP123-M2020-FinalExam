using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // this will hide the splash form screen and then it will show generate form
        
        private void splashformtimer_Tick(object sender, EventArgs e)
        {
            Program.generatenameform.Show();
            this.Hide();
            splashformtimer.Enabled = false;
        }
    }
}
