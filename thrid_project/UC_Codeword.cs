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
    public partial class UC_Codeword : UserControl
    {
        Thread thread;
        private string code;
        public UC_Codeword(string code)
        {
            InitializeComponent();
            this.code = code;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == code)
            {
                Form ffp = Application.OpenForms[0];
                if (ffp != null)
                {
                    ffp.Close();
                    thread = new Thread(OpenFormNewPassword);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Кодовое слово не введено", "Ошибка ввода кодового слова");
            }
            else
            {
                MessageBox.Show("Введённое слово не совпадает с отправленым", "Ошибка ввода кодового слова");
            }
        }
        public static void OpenFormNewPassword()
        {
            Application.Run(new FormNewPassword());
        }
    }
}
