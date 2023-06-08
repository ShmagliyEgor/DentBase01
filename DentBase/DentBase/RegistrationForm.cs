using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentBase
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(TextBoxLogin.Text != "" && TextBoxPassword.Text != "")
            {
                if(TextBoxPassword.Text.Length < 6)
                {
                    MessageBox.Show("Пароль не может быть меньше шести символов");
                    return;
                }

                if(App.AModel.Avtorithations.ToList().Find(a => a.Login == TextBoxLogin.Text) != null)
                {
                    MessageBox.Show("Данный логин занят");
                    return;
                }

                try
                {
                    App.AModel.Avtorithations.Add(new Avtorithation() { Login = TextBoxLogin.Text, Password = TextBoxPassword.Text });
                    App.AModel.SaveChanges();
                }catch(Exception ex) { }

                MessageBox.Show("Пользователь добавлен в систему");

                this.Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
