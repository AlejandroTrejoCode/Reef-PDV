using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Reef___PDV
{
    //Create Border-Bottom
    //ControlPaint.DrawBorder(e.Graphics, this.statusMenu.ClientRectangle, Color.FromArgb(165, 182, 195), ButtonBorderStyle.Solid);
    public partial class Login : Form
    {
        //Capturar la Fecha
        public string date = DateTime.Now.ToString("dddd, d MMMM");
        public string hours = DateTime.Now.ToString("HH").ToUpper();

        public Login()
        {
            InitializeComponent();
        }       

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }       

        private void Login_Load(object sender, EventArgs e)
        {
            //Convetir la fecha a Capital y mostrarla.
            string Date = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date);
            LblDate.Text = Date;            
            goodMorning();            
        }
        public void goodMorning()
        {
            int hour = Convert.ToInt32(hours); 
            //Mensaje de Buenos días
            if (hour > 6 && hour < 11)
            {
                LblGoodMorning.Text = "¡Buenos días!";
            }
            else
            {
                if (hour > 11 && hour < 19)
                {
                    LblGoodMorning.Text = "¡Buenas tardes!";
                }

                LblGoodMorning.Text = "¡Buenas noches!";
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            //Actualizar la hora            
            string time = DateTime.Now.ToString("HH : mm").ToUpper();
            string AMPM = DateTime.Now.ToString("tt").ToUpper();
            LblHours.Text = time;
            LblAMPM.Text = AMPM;
        }

        private void PanelUser_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }    
}
