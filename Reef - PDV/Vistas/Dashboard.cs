using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reef___PDV.Vistas
{
    public partial class Dashboard : Form
    {
        int ProfileClick = 0;
        int expand = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ProfileMenu.Visible = false;
            ProfileMenu.Location = new Point(1186, 68);            
        }

        private void ProfileTag_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            string Time = DateTime.Now.ToString("HH:mm");
            string Date = DateTime.Now.ToString("ddd d, MMM").ToUpper();
            LblHour.Text = Time;
            LblDate.Text = Date;
        }

        private void BtnCerrarRecordatorio_Click(object sender, EventArgs e)
        {
            PanelBienvenida.Visible = false;
            PanelDashboard.Location = new Point(178,76);
            PanelDashboard.Size = new Size(1181, 680);            
        }

        // -- Animaciones de los Menús --
        private void PanelVender_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 20);
            PanelVender.BackColor = Color.FromArgb(44, 49, 52);            
        }

        private void PanelProductos_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 94);
            PanelProductos.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelReportes_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 166);
            PanelReportes.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelInventario_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 238);
            PanelInventario.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelCorte_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 310);
            PanelCorte.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelAnalisis_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 382);
            PanelAnalisis.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelOfertas_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 454);
            PanelOfertas.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelAjustes_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 526);
            PanelAjustes.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelRelleno_MouseEnter(object sender, EventArgs e)
        {
            MenuSelector.Location = new Point(0, 598);
            PanelRelleno.BackColor = Color.FromArgb(44, 49, 52);
        }

        private void PanelVender_MouseLeave(object sender, EventArgs e)
        {
            PanelVender.BackColor = Color.FromArgb(35, 39, 41);           
        }

        private void PanelProductos_MouseLeave(object sender, EventArgs e)
        {
            PanelProductos.BackColor = Color.FromArgb(35, 39, 41);
        }

        private void PanelReportes_MouseLeave(object sender, EventArgs e)
        {
            PanelReportes.BackColor = Color.FromArgb(35, 39, 41);
        }

        private void PanelInventario_MouseLeave(object sender, EventArgs e)
        {
            PanelInventario.BackColor = Color.FromArgb(35, 39, 41);
        }

        private void PanelCorte_MouseLeave(object sender, EventArgs e)
        {
            PanelCorte.BackColor = Color.FromArgb(35, 39, 41);
        }

        private void PanelAnalisis_MouseLeave(object sender, EventArgs e)
        {
            PanelAnalisis.BackColor = Color.FromArgb(35, 39, 41);
        }

        private void PanelOfertas_MouseLeave(object sender, EventArgs e)
        {
            PanelOfertas.BackColor = Color.FromArgb(35, 39, 41);
        }

        private void PanelAjustes_MouseLeave(object sender, EventArgs e)
        {
            PanelAjustes.BackColor = Color.FromArgb(35, 39, 41);
        }

        private void PanelRelleno_MouseLeave(object sender, EventArgs e)
        {
            PanelRelleno.BackColor = Color.FromArgb(35, 39, 41);
        }

        // -- Fin Animaciones de los Menús --

        public void ProfileClicks()
        {
            if (ProfileClick == 1)
            {
                ProfileMenu.Visible = true;
            }
            else
            {
                ProfileClick = 0;
                ProfileMenu.Visible = false;                
            }
        }

        private void ProfileImage_Click(object sender, EventArgs e)
        {
            ProfileClick += 1;
            ProfileClicks();
            ProfileMenu.Size = new Size(180, 0);
            TimerProfile.Enabled = true;         
        }
        
        private void TimerProfile_Tick(object sender, EventArgs e)
        {
            expand += 2;
            ProfileMenu.Size = new Size(180, expand);
            if (expand >= 250)
            {                
                TimerProfile.Enabled = false;
                ProfileMenu.Size = new Size(180, 250);
            }
        }
    }    
}
