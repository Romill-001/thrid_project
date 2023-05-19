using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace thrid_project
{
    public partial class UCEating : UserControl
    {
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        public int tag;
        public int type;
        DataRow[] start;
        public bool smoking;
        public int dist;
        public int eatingtype;
        public int clas;
        public string smokingstr;
        public string eatingtypestr;
        public string classtr;
        List<Panel> lst = new List<Panel>();
        public UserControl next;
        public UCEating(int type)
        {
            this.type = type;
            InitializeComponent();
        }
        public void GetEating(DataRow[] dt)
        {
            if (dt.Length != 0)
            {
                for (int i = 0; i < dt.Length; i++)
                {
                    switch (dt[i].ItemArray[8])
                    {
                        case false: smokingstr = "Запрещено"; break;
                        case true: smokingstr = "Разрешено"; break;
                    }
                    switch (dt[i].ItemArray[6])
                    {
                        case 0: classtr = "Эконом"; break;
                        case 1: classtr = "Бизнес"; break;
                        case 2: classtr = "Элитное"; break;
                    }
                    switch (dt[i].ItemArray[7])
                    {
                        case 0: eatingtypestr = "Халяль"; break;
                        case 1: eatingtypestr = "Веганское"; break;
                        case 2: eatingtypestr = "Постное"; break;
                    }
                    Label name = new Label
                    {
                        AutoSize = true,
                        BorderStyle = BorderStyle.None,
                        Tag = i,
                        Text = dt[i].ItemArray[1].ToString(),
                        Location = new Point(250, 15),
                        BackColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                    };
                    Label info = new Label
                    {
                        AutoSize = true,
                        BorderStyle = BorderStyle.None,
                        Tag = i,
                        Text = $"{MainForm.atr.TownName}*{dt[i].ItemArray[5]}\n\n\n\n{classtr}*{eatingtypestr}*Курение {smokingstr}",
                        Location = new Point(250, 50),
                        BackColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                    };
                    PictureBox pic = new PictureBox
                    {
                        Image = new Bitmap($@".\..\..\Resources\eating{type}.png"),
                        Location = new Point(20, 20),
                        Size = new Size(100, 100),

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
                        Text = $"{dt[i].ItemArray[2]} рублей",
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
                    panel.Controls.Add(name);
                    panel.Controls.Add(price);
                    panel.Controls.Add(info);
                    panel.Controls.Add(pic);
                    panel1.Controls.Add(panel);
                    lst.Add(panel);
                }
            }
            else
            {
                Label name = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = 1,
                    Text = "По выбранным фильтрам ничего не найдено!",
                    Location = new Point(20, 20),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                panel1.Controls.Add(name);
            }
        }
        private void add_CLick(object sender, EventArgs e)
        {
            tag = int.Parse(((Button)sender).Tag.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!lst[i].Tag.Equals(tag))
                {
                    lst[i].Enabled = false;
                }
            }
            MainForm.atr.EatingPlacePrice.Add(int.Parse(dt.Rows[tag].ItemArray[2].ToString()));
            MainForm.atr.EatingPlaceName.Add(dt.Rows[tag].ItemArray[1].ToString());
            MainForm.atr.EatingPlaceInfo.Add($"{MainForm.atr.TownName}*{dt.Rows[tag].ItemArray[5]} км от места проживания\n\n\n\n{classtr}*{eatingtypestr}*Курение {smokingstr}");
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MainForm.atr.EatingPlacePrice[type] != 0)
            {
                MainForm.atr.Summa += MainForm.atr.EatingPlacePrice[type];
            }
            MainForm.ActiveForm.Controls.Add(next);
            next.Visible = true;
            next.BringToFront();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            MainForm.atr.EatingPlacePrice.Add(0);
            MainForm.atr.EatingPlaceName.Add(null);
            MainForm.atr.EatingPlaceInfo.Add(null);
            MainForm.ActiveForm.Controls.Add(next);
            next.Visible = true;
            next.BringToFront();
        }

        private void UCEating_MouseEnter(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            db.ConnectionOpen();
            string que = $"select * from EatingPlaces where Type={type} and Town_ID={MainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que);
            db.ConnectionClose();
            switch (MainForm.atr.TypeOfHouse)
            {
                case 0:
                    lblchooseeating.Text = "Завтрак";
                    break;
                case 1:
                    lblchooseeating.Text = "Обед";
                    break;
                case 2:
                    lblchooseeating.Text = "Ужин";
                    break;
            }
            label1.Text = MainForm.atr.Country_Name + ", " + MainForm.atr.TownName;
            GetEating(Start());
        }
        public DataRow[] Start()
        {
            start = dt.Select("Distance >= 0");
            return start;
        }
        public DataRow[] Smoking(bool smok)
        {
            start = start.AsEnumerable().Where(dr => dr.Field<object>("Smoking").Equals(smok)).ToArray();
            return start;
        }
        public DataRow[] Distance(int distance)
        {
            start = start.AsEnumerable().Where(dr => dr.Field<int>("Distance") < distance).ToArray();
            return start;
        }
        public DataRow[] Class(int clas)
        {
            start = start.AsEnumerable().Where(dr => dr.Field<int>("Class").Equals(clas)).ToArray();
            return start;
        }
        public DataRow[] EatingType(int type)
        {
            start = start.AsEnumerable().Where(dr => dr.Field<int>("EatingType").Equals(type)).ToArray();
            return start;
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
            MainForm.atr.EatingPlacePrice.RemoveAt(type);
            MainForm.atr.EatingPlaceName.RemoveAt(type);
            MainForm.atr.EatingPlaceInfo.RemoveAt(type);
            btnNext.Visible = false;
            btnCancel.Visible = false;
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e) //class
        {
            switch (checkedListBox1.SelectedItem.ToString())
            {
                case "Эконом": clas = 0; break;
                case "Бизнес": clas = 1; break;
                case "Элитный": clas = 2; break;
            }
            panel1.Controls.Clear();
            GetEating(Class(clas));
        }

        private void checkedListBox2_SelectedValueChanged(object sender, EventArgs e) //dist
        {
            switch (checkedListBox2.SelectedItem.ToString())
            {
                case "Меньше 1 км": dist = 1; break;
                case "Меньше 3 км": dist = 3; break;
                case "Меньше 5 км": dist = 5; break;
            }
            panel1.Controls.Clear();
            GetEating(Distance(dist));
        }

        private void checkedListBox3_SelectedValueChanged(object sender, EventArgs e) //eatingtype
        {
            switch (checkedListBox3.SelectedItem.ToString())
            {
                case "Халяль": eatingtype = 0; break;
                case "Веганское": eatingtype = 1; break;
                case "Постное": eatingtype = 2; break;
            }
            panel1.Controls.Clear();
            GetEating(EatingType(eatingtype));
        }

        private void checkedListBox4_SelectedValueChanged(object sender, EventArgs e) //smoking
        {
            switch (checkedListBox4.SelectedItem.ToString())
            {
                case "Запрещено": smoking = false; break;
                case "Разрешено": smoking = true; break;
            }
            panel1.Controls.Clear();
            GetEating(Smoking(smoking));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GetEating(Start());
        }
    }
}

