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
            MainForm.ActiveForm.Controls.Add(MainForm.map);
            MainForm.map.BringToFront();
        }
        private void UCConclusion_MouseEnter(object sender, EventArgs e)
        {
            switch (MainForm.atr.TypeOfHouse)
            {
                case 0: lbllivingplace.Text = "Ваш отель"; break;
                case 1: lbllivingplace.Text = "Ваш хостел"; break;
                case 2: lbllivingplace.Text = "Ваше съёмное жильё"; break;
                case 3: lbllivingplace.Text = "Проживание у друзей/родственников"; break;
            }
            switch (MainForm.atr.TypeOfTransport)
            {
                case 0: lbltransport.Text = "Пешая прогулка"; break;
                case 1: lbltransport.Text = "Ваше такси"; break;
                case 2: lbltransport.Text = "Ваш общественный транспорт"; break;
                case 3: lbltransport.Text = "Ваша арендуемая машина"; break;
            }
            if (MainForm.atr.TypeOfTransport != 0)
            {
                transportname.Text = MainForm.atr.CertainTransportName;
                transportprice.Text = $"{MainForm.atr.CertainTransportPrice} рублей";
            }
            else
            {
                transportname.Visible = false;
                transportprice.Text = $"Бесплатно";
            }
            housename.Text = MainForm.atr.HouseName;
            houseprice.Text = $"{MainForm.atr.HousePrice} рублей";
            houserating.Text = MainForm.atr.HouseRating;
            if (MainForm.atr.EatingPlaceName[0] != null) zavtrakname.Text = MainForm.atr.EatingPlaceName[0]; else zavtrakname.Text = "Не выбрано";
            if (MainForm.atr.EatingPlaceName[1] != null) obedname.Text = MainForm.atr.EatingPlaceName[1]; else obedname.Text = "Не выбрано";
            if (MainForm.atr.EatingPlaceName[2] != null) uzhinname.Text = MainForm.atr.EatingPlaceName[2]; else uzhinname.Text = "Не выбрано";
            if (MainForm.atr.EatingPlacePrice[0] != 0) zavtrakprice.Text = $"{MainForm.atr.EatingPlacePrice[0]} рублей за завтрак"; else zavtrakprice.Visible = false;
            if (MainForm.atr.EatingPlacePrice[1] != 0) obedprice.Text = $"{MainForm.atr.EatingPlacePrice[1]} рублей за обед"; else obedprice.Visible = false;
            if (MainForm.atr.EatingPlacePrice[2] != 0) uzhinprice.Text = $"{MainForm.atr.EatingPlacePrice[2]} рублей за ужин"; else uzhinprice.Visible = false;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
        }
    }
}
