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
        List<Panel> lst = new List<Panel>();
        public UserControl next;
        public UCEating(int type)
        {
            this.type = type;
            InitializeComponent();
        }
        public void GetEating()
        {
            db.ConnectionOpen();
            string que = $"select * from EatingPlaces where Type={type} and Town_ID={MainForm.atr.Place1}";
            dt = SQLServer.ExecuteQuerySelect(que);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label name = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt.Rows[i].ItemArray[1].ToString(),
                    Location = new Point(250, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                };
                Label info = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt.Rows[i].ItemArray[3].ToString(),
                    Location = new Point(90, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

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
                    Text = $"{dt.Rows[i].ItemArray[2]} рублей",
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
                panel1.Controls.Add(panel);
                lst.Add(panel);
            }
            db.ConnectionClose();
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
            MainForm.atr.EatingPlaceInfo.Add(dt.Rows[tag].ItemArray[3].ToString());
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
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
            label1.Text = MainForm.atr.Country_Name + ", " + MainForm.atr.TownName;
            GetEating();
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
    }
}

