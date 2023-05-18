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

        private void publictr_Click(object sender, EventArgs e)
        {
            panelrent.Enabled=false;
            paneltaxi.Enabled=false;
            panelwalking.Enabled=false;
            MainForm.atr.TypeOfTransport = 2;
            check = false;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void taxi_Click(object sender, EventArgs e)
        {
            panelrent.Enabled = false;
            panelpublic.Enabled = false;
            panelwalking.Enabled = false;
            MainForm.atr.TypeOfTransport = 1;
            check = false;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void walking_Click(object sender, EventArgs e)
        {
            panelrent.Enabled = false;
            paneltaxi.Enabled = false;
            panelpublic.Enabled = false;
            MainForm.atr.TypeOfTransport = 0;
            check = true;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void autorent_Click(object sender, EventArgs e)
        {
            panelpublic.Enabled = false;
            paneltaxi.Enabled = false;
            panelwalking.Enabled = false;
            MainForm.atr.TypeOfTransport = 3;
            check = false;
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                MainForm.ActiveForm.Controls.Add(MainForm.certaintr);
                MainForm.certaintr.Visible = true;
                MainForm.certaintr.BringToFront();
            }
            else
            {
                MainForm.ActiveForm.Controls.Add(MainForm.zavtrak);
                MainForm.zavtrak.Visible = true;
                MainForm.zavtrak.BringToFront();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
            MainForm.tc = new UCTransportChoice();
            MainForm.tc.Location = new Point(0, 130);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelpublic.Enabled = true;
            paneltaxi.Enabled = true;
            panelwalking.Enabled = true;
            panelrent.Enabled = true;
            btnNext.Visible = false;
            btnCancel.Visible = false;
            MainForm.atr.TypeOfTransport = -1;
        }

        private void UCTransportChoice_MouseEnter(object sender, EventArgs e)
        {
            label_country.Text = MainForm.atr.Country_Name + ", " + MainForm.atr.TownName;
        }
    }
}
