using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                picHeart.Top -= 10;

            }
            else if (e.KeyChar == 's')
            {
                picHeart.Top += 10;
            }
            else if (e.KeyChar == 'a')
            {
                picHeart.Left -= 10;
            }
            else if (e.KeyChar == 'd')
            {
                picHeart.Left += 10;
            }
            else if (e.KeyChar == 'p')
            {
                Size icon = picHeart.Size;
                icon.Height -= 10;
                icon.Width -= 10;
                picHeart.Size = icon;
            }
        }
    }
}
