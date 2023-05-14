using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrid_project
{
    public partial class FormForgotPassword : Form
    {
        DataBase dataBase = new DataBase();
        DataTable table;
        int codeword;
        public static string password;
        public static string email;
        public FormForgotPassword()
        {
            InitializeComponent();
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            email = textBoxEMail.Text;
            dataBase.ConnectionOpen();
            string query = $"select * from Accounts where Login ='{email}'";
            table = SQLServer.ExecuteQuerySelect(query);

            if (table.Rows.Count != 0)
            {
                password = table.Rows[0]["Password"].ToString();
                Random rnd = new Random();
                codeword = rnd.Next(100000, 1000000);

                SmtpClient smtp = new SmtpClient("smtp.yandex.com", 587);
                smtp.Credentials = new NetworkCredential("live.and.dot@yandex.ru", "klsznmswpvmsclgu");

                MailAddress senderAndTheme = new MailAddress("live.and.dot@yandex.ru", "Живи и точка.");
                MailAddress recipient = new MailAddress(email);

                MailMessage message = new MailMessage(senderAndTheme, recipient);
                message.Subject = "Сброс пароля";

                message.Body = "Здравствуйте!\r\n\r\n" +
                    "Вы сбрасываете пароль в приложении \"Путешествуй и точка.\"\r\n" +
                    $"Ваш одноразовый код для подтверждения: {codeword}\r\n\r\n\r\n" +
                    "Никому не пересылайте это письмо.\r\n\r\n" +
                    "С заботой о безопасности Вашего аккаунта,\r\n" +
                    "техподдержка приложения <<Путешествуй и точка.>>";

                smtp.EnableSsl = true;
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                UC_Codeword userControl = new UC_Codeword(codeword.ToString());
                UCManagement.changeUserControl(userControl, splitContainer1.Panel2);
            }
            else
            {
                MessageBox.Show("Аккаунта с этой почтой не существует, пожалуйста, зарегистрируйтесь", "Ошибка изменения пароля");
            }
            dataBase.ConnectionClose();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Thread thread = new Thread(OpenFormEntry);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public static void OpenFormEntry()
        {
            Application.Run(new FormEntry());
        }
    }
}
