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
            mainForm.atr.License = radioButtonLicenseYes.Checked;
            if ((radioButtonLicenseNo.Checked || radioButtonLicenseYes.Checked) && comboBoxFromTown.SelectedItem!=null && comboBoxToTown.SelectedItem!=null && place1.SelectedItem!=null)
            {
                mainForm.ActiveForm.Controls.Add(mainForm.tr);
                mainForm.tr.BringToFront();
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
                case "Казань": mainForm.atr.TownFrom = 0; break;
                case "Москва": mainForm.atr.TownFrom = 7; break;
                case "Санкт-Петербург": mainForm.atr.TownFrom = 8; break;

            }
        }
        private void TownToChoice(object sender, EventArgs e)
        {
            TownTo = comboBoxToTown.SelectedItem.ToString();
            switch (TownTo)
            {
                case "Казань": mainForm.atr.TownTo = 0; break;
                case "Москва": mainForm.atr.TownTo = 7; break;
                case "Санкт-Петербург": mainForm.atr.TownTo = 8; break;
            }
        }

        private void Place1Choice(object sender, EventArgs e)
        {
            Place1 = place1.SelectedItem.ToString();
            switch (Place1)
            {
                case "Алма-Ата": mainForm.atr.Place1 =1; break;
                case "Абу-Даби": mainForm.atr.Place1 = 2; break;
                case "Анталия": mainForm.atr.Place1 = 3; break;
                case "Хургада": mainForm.atr.Place1 = 4; break;
                case "Тбилиси": mainForm.atr.Place1 = 5; break;
                case "Бангкок": mainForm.atr.Place1 = 6; break;
                case "Астана": mainForm.atr.Place1 = 9; break;
                case "Дубай": mainForm.atr.Place1 = 10; break;
                case "Белек": mainForm.atr.Place1 = 11; break;
                case "Батуми": mainForm.atr.Place1 = 12; break;
                case "Пхукет": mainForm.atr.Place1 = 13; break;
            }
        }
        private void Place2Choice(object sender, EventArgs e)
        {
            Place2 = place2.SelectedItem.ToString();
            switch (Place2)
            {
                case "Алма-Ата": mainForm.atr.Place2 = 1; break;
                case "Абу-Даби": mainForm.atr.Place2 = 2; break;
                case "Анталия": mainForm.atr.Place2= 3; break;
                case "Хургада": mainForm.atr.Place2 = 4; break;
                case "Тбилиси": mainForm.atr.Place2 = 5; break;
                case "Бангкок": mainForm.atr.Place2 = 6; break;
                case "Астана": mainForm.atr.Place2 = 9; break;
                case "Дубай": mainForm.atr.Place2 = 10; break;
                case "Белек": mainForm.atr.Place2 = 11; break;
                case "Батуми": mainForm.atr.Place2 = 12; break;
                case "Пхукет": mainForm.atr.Place2 = 13; break;
            }
        }

        private void GetCountry()
        {
            db.ConnectionOpen();
            string que = $"select * from Towns where Town_ID={mainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que);
            mainForm.atr.Country_ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            string que2 = $"select * from Countries where Country_ID={mainForm.atr.Country_ID}";
            dt = SQLServer.ExecuteQuerySelect(que2);
            mainForm.atr.Country_Name = dt.Rows[0].ItemArray[1].ToString();
            string que3 = $"select * from Towns where Town_ID={mainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que3);
            mainForm.atr.TownName = dt.Rows[0].ItemArray[1].ToString();
            mainForm.atr.LatitudeTownPlace1 = double.Parse(dt.Rows[0].ItemArray[3].ToString());
            mainForm.atr.LongitudeTownPlace1 = double.Parse(dt.Rows[0].ItemArray[2].ToString());
            string que4 = $"select * from Towns where Town_ID={mainForm.atr.TownTo}";
            dt = SQLServer.ExecuteQuerySelect(que4);
            mainForm.atr.LongitudeTownTo = double.Parse(dt.Rows[0].ItemArray[2].ToString());
            mainForm.atr.LatitudeTownTo = double.Parse(dt.Rows[0].ItemArray[3].ToString());
            string que5 = $"select * from Towns where Town_ID={mainForm.atr.TownFrom}";
            dt = SQLServer.ExecuteQuerySelect(que5);
            mainForm.atr.LatitudeTownFrom = double.Parse(dt.Rows[0].ItemArray[3].ToString());
            mainForm.atr.LongitudeTownFrom = double.Parse(dt.Rows[0].ItemArray[2].ToString());
            db.ConnectionClose();
        }
    }
}