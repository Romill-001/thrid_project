using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrid_project
{
    public partial class UCLiving : UserControl
    {
        bool check = false;
        public UCLiving()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                MainForm.ActiveForm.Controls.Add(MainForm.hl);
                MainForm.hl.Visible = true;
                MainForm.hl.BringToFront();
            }
            else
            {
                MainForm.ActiveForm.Controls.Add(MainForm.tc);
                MainForm.tc.Visible = true;
                MainForm.tc.BringToFront();
            }
        }

        private void Hotel_Click(object sender, EventArgs e)
        {
            MainForm.atr.TypeOfHouse = 0;
            panel2.Enabled= false;
            panel3.Enabled= false;
            panel4.Enabled= false;
            btnNext.Visible = true;
            btnCancel.Visible = true;
            check = false;
        }

        private void Hostel_Click(object sender, EventArgs e)
        {
            MainForm.atr.TypeOfHouse = 1;
            panel1.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            btnNext.Visible = true;
            btnCancel.Visible = true;
            check = false;
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            MainForm.atr.TypeOfHouse = 2;
            panel2.Enabled = false;
            panel1.Enabled = false;
            panel4.Enabled = false;
            btnNext.Visible = true;
            btnCancel.Visible = true;
            check = false;
        }

        private void Poh_Click(object sender, EventArgs e)
        {
            MainForm.atr.TypeOfHouse = 3;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel1.Enabled = false;
            btnNext.Visible = true;
            btnCancel.Visible = true;
            check = true;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
            MainForm.lv = new UCLiving();
            MainForm.lv.Location = new Point(0, 130);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel1.Enabled = true;
            panel4.Enabled = true;
            btnNext.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
