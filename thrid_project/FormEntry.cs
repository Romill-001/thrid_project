using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrid_project
{
    public partial class FormEntry : Form
    {
        Thread thread;
        DataTable table;
        public static int user_id;
        public static string login;
        public FormEntry()
        {
            InitializeComponent();
        }
        private void buttonEntry_Click(object sender, EventArgs e)
        {
            string loginAccount = textBoxLogin.Text;
            login = loginAccount;
            string passwordAccount = textBoxPassword.Text;
            if (!string.IsNullOrEmpty(loginAccount) && !string.IsNullOrEmpty(passwordAccount))
            {
                string query_string = $"select * from Accounts where login = '{loginAccount}' and password = '{passwordAccount}'";

                table = SQLServer.ExecuteQuerySelect(query_string);
                if (table.Rows.Count == 1)
                {
                    user_id = int.Parse(table.Rows[0].ItemArray[0].ToString());
                    this.Close();
                    thread = new Thread(OpenMainForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином и паролем не существует", "Ошибка входа");
                }
            }
            else { MessageBox.Show("Есть незаполненные поля", "Ошибка входа"); }
        }
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFormSignUp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFormForgotPassword);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public static void OpenMainForm()
        {
            Application.Run(new MainForm());
        }
        public static void OpenFormSignUp()
        {
            Application.Run(new FormSignUp());
        }
        public static void OpenFormForgotPassword()
        {
            Application.Run(new FormForgotPassword());
        }
    }
}
