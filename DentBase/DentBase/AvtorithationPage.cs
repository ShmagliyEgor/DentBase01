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
    public partial class AvtorithationPage : Form
    {
        public AvtorithationPage()
        {
            InitializeComponent();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (App.AModel.Avtorithations.ToList().Find(a => a.Login == TextBoxLogin.Text && a.Password == TextBoxPassword.Text) != null)
            {
                MainMenu mainForm = new MainMenu();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введён неправильно логин или пароль");

            }

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AvtorithationPage_Load(object sender, EventArgs e)
        {
         

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
