using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrid_project
{
    internal class UCManagement
    {
        public static void changeUserControl(UserControl userControl, Panel panel)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
