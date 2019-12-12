using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && // not a letter, and
                e.KeyChar != ' ' && // not a space, and
                e.KeyChar != '-' && // not a hyphen, and
                e.KeyChar != '.' )// not a stop
                {
                e.Handled = true; // ignore this character

            }
        }
    }
}
