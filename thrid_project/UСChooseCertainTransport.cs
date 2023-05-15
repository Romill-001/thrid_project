using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace thrid_project
{
    public partial class UСChooseCertainTransport : UserControl
    {
        DataBase db = new DataBase();
        DataTable dt;
        public int tag;
        List<Panel> lst = new List<Panel>();
        public UСChooseCertainTransport()
        {
            InitializeComponent();
        }
        public void GetTransport()
        {
            db.ConnectionOpen();
            string que = $"select * from Transport where Type={mainForm.atr.TypeOfTransport}";
            dt = SQLServer.ExecuteQuerySelect(que);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label name = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt.Rows[i].ItemArray[4].ToString(),
                    Location = new Point(250, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                };
                Label info = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt.Rows[i].ItemArray[5].ToString(),
                    Location = new Point(190, 15),
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
                    Location = new Point(450, 100),
                    BackColor = Color.FromArgb(0, 192, 192),
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                add.Click += add_CLick;
                Label price = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = $"{dt.Rows[i].ItemArray[3]} рублей",
                    Location = new Point(450, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                Panel panel = new Panel
                {
                    Size = new Size(600, 180),
                    Location = new Point(20, 0 + 180 * i),
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
            for (int i = 0; i < lst.Count; i++)
            {
                if (!lst[i].Tag.Equals(tag))
                {
                    lst[i].Enabled = false;
                }
            }
            mainForm.atr.CertainTransportPrice = int.Parse(dt.Rows[tag].ItemArray[3].ToString());
            mainForm.atr.CertainTransportName = dt.Rows[tag].ItemArray[4].ToString();
            btnNext.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Controls.Add(mainForm.zavtrak);
            mainForm.zavtrak.BringToFront();
        }

        private void UСChooseCertainTransport_MouseEnter(object sender, EventArgs e)
        {
            label_country.Text = mainForm.atr.Country_Name + ", " + mainForm.atr.TownName;
            GetTransport();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Controls.Remove(this);
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
