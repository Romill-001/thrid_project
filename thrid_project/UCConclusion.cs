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
        DataBase db = new DataBase();
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
            lblsum.Text = $"Общая сумма: {MainForm.atr.Summa} рублей";
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
            if (MainForm.atr.TypeOfHouse != 3)
            {
                houseprice.Text = $"{MainForm.atr.HousePrice} рублей";
                pbHouse.Image = new Bitmap($@".\..\..\Resources\{MainForm.atr.HouseRating.Length}.png");
            }
            else
            {
                houseprice.Text = "Бесплатно";
            }
            houseprice.Text = $"{MainForm.atr.HousePrice} рублей";
            houserating.Text = MainForm.atr.HouseRating;
            if (MainForm.atr.CertainTransportName != null)
            {
                pbTrans.Image = new Bitmap($@".\..\..\Resources\{MainForm.atr.CertainTransportName}.png");
            }
            if (MainForm.atr.EatingPlaceName[0] != null)
            {
                pictureBox1.Image = new Bitmap($@".\..\..\Resources\eating0.png");
            }
            if (MainForm.atr.EatingPlaceName[1] != null)
            {
                pictureBox2.Image = new Bitmap($@".\..\..\Resources\eating1.png");
            }
            if (MainForm.atr.EatingPlaceName[2] != null)
            {
                pictureBox3.Image = new Bitmap($@".\..\..\Resources\eating2.png");
            }
            if (MainForm.atr.EatingPlaceName[0] != null) zavtrakname.Text = MainForm.atr.EatingPlaceName[0]; else zavtrakname.Text = "Не выбрано";
            if (MainForm.atr.EatingPlaceName[1] != null) obedname.Text = MainForm.atr.EatingPlaceName[1]; else obedname.Text = "Не выбрано";
            if (MainForm.atr.EatingPlaceName[2] != null) uzhinname.Text = MainForm.atr.EatingPlaceName[2]; else uzhinname.Text = "Не выбрано";
            if (MainForm.atr.EatingPlacePrice[0] != 0) zavtrakprice.Text = $"{MainForm.atr.EatingPlacePrice[0]} рублей за завтрак"; else {zavtrakprice.Visible = false; zavtrakprice.Text = null; }
            if (MainForm.atr.EatingPlacePrice[1] != 0) obedprice.Text = $"{MainForm.atr.EatingPlacePrice[1]} рублей за обед"; else {obedprice.Visible = false; obedprice.Text = null; }
            if (MainForm.atr.EatingPlacePrice[2] != 0) uzhinprice.Text = $"{MainForm.atr.EatingPlacePrice[2]} рублей за ужин"; else { uzhinprice.Visible = false; uzhinprice.Text = null; }
            lblinfohouse.Text = $"{MainForm.atr.TownName}*{MainForm.atr.DistanceCenter} км от центра\n\n\n{MainForm.atr.EatingType}";
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
            MainForm.end = new UCConclusion();
            MainForm.end.Location = new Point(0, 130);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string TownFrom = null;
            string TownTo = null;
            string pichouse = null;
            string pictr = null;
            string zavtrakpic = null;
            string obedpic = null;
            string uzhinpic = null;
            if (MainForm.atr.EatingPlaceName[0] != null)
            {
                zavtrakpic = @".\..\..\Resources\eating0.png";
            }
            if (MainForm.atr.EatingPlaceName[1] != null)
            {
                obedpic = @".\..\..\Resources\eating1.png";
            }
            if (MainForm.atr.EatingPlaceName[2] != null)
            {
                uzhinpic = @".\..\..\Resources\eating2.png";
            }
            if (MainForm.atr.TypeOfHouse != 3)
            {
                pichouse = $@".\..\..\Resources\{MainForm.atr.HouseRating.Length}.png";
            }
            if (MainForm.atr.CertainTransportName != null)
            {
                pictr = $@".\..\..\Resources\{MainForm.atr.CertainTransportName}.png";
            }
            switch (MainForm.atr.TownFrom)
            {
                case 0: TownFrom = "Казань"; break;
                case 7: TownFrom = "Москва"; break;
                case 8: TownFrom = "Санкт-Петербург"; break;
            }
            switch (MainForm.atr.TownTo)
            {
                case 0: TownTo = "Казань"; break;
                case 7: TownTo = "Москва"; break;
                case 8: TownTo = "Санкт-Петербург"; break;
            }
            db.ConnectionOpen();
            if (!string.IsNullOrEmpty(nametextbox.Text))
            {
                string query = $"insert into Visits (Account_ID,TripName,TownFrom,TownTo,VisitPlace,TransportName,TransportPrice,LivingPlaceName,LivingPlaceInfo,LivingPlacePrice,TransportImage,LivingPlaceImage,ZavtrakName,ZavtrakPrice,ZavtrakImage,ObedName,ObedPrice,ObedImage,UzhinName,UzhinPrice,UzhinImage,LattitudeTownTo,LongitudeTownTo,LattitudeTownFrom,LongitudeTownFrom,LattitudeVisitPlace,LongitudeVisitPlace,SumPrice,CurrTrName,CurrHouseName) VALUES " +
                    $"({FormEntry.user_id},'{nametextbox.Text}','{TownFrom}','{TownTo}','{MainForm.atr.TownName}','{transportname.Text}','{transportprice.Text}','{housename.Text}','{lblinfohouse.Text}','{houseprice.Text}',"+
                    $"'{pictr}','{pichouse}','{zavtrakname.Text}','{zavtrakprice.Text}','{zavtrakpic}','{obedname.Text}','{obedprice.Text}','{obedpic}',"+
                    $"'{uzhinname.Text}','{uzhinprice.Text}','{uzhinpic}','{MainForm.atr.LatitudeTownTo}','{MainForm.atr.LongitudeTownTo}','{MainForm.atr.LatitudeTownFrom}','{MainForm.atr.LongitudeTownFrom}','{MainForm.atr.LatitudeTownPlace1}','{MainForm.atr.LongitudeTownPlace1}','{lblsum.Text}','{lbltransport.Text}','{lbllivingplace.Text})";
                SQLServer.ExecuteQueryInsert_Update(query);
                MessageBox.Show("Подборка успешно создана!");
            }
            else
            {
                MessageBox.Show("Вы не заполнили название путешествия");
            }
            db.ConnectionClose();
        }
    }
}
