using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КУРСАЧ
{
    public partial class Auth : Form
    {
        public string LastAuthUser = "";
        Database DB = new Database("Data Source=dataBase.DB; Version = 3;");
        public Auth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createacc_Click(object sender, EventArgs e)
        {

            var dialogResultFormRegistration = new Reg().ShowDialog();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxLogin.Text) || string.IsNullOrEmpty(TextBoxPass.Text))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userAuthSucceess() == true)
                {
                    LastAuthUser = TextBoxPass.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
        }

        private void ButAuthExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool userAuthSucceess() //проверка успешности авторизации
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Поля заполнены некорректно.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (hasUser(TextBoxLogin.Text, TextBoxPass.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool hasUser(string login, string password) //проверка существования пользователя
        {
            return DB.CheckUser(login, password, false);
        }
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(TextBoxLogin.Text) || isUnCorrectField(TextBoxPass.Text))
                return true;
            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field)) //проверка на пустую строку (или только пробелы)
                return true;
            return false;
        }
    }
}
