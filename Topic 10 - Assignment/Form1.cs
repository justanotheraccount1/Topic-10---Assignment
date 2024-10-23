using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPenguins_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.pensLogo;
            lblInfo.Visible = true;
            lblInfo.Text = "The Pitsburgh Penguins are an NHL team in the Metropolitain Division. " +
                "They have won 5 Stanley Cups.";
        }

        private void btnStars_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.starsLogo;
            lblInfo.Visible = true;
            lblInfo.Text = "The Dallas Stars are an NHL team in the Central Division. " +
                "They have won 1 Stanley Cup.";
        }

        private void btnBruins_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.bruinsLogo;
            lblInfo.Visible = true;
            lblInfo.Text = "The Boston Bruins are an NHL team in the Atlantic Division. " +
                "They have won 6 Stanley Cups.";
        }

        private void btnKraken_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.krakenLogo_2_;
            lblInfo.Visible = true;
            lblInfo.Text = "The Seatle Kraken are an NHL team in the Pacific Division. " +
                "They are the newest NHL franchise.";
        }

        private void btnLeafs_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.leafsLogo_1_;
            lblInfo.Visible = true;
            lblInfo.Text = "The Toronto Maple Leafs are an NHL team in the Atlantic Division. " +
                "They have won 13 Stanley Cups.";
        }

        private void btnDevils_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.devilsLogo;
            lblInfo.Visible = true;
            lblInfo.Text = "The New Jersey Devils are an NHL team in the Metropolitain Division. " +
                "They have won 3 Stanley Cups.";
        }

        private void btnKings_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.kingsLogo_1_;
            lblInfo.Visible = true;
            lblInfo.Text = "The Los Angeles Kings are an NHL team in the Pacific Division. " +
                "They have won 2 Stanley Cups.";
        }

        private void btnBlackhawks_MouseHover(object sender, EventArgs e)
        {
            imgLogos.Visible = true;
            imgLogos.Image = Properties.Resources.blackhawksLogo;
            lblInfo.Visible = true;
            lblInfo.Text = "The Boston Bruins are an NHL team in the Central Division. " +
                "They have won 6 Stanley Cups.";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            imgLogos.Visible = false;
            lblInfo.Visible = false;
        }
    }
}
