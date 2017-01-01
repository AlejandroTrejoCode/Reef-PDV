using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reef___PDV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }        
        private void statusMenu_Paint(object sender, PaintEventArgs e)
        {
            //Create Border-Bottom
            //ControlPaint.DrawBorder(e.Graphics, this.statusMenu.ClientRectangle, Color.FromArgb(165, 182, 195), ButtonBorderStyle.Solid);
        }
    }
}
