using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chicken_or_Egg
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void radChicken_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.ImageLocation = "../../Images/chicken.jpg";
        }

        private void radEgg_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.ImageLocation = "../../Images/egg.jpg";
        }
    }
}
