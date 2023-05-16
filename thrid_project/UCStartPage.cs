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
    public partial class UCStartPage : UserControl
    {
        DataBase db = new DataBase();
        DataTable dt;
        public string TownFrom { get; set; }
        public string TownTo { get; set; }
        public string Place1 { get; set; }
        public string Place2 { get; set; }

        public UCStartPage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MainForm.atr.License = radioButtonLicenseYes.Checked;
            if ((radioButtonLicenseNo.Checked || radioButtonLicenseYes.Checked) && comboBoxFromTown.SelectedItem!=null && comboBoxToTown.SelectedItem!=null && place1.SelectedItem!=null)
            {
                MainForm.ActiveForm.Controls.Add(MainForm.tr);
                MainForm.tr.Visible = true;
                MainForm.tr.BringToFront();
            }
            else
            {
                MessageBox.Show("Вы сделали выбор не во всех полях");
            }
            GetCountry();
            
        }

        private void TownFromChoice(object sender, EventArgs e)
        {
            TownFrom = comboBoxFromTown.SelectedItem.ToString();
            switch(TownFrom)
            {
                case "Казань": MainForm.atr.TownFrom = 0; break;
                case "Москва": MainForm.atr.TownFrom = 7; break;
                case "Санкт-Петербург": MainForm.atr.TownFrom = 8; break;

            }
        }
        private void TownToChoice(object sender, EventArgs e)
        {
            TownTo = comboBoxToTown.SelectedItem.ToString();
            switch (TownTo)
            {
                case "Казань": MainForm.atr.TownTo = 0; break;
                case "Москва": MainForm.atr.TownTo = 7; break;
                case "Санкт-Петербург": MainForm.atr.TownTo = 8; break;
            }
        }

        private void Place1Choice(object sender, EventArgs e)
        {
            Place1 = place1.SelectedItem.ToString();
            switch (Place1)
            {
                case "Алма-Ата": MainForm.atr.Place1 =1; break;
                case "Абу-Даби": MainForm.atr.Place1 = 2; break;
                case "Анталия": MainForm.atr.Place1 = 3; break;
                case "Хургада": MainForm.atr.Place1 = 4; break;
                case "Тбилиси": MainForm.atr.Place1 = 5; break;
                case "Бангкок": MainForm.atr.Place1 = 6; break;
                case "Астана": MainForm.atr.Place1 = 9; break;
                case "Дубай": MainForm.atr.Place1 = 10; break;
                case "Белек": MainForm.atr.Place1 = 11; break;
                case "Батуми": MainForm.atr.Place1 = 12; break;
                case "Пхукет": MainForm.atr.Place1 = 13; break;
            }
        }

        private void GetCountry()
        {
            db.ConnectionOpen();
            string que = $"select * from Towns where Town_ID={MainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que);
            MainForm.atr.Country_ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            string que2 = $"select * from Countries where Country_ID={MainForm.atr.Country_ID}";
            dt = SQLServer.ExecuteQuerySelect(que2);
            MainForm.atr.Country_Name = dt.Rows[0].ItemArray[1].ToString();
            string que3 = $"select * from Towns where Town_ID={MainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que3);
            MainForm.atr.TownName = dt.Rows[0].ItemArray[1].ToString();
            MainForm.atr.LatitudeTownPlace1 = double.Parse(dt.Rows[0].ItemArray[3].ToString());
            MainForm.atr.LongitudeTownPlace1 = double.Parse(dt.Rows[0].ItemArray[2].ToString());
            string que4 = $"select * from Towns where Town_ID={MainForm.atr.TownTo}";
            dt = SQLServer.ExecuteQuerySelect(que4);
            MainForm.atr.LongitudeTownTo = double.Parse(dt.Rows[0].ItemArray[2].ToString());
            MainForm.atr.LatitudeTownTo = double.Parse(dt.Rows[0].ItemArray[3].ToString());
            string que5 = $"select * from Towns where Town_ID={MainForm.atr.TownFrom}";
            dt = SQLServer.ExecuteQuerySelect(que5);
            MainForm.atr.LatitudeTownFrom = double.Parse(dt.Rows[0].ItemArray[3].ToString());
            MainForm.atr.LongitudeTownFrom = double.Parse(dt.Rows[0].ItemArray[2].ToString());
            db.ConnectionClose();
        }
    }
}