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
    public partial class UCMyVisits : UserControl
    {
        DataRow dt;
        public UCMyVisits(DataRow dt)
        {
            InitializeComponent();
            this.dt = dt;
        }
        public UCMyVisits()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
        }

        private void UCMyVisits_MouseEnter(object sender, EventArgs e)
        {
            lbltransport.Text = dt.ItemArray[5].ToString(); ;
            lbllivingplace.Text = dt.ItemArray[5].ToString(); ;
            transportname.Text = dt.ItemArray[5].ToString();
            housename.Text = dt.ItemArray[5].ToString();
            transportprice.Text = dt.ItemArray[5].ToString();
            houseprice.Text = dt.ItemArray[5].ToString();
            lblinfohouse.Text = dt.ItemArray[5].ToString();


        }
    }
}
