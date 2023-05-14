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
    public partial class mainForm : Form
    {
        public static Atributes atr = new Atributes();
        public UCStartPage sp = new UCStartPage();
        public static UCTransport tr = new UCTransport();
        public static UCLiving lv = new UCLiving();
        public static UCHouseList hl = new UCHouseList();
        public static UCTransportChoice tc = new UCTransportChoice();
        public static UСChooseCertainTransport certaintr = new UСChooseCertainTransport();
        public static UCEating zavtrak = new UCEating(0, mainForm.obed);
        public static UCEating obed = new UCEating(1, mainForm.uzhin);
        public static UCEating uzhin = new UCEating(2, null);
        public mainForm()
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
        }

        //private void gMapControl1_Load(object sender, EventArgs e)
        //{
        //    GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
        //    gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
        //    gMapControl1.MinZoom = 2; //минимальный зум
        //    gMapControl1.MaxZoom = 16; //максимальный зум
        //    gMapControl1.Zoom = 4; // какой используется зум при открытии
        //    gMapControl1.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);// точка в центре карты при открытии (центр России)
        //    gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
        //    gMapControl1.CanDragMap = true; // перетаскивание карты мышью
        //    gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
        //    gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
        //    gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы
        //}

        /// <summary>
        /// строит путь передаётся широта и долгота места назначения
        /// </summary>
        private void buildPath(double p1_lat, double p1_lng, double p2_lat, double p2_lng)
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons"); //Оверлей
            List<PointLatLng> points = new List<PointLatLng>(); //Лист с точками
            points.Add(new PointLatLng(p1_lat, p1_lng)); // старт в Казани
            points.Add(new PointLatLng(p2_lat, p2_lng)); // конец
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon"); //Создаем полигон
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 5); // линия
            polyOverlay.Polygons.Add(polygon);
            //gMapControl1.Overlays.Add(polyOverlay);
            //gMapControl1.Position = new GMap.NET.PointLatLng(55.7887, 49.1221);// точка в центре карты при открытии (центр России)
            //gMapControl1.Zoom = 4; // какой используется зум при открытии
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Controls.Add(sp);
            sp.BringToFront();
        }
    }
}
