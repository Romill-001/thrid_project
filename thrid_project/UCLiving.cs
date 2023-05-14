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
                mainForm.ActiveForm.Controls.Add(mainForm.hl);
                mainForm.hl.BringToFront();
            }
            else
            {
                mainForm.ActiveForm.Controls.Add(mainForm.tc);
                mainForm.tc.BringToFront();
            }
        }

        private void Hotel_Click(object sender, EventArgs e)
        {
            mainForm.atr.TypeOfHouse = 0;
            panel2.Enabled= false;
            panel3.Enabled= false;
            panel4.Enabled= false;
            btnNext.Visible = true;
        }

        private void Hostel_Click(object sender, EventArgs e)
        {
            mainForm.atr.TypeOfHouse = 1;
            panel1.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            btnNext.Visible = true;
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            mainForm.atr.TypeOfHouse = 2;
            panel2.Enabled = false;
            panel1.Enabled = false;
            panel4.Enabled = false;
            btnNext.Visible = true;
        }

        private void Poh_Click(object sender, EventArgs e)
        {
            mainForm.atr.TypeOfHouse = 3;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel1.Enabled = false;
            btnNext.Visible = true;
            check = true;
        }
    }
}
