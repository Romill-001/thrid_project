using GMap.NET.WindowsForms;
using GMap.NET;
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
    public partial class UCMap : UserControl
    {
        public UCMap()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.Zoom = 4; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);// точка в центре карты при открытии (центр России)
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы
            buildPath(mainForm.atr.LatitudeTownFrom, mainForm.atr.LongitudeTownFrom, mainForm.atr.LatitudeTownPlace1, mainForm.atr.LongitudeTownPlace1);
            buildPath(mainForm.atr.LatitudeTownTo, mainForm.atr.LongitudeTownTo, mainForm.atr.LatitudeTownPlace1, mainForm.atr.LongitudeTownPlace1);
        }
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
            gMapControl1.Overlays.Add(polyOverlay);
            gMapControl1.Position = new GMap.NET.PointLatLng(55.7887, 49.1221);// точка в центре карты при открытии (центр России)
            gMapControl1.Zoom = 4; // какой используется зум при открытии
        }
    }
}
