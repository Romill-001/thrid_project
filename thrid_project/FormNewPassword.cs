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
    public partial class FormNewPassword : Form
    {
        DataBase dataBase = new DataBase();
        public FormNewPassword()
        {
            InitializeComponent();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(FormForgotPassword.password))
            {
                MessageBox.Show("Новый пароль совпадает со старым", "Ошибка создания пароля");
            }
            else if (textBox1.Text.Equals(textBox2.Text))
            {
                dataBase.ConnectionOpen();
                string query = $"update Accounts SET Password = '{textBox1.Text}' " +
                    $"where Login='{FormForgotPassword.email}'";
                SQLServer.ExecuteQueryInsert_Update(query);
                dataBase.ConnectionClose();
                MessageBox.Show("Пароль успешно изменён!");

                Close();
                Thread thread = new Thread(OpenFormEntry);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Есть незаполненные поля", "Ошибка создания пароля");
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка создания пароля");
            }
        }
        public static void OpenFormEntry()
        {
            Application.Run(new FormEntry());
        }
    }
}
