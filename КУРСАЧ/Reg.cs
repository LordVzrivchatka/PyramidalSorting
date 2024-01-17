using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КУРСАЧ
{
    
    public partial class Reg : Form
    {

        Database DB = new Database ("Data Source=dataBase.DB; Version = 3;");
        public string RegUser = "";

        public Reg()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void RegCreate_Click(object sender, EventArgs e)
        { 

            if (String.IsNullOrWhiteSpace(RegLogin.Text) ||
                String.IsNullOrWhiteSpace(RegPass1.Text) ||
                String.IsNullOrWhiteSpace(RegPass2.Text))
            {
                MessageBox.Show("Поля заполнены некорректно.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (RegPass1.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать миниммум 8 символов.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (RegPass1.Text != RegPass2.Text)
            {
                MessageBox.Show("Пароли должны совпадать.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else 
            {
                if (DB.CheckUser(RegLogin.Text))
                {
                    MessageBox.Show("Такой пользователь уже существует. Войдите в аккаунт или придумайте новый логин.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RegUser = RegLogin.Text;
                DB.CreateUser(RegLogin.Text, RegPass1.Text);
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }

        }

        private void ButtonRegCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
