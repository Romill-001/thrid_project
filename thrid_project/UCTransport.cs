using GMap.NET.MapProviders;
using System;
using System.CodeDom.Compiler;
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
    public partial class UCTransport : UserControl
    {
        DataBase db = new DataBase();
        DataTable dt;
        public string Type;
        public int tag;
        List<Panel> lst = new List<Panel>();
        public UCTransport()
        {
            InitializeComponent();
        }

        private void TypeChoice(object sender, EventArgs e)
        {
            Type = cbType.SelectedItem.ToString();
            switch (Type)
            {
                case "Поезд": MainForm.atr.TicketType = 0; MainForm.atr.TiketTransportTypeLocation = "вокзала"; break;
                case "Самолёт": MainForm.atr.TicketType = 1; MainForm.atr.TiketTransportTypeLocation = "аэропорта"; break;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (lst.Count == 0)
            {
                GetTickets();
            }
            else
            {
                for (int i = 0;i<lst.Count;i++)
                {
                    Controls.Remove(lst[i]);
                }
                GetTickets();
            }
        }

        public void GetTickets()
        {
            int point;
            db.ConnectionOpen();
            string que = $"select * from Tickets where Country_ID={MainForm.atr.Country_ID} " + $"and Type={MainForm.atr.TicketType}";
            dt = SQLServer.ExecuteQuerySelect(que);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Билетов в этом направлении нет");
                point = 0;
            }
            else if (dt.Rows.Count == 3)
            {
                point = 50;
            }
            else
            {
                point = 250;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label name = new Label
                {
                    AutoSize= true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt.Rows[i].ItemArray[2].ToString(),
                    Location = new Point(90, 15),
                    BackColor= Color.White,
                    Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                };
                Button add = new Button
                {
                    AutoSize = true,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Black,
                    Tag = i,
                    Text = "Выбрать",
                    Location = new Point(100, 100),
                    BackColor = Color.Cyan,
                    Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                add.Click += add_CLick;
                Label price = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = $"{dt.Rows[i].ItemArray[1]} рублей",
                    Location = new Point(90, 50),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                Panel panel = new Panel
                {
                    Size = new Size(350, 200),
                    Location = new Point(point + i * 370, 200),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = i
                };
                panel.Controls.Add(add);
                panel.Controls.Add(name);
                panel.Controls.Add(price);
                Controls.Add(panel);
                lst.Add(panel);
            }
            db.ConnectionClose();
        }
        private void add_CLick(object sender, EventArgs e)
        {
            tag = int.Parse(((Button)sender).Tag.ToString());
            for (int i = 0; i < lst.Count; i++)
            {
                if (!lst[i].Tag.Equals(tag))
                {
                    lst[i].Enabled = false;
                }
            }
            MainForm.atr.TicketPrice = int.Parse(dt.Rows[tag].ItemArray[1].ToString());
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MainForm.atr.Summa += MainForm.atr.TicketPrice;
            MainForm.ActiveForm.Controls.Add(MainForm.lv);
            MainForm.lv.BringToFront();
        }

        private void EnterForm(object sender, EventArgs e)
        {
            labelDestiantion.Text = MainForm.atr.Country_Name + ", " + MainForm.atr.TownName;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.atr.Summa = 0;
            MainForm.ActiveForm.Controls.Remove(this);
            MainForm.tr = new UCTransport();
            MainForm.tr.Location = new Point(0, 130);
            MainForm.tr.Visible = false;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].Enabled = true;
            }
            btnNext.Visible=false;
            btnCancel.Visible = false;
            MainForm.atr.TicketPrice = 0;
        }


    }
}
