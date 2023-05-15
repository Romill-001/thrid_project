using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace thrid_project
{
    public partial class UCTransportChoice : UserControl
    {
        public bool check = false;
        public UCTransportChoice()
        {
            InitializeComponent();
        }

        private void UCTransportChoice_MouseMove(object sender, MouseEventArgs e)
        {
            label_country.Text = mainForm.atr.Country_Name + ", " + mainForm.atr.TownName;
            bebra.Text = $"Расстояние от {mainForm.atr.TiketTransportTypeLocation} до места проживания: {mainForm.atr.Distance} км";
            if (mainForm.atr.License == true && mainForm.atr.Distance > 3) 
            {
                panelwalking.Visible = false;
                panelwalking.Enabled = false;
                panelrent.Location = new Point(473, 429);
            }
            else if (mainForm.atr.License == false && mainForm.atr.Distance > 3)
            {
                panelwalking.Visible=false;
                panelwalking.Enabled = false;
                panelrent.Visible=false;
                panelrent.Enabled = false;
            }
            else if (mainForm.atr.License == false && mainForm.atr.Distance <= 3)
            {
                panelrent.Visible = false;
                panelrent.Enabled = false;
                panelwalking.Location = new Point(473, 429);
            }
        }

        private void publictr_Click(object sender, EventArgs e)
        {
            panelrent.Enabled=false;
            paneltaxi.Enabled=false;
            panelwalking.Enabled=false;
            mainForm.atr.TypeOfTransport = 2;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void taxi_Click(object sender, EventArgs e)
        {
            panelrent.Enabled = false;
            panelpublic.Enabled = false;
            panelwalking.Enabled = false;
            mainForm.atr.TypeOfTransport = 1;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void walking_Click(object sender, EventArgs e)
        {
            panelrent.Enabled = false;
            paneltaxi.Enabled = false;
            panelpublic.Enabled = false;
            mainForm.atr.TypeOfTransport = 0;
            check = true;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void autorent_Click(object sender, EventArgs e)
        {
            panelpublic.Enabled = false;
            paneltaxi.Enabled = false;
            panelwalking.Enabled = false;
            mainForm.atr.TypeOfTransport = 3;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Controls.Add(mainForm.certaintr);
            mainForm.certaintr.BringToFront();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Controls.Remove(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelpublic.Enabled = true;
            paneltaxi.Enabled = true;
            panelwalking.Enabled = true;
            panelrent.Enabled = true;
            btnNext.Visible = false;
        }
    }
}
