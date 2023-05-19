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
using GMap.NET.WindowsForms.Markers;

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
            gMapControl1.Zoom = 8; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);// точка в центре карты при открытии (центр России)
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы
            buildPath(MainForm.atr.LatitudeTownFrom, MainForm.atr.LongitudeTownFrom, MainForm.atr.LatitudeTownPlace1, MainForm.atr.LongitudeTownPlace1, new Pen(Color.Red, 4));//из города
            buildPath(MainForm.atr.LatitudeTownTo, MainForm.atr.LongitudeTownTo, MainForm.atr.LatitudeTownPlace1, MainForm.atr.LongitudeTownPlace1, new Pen(Color.Red, 4));//в город
            SetMarker(MainForm.atr.LatitudeTownFrom, MainForm.atr.LongitudeTownFrom,"Место отбытия",GMarkerGoogleType.red);
            SetMarker(MainForm.atr.LatitudeTownTo, MainForm.atr.LongitudeTownTo, "Место прибытия", GMarkerGoogleType.red);
            SetMarker(MainForm.atr.LatitudeTownPlace1, MainForm.atr.LongitudeTownPlace1, "Место вашего отдыха!", GMarkerGoogleType.arrow);
        }
        private void buildPath(double p1_lat, double p1_lng, double p2_lat, double p2_lng, Pen pen)
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons"); //Оверлей
            List<PointLatLng> points = new List<PointLatLng>(); //Лист с точками
            points.Add(new PointLatLng(p1_lat, p1_lng)); // старт в Казани
            points.Add(new PointLatLng(p2_lat, p2_lng)); // конец
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon"); //Создаем полигон
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = pen; // линия
            polyOverlay.Polygons.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay);
            gMapControl1.Position = new GMap.NET.PointLatLng(55.7887, 49.1221);// точка в центре карты при открытии (центр России)
            gMapControl1.Zoom = 4; // какой используется зум при открытии
        }
        private void SetMarker(double p1_lat, double p1_lng, string text, GMarkerGoogleType type)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(p1_lat, p1_lng), type);
            GMapOverlay overlay = new GMapOverlay("markers");
            marker.ToolTipText = text.ToUpper();
            overlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(overlay);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
        }
    }
}
