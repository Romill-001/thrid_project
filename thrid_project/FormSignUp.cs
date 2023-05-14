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
    public partial class FormSignUp : Form
    {
        DataBase dataBase = new DataBase();
        DataTable table;
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                if (textBoxLogin.Text.Contains("@gmail.com") || textBoxLogin.Text.Contains("@mail.ru"))
                {
                    dataBase.ConnectionOpen();
                    string query_string = $"select * from Accounts where Login = '{textBoxLogin.Text}'" +
                        $" and Password = '{textBoxPassword.Text}'";
                    table = SQLServer.ExecuteQuerySelect(query_string);
                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show("Пользователь с таким логином и паролем уже зарегистрирован", "Ошибка регистрации");
                    }
                    else
                    {
                        query_string = $"select Account_ID from Accounts";
                        table = SQLServer.ExecuteQuerySelect(query_string);
                        int id = int.Parse(table.Rows[table.Rows.Count - 1].ItemArray[0].ToString());

                        query_string = $"insert into Accounts (Login, Password, Name, Account_ID) VALUES ('{textBoxLogin.Text}', " +
                            $"'{textBoxPassword.Text}', '{textBoxName.Text}', {id + 1})";
                        SQLServer.ExecuteQueryInsert_Update(query_string);
                        MessageBox.Show("Регистрация прошла успешно!");
                        textBoxLogin.Text = null;
                        textBoxPassword.Text = null;
                        textBoxName.Text = null;
                        this.Close();
                        Thread thread = new Thread(OpenFormEntry);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    dataBase.ConnectionClose();
                }
                else
                {
                    MessageBox.Show("Введите существующую почту(gmail или mail)", "Ошибка создания аккаунта");
                }
            }
            else
            {
                MessageBox.Show("Есть незаполненные поля", "Ошибка регистрации");
            }
        }
        public static void OpenFormEntry()
        {
            Application.Run(new FormEntry());
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Thread thread = new Thread(OpenFormEntry);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
