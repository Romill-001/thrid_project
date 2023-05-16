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
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void taxi_Click(object sender, EventArgs e)
        {
            panelrent.Enabled = false;
            panelpublic.Enabled = false;
            panelwalking.Enabled = false;
            MainForm.atr.TypeOfTransport = 1;
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
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Add(MainForm.certaintr);
            MainForm.certaintr.Visible = true;
            MainForm.certaintr.BringToFront();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelpublic.Enabled = true;
            paneltaxi.Enabled = true;
            panelwalking.Enabled = true;
            panelrent.Enabled = true;
            btnNext.Visible = false;
        }

        private void UCTransportChoice_MouseEnter(object sender, EventArgs e)
        {
            label_country.Text = MainForm.atr.Country_Name + ", " + MainForm.atr.TownName;
        }
    }
}
