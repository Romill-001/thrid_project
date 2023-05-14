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
    public partial class UCConclusion : UserControl
    {
        public UCConclusion()
        {
            InitializeComponent();
        }

        private void map_Click(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Controls.Add(mainForm.map);
            mainForm.map.BringToFront();
        }
    }
}
