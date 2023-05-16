using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrid_project
{
    public partial class MainForm : Form
    {
        public static Atributes atr = new Atributes();
        public UCStartPage sp = new UCStartPage();
        public static UCTransport tr = new UCTransport();
        public static UCLiving lv = new UCLiving();
        public static UCHouseList hl = new UCHouseList();
        public static UCTransportChoice tc = new UCTransportChoice();
        public static UСChooseCertainTransport certaintr = new UСChooseCertainTransport();
        public static UCEating zavtrak = new UCEating(0);
        public static UCEating obed = new UCEating(1);
        public static UCEating uzhin = new UCEating(2);
        public static UCConclusion end = new UCConclusion();
        public static UCMap map = new UCMap();
        public MainForm()
        {
            InitializeComponent();
            sp.Location = new Point(0, 130);
            tr.Location = new Point(0, 130);
            lv.Location = new Point(0, 130);
            hl.Location = new Point(0, 130);
            tc.Location = new Point(0, 130);
            certaintr.Location = new Point(0, 130);
            zavtrak.Location = new Point(0, 130);
            obed.Location = new Point(0, 130);
            uzhin.Location = new Point(0, 130);
            map.Location = new Point(0, 130);
            end.Location = new Point(0, 130);
            zavtrak.next = obed;
            obed.next= uzhin;
            uzhin.next= end;
            tr.Visible = false;
            hl.Visible = false;
            certaintr.Visible = false;
            zavtrak.Visible = false;
            obed.Visible = false;
            uzhin.Visible = false;

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Controls.Add(sp);
            sp.BringToFront();
        }
    }
}
