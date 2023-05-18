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
        DataRow[] start;
        public int rate;
        public int dist;
        public int eating;
        public string eatingtype;
        public UCHouseList()
        {
            InitializeComponent();
        }

        public void GetHouses(DataRow[] dt)
        {
            if (dt.Length != 0)
            {
                for (int i = 0; i < dt.Count(); i++)
                {
                    switch (dt[i].ItemArray[5])
                    {
                        case 0:eatingtype= "Всё включено"; break;
                        case 1:eatingtype = "Включён завтрак"; break;
                        case 2:eatingtype="Включён завтрак и обед"; break;
                        case 3:eatingtype= "Включён завтрак и ужин"; break;
                        case 4:eatingtype= "С собсвтенной кухней"; break;
                    }
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
                        Text = $"{MainForm.atr.TownName}*{dt[i].ItemArray[6]} км от центра* \n\n\n{eatingtype}",
                        Location = new Point(250, 50),
                        BackColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                    };
                    PictureBox pic = new PictureBox
                    {
                        Image = new Bitmap($@".\..\..\Resources\{dt[i].ItemArray[2]}.png"),
                        Location = new Point(20,20),
                        Size = new Size(100,100),

                    };
                    Label rating = new Label
                    {
                        AutoSize = true,
                        BorderStyle = BorderStyle.None,
                        Tag = i,
                        Text = new String('\u2605', int.Parse(dt[i].ItemArray[2].ToString())),
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
                        Location = new Point(20, 20 + 180 * i),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = i
                    };
                    panel.Controls.Add(add);
                    panel.Controls.Add(pic);
                    panel.Controls.Add(name);
                    panel.Controls.Add(price);
                    panel.Controls.Add(rating);
                    panel.Controls.Add(info);
                    panel1.Controls.Add(panel);
                    lst.Add(panel);
                }
            }
            //else
            //{
            //    panel1.Controls.Clear();
            //    Panel panelcanc = new Panel
            //    {
            //        Size = new Size(780, 180),
            //        Location = new Point(20, 20),
            //        BackColor = Color.White,
            //        BorderStyle = BorderStyle.FixedSingle,
            //        Tag = 1
            //    };
            //    Label cancel = new Label
            //    {
            //        AutoSize = true,
            //        BorderStyle = BorderStyle.None,
            //        Tag = 1,
            //        Text = "Данные отсутсвтуют! Нажмите кнопку \"Обновить\"",
            //        Location = new Point(10, 15),
            //        BackColor = Color.White,
            //        Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
            //    };
            //    panelcanc.Controls.Add(cancel);
            //    panel1.Controls.Add(panelcanc);
            //}
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
            MainForm.atr.EatingType = eatingtype;
            MainForm.atr.DistanceCenter = int.Parse(dt.Rows[tag].ItemArray[6].ToString());
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
            panel1.Controls.Clear();
            db.ConnectionOpen();
            string que = $"select * from LivingPlace where Type={MainForm.atr.TypeOfHouse} and Town_ID={MainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que);
            db.ConnectionClose();
            checkedListBox3.Items.Clear();
            switch (MainForm.atr.TypeOfHouse)
            {
                case 0:
                    lblhsname.Text = "Выбор отеля"; 
                    checkedListBox3.Items.Add("Всё включено");
                    checkedListBox3.Items.Add("Включён завтрак");
                    checkedListBox3.Items.Add("Включён завтрак и обед");
                    checkedListBox3.Items.Add("Включён завтрак и ужин");

                    break;
                case 1: 
                    lblhsname.Text = "Выбор хотсела";
                    checkedListBox3.Items.Add("Включён завтрак");
                    checkedListBox3.Items.Add("С собственной кухней");
                    break;
                case 2: 
                    lblhsname.Text = "Выбор арендованного жилья";
                    checkedListBox3.Items.Add("С собственной кухней");
                    break;
            }
            label1.Text = MainForm.atr.Country_Name + ", " + MainForm.atr.TownName;
            GetHouses(Start());
        }
        public DataRow[] Start()
        {
            start = dt.Select("Distance >= 0");
            return start;
        }
        public DataRow[] Rating(int rating)
        {
            start = start.AsEnumerable().Where(dr => dr.Field<object>("Rating").Equals(rating)).ToArray();
            return start;
        }
        public DataRow[] DistanceCenter (int distance)
        {
            start = start.AsEnumerable().Where(dr => dr.Field<int>("DistanceCenter") < distance).ToArray();
            return start;
        }
        public DataRow[] Eating(int eating)
        {
            start = start.AsEnumerable().Where(dr => dr.Field<int>("Eating").Equals(eating)).ToArray();
            return start;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
            MainForm.hl = new UCHouseList();
            MainForm.hl.Location = new Point(0, 130);
            MainForm.hl.Visible= false;
            MainForm.hl.start = new DataRow[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].Enabled = true;
            }
            btnNext.Visible = false;
            btnCancel.Visible = false;
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

        private void checkedListBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (checkedListBox2.SelectedItem.ToString())
            {
                case "Меньше 1 км": dist = 1; break;
                case "Меньше 3 км": dist = 3; break;
                case "Меньше 5 км": dist = 5; break;
            }
            panel1.Controls.Clear();
            GetHouses(DistanceCenter(dist));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GetHouses(Start());
        }

        private void checkedListBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (MainForm.atr.TypeOfHouse)
            {
                case 0:
                    switch (checkedListBox3.SelectedItem.ToString())
                    {
                        case "Всё включено": eating = 0; break;
                        case "Включён завтрак": eating = 1; break;
                        case "Включён завтрак и обед": eating = 2; break;
                        case "Включён завтрак и ужин": eating = 3; break;
                    }
                    break;
                case 1:
                    switch (checkedListBox3.SelectedItem.ToString())
                    {
                        case "Включён завтрак": eating = 1; break;
                        case "С собсвтенной кухней": eating = 4; break;
                    }
                    break;
                case 2:
                    switch (checkedListBox3.SelectedItem.ToString())
                    {
                        case "С собсвтенной кухней": eating = 4; break;
                    }
                    break;
            }
            panel1.Controls.Clear();
            GetHouses(Eating(eating));
        }
    }
}
