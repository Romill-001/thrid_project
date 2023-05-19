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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thrid_project
{
    public partial class UCMyVisitsList : UserControl
    {
        DataBase db = new DataBase();
        public DataTable dt = new DataTable();
        List<Panel> lst = new List<Panel>();
        public int tag;
        public UCMyVisitsList()
        {
            InitializeComponent();
        }

        private void UCMyVisitsList_MouseEnter(object sender, EventArgs e)
        {
            db.ConnectionOpen();
            string que = $"select * from Visits where Account_ID={FormEntry.user_id}";
            dt = SQLServer.ExecuteQuerySelect(que);
            for (int i =0; i < dt.Rows.Count; i++)
            {
                Label name = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = dt.Rows[i].ItemArray[1].ToString(),
                    Location = new Point(20, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                };
                Label info = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = $"{dt.Rows[i].ItemArray[2]} -> {dt.Rows[i].ItemArray[4]} -> {dt.Rows[i].ItemArray[3]}",
                    Location = new Point(20, 75),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),

                };
                Label add = new Label
                {
                    AutoSize = true,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Black,
                    Tag = i,
                    Text = "Посмотреть подробнее",
                    Location = new Point(800, 100),
                    BackColor = Color.FromArgb(0, 192, 192),
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                add.Click += add_Click;
                Label price = new Label
                {
                    AutoSize = true,
                    BorderStyle = BorderStyle.None,
                    Tag = i,
                    Text = $"Общий бюджет: {dt.Rows[i].ItemArray[27]} рублей",
                    Location = new Point(650, 15),
                    BackColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                };
                Panel panel = new Panel
                {
                    Size = new Size(1020, 180),
                    Location = new Point(20, 20 + 180 * i),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = i
                };
                panel.Controls.Add(add);
                panel.Controls.Add(name);
                panel.Controls.Add(price);
                panel.Controls.Add(info);
                panel1.Controls.Add(panel);
                lst.Add(panel);
            }
            db.ConnectionClose();
        }
        private void add_Click(object sender, EventArgs e)
        {
            tag = int.Parse(((Label)sender).Tag.ToString());
            MainForm.curr = new UCMyVisits(dt.Rows[tag]);
            MainForm.curr.Location = new Point(0, 130);
            MainForm.ActiveForm.Controls.Add(MainForm.curr);
            MainForm.curr.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(this);
        }
    }
}
