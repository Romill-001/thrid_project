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
        private void UCConclusion_MouseEnter(object sender, EventArgs e)
        {
            switch (mainForm.atr.TypeOfHouse)
            {
                case 0: lbllivingplace.Text = "Ваш отель"; break;
                case 1: lbllivingplace.Text = "Ваш хостел"; break;
                case 2: lbllivingplace.Text = "Ваше съёмное жильё"; break;
                case 3: lbllivingplace.Text = "Проживание у друзей/родственников"; break;
            }
            switch (mainForm.atr.TypeOfTransport)
            {
                case 0: lbltransport.Text = "Пешая прогулка"; break;
                case 1: lbltransport.Text = "Ваше такси"; break;
                case 2: lbltransport.Text = "Ваш общественный транспорт"; break;
                case 3: lbltransport.Text = "Ваша арендуемая машина"; break;
            }
            if (mainForm.atr.TypeOfTransport != 0)
            {
                transportname.Text = mainForm.atr.CertainTransportName;
                transportprice.Text = $"{mainForm.atr.CertainTransportPrice} рублей";
            }
            else
            {
                transportname.Visible = false;
                transportprice.Text = $"Бесплатно";
            }
            housename.Text = mainForm.atr.HouseName;
            houseprice.Text = $"{mainForm.atr.HousePrice} рублей";
            houserating.Text = mainForm.atr.HouseRating;
            if (mainForm.atr.EatingPlaceName[0] != null) zavtrakname.Text = mainForm.atr.EatingPlaceName[0]; else zavtrakname.Text = "Не выбрано";
            if (mainForm.atr.EatingPlaceName[1] != null) obedname.Text = mainForm.atr.EatingPlaceName[1]; else obedname.Text = "Не выбрано";
            if (mainForm.atr.EatingPlaceName[2] != null) uzhinname.Text = mainForm.atr.EatingPlaceName[2]; else uzhinname.Text = "Не выбрано";
            if (mainForm.atr.EatingPlacePrice[0] != 0) zavtrakprice.Text = $"{mainForm.atr.EatingPlacePrice[0]} рублей за завтрак"; else zavtrakprice.Visible = false;
            if (mainForm.atr.EatingPlacePrice[1] != 0) obedprice.Text = $"{mainForm.atr.EatingPlacePrice[1]} рублей за обед"; else obedprice.Visible = false;
            if (mainForm.atr.EatingPlacePrice[2] != 0) uzhinprice.Text = $"{mainForm.atr.EatingPlacePrice[2]} рублей за ужин"; else uzhinprice.Visible = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Controls.Remove(this);
        }
    }
}
