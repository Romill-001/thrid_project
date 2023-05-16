using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace thrid_project
{
    public partial class UCHouseList : UserControl
    {
        DataBase db = new DataBase();
        DataTable dt;
        public string Type;
        public int tag;
        List<Panel> lst = new List<Panel>();
        public int rate;
        public UCHouseList()
        {
            InitializeComponent();
        }

        public void GetHouses(DataRow[] dt)
        {
            for (int i = 0; i < dt.Count(); i++)
            {
                Label name = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt[i].ItemArray[3].ToString(),
                    Location = new Point(250, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                };
                Label info = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt[i].ItemArray[3].ToString(),
                    Location = new Point(90, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                };
                Label rating = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = new String('\u2605',int.Parse(dt[i].ItemArray[2].ToString())),
                    Location = new Point(500, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = Color.FromArgb(0, 192, 192),

                };
                Button add = new Button
                {
                    AutoSize = true,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Black,
                    Tag = i,
                    Text = "Выбрать",
                    Location = new Point(650, 100),
                    BackColor = Color.FromArgb(0, 192, 192),
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                add.Click += add_CLick;
                Label price = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = $"{dt[i].ItemArray[1]} рублей",
                    Location = new Point(600, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                Panel panel = new Panel
                {
                    Size = new Size(780, 180),
                    Location = new Point(20, 20 + 180* i),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = i
                };
                panel.Controls.Add(add);
                panel.Controls.Add(name);
                panel.Controls.Add(price);
                panel.Controls.Add(rating);
                panel1.Controls.Add(panel);
                lst.Add(panel);
            }
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
            MainForm.atr.Distance = int.Parse(dt.Rows[tag].ItemArray[4].ToString());
            MainForm.atr.HousePrice = int.Parse(dt.Rows[tag].ItemArray[1].ToString());
            MainForm.atr.HouseName = dt.Rows[tag].ItemArray[3].ToString();
            MainForm.atr.HouseRating = new String('\u2605', int.Parse(dt.Rows[tag].ItemArray[2].ToString()));
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Add(MainForm.tc);
            MainForm.tc.Visible = true;
            MainForm.tc.BringToFront();
        }

        private void UCHouseList_MouseEnter(object sender, EventArgs e)
        {
            switch (MainForm.atr.TypeOfHouse)
            {
                case 0: lblhsname.Text = "Выбор отеля"; break;
                case 1: lblhsname.Text = "Выбор хотсела"; break;
                case 2: lblhsname.Text = "Выбор арендованного жилья"; break;
            }
            label1.Text = MainForm.atr.Country_Name + ", " + MainForm.atr.TownName;
            GetHouses(Start());
        }
        public DataRow[] Start()
        {
            db.ConnectionOpen();
            string que = $"select * from LivingPlace where Type={MainForm.atr.TypeOfHouse} and Town_ID={MainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que);
            db.ConnectionClose();
            var new_dt = dt.Select("Distance >= 0");
            return new_dt;
        }
        public DataRow[] Rating(int rating)
        {
            DataRow[] new_dt = dt.Select($"Rating = {rating}");
            return new_dt;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].Enabled = true;
            }
            btnNext.Visible = false;
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (checkedListBox1.SelectedItem.ToString())
            {
                case "1 Звезда": rate = 1; break;
                case "2 Звезды": rate = 2; break;
                case "3 Звезды": rate = 3; break;
                case "4 Звезды": rate = 4; break;
                case "5 Звёзд": rate = 5; break;
            }
            panel1.Controls.Clear();
            GetHouses(Rating(rate));
        }
    }
}
