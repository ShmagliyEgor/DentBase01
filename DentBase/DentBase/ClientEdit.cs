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
    public partial class ClientEdit : Form
    {
        public bool EditMode;
        MainClient mainclient;
        public ClientEdit(bool editMode, MainClient client = null)
        {
            InitializeComponent();
            EditMode = editMode;
            if (editMode)
            {
                AgePacientUpDown.Value = (decimal)client.AgePacient;
                FIOTextBox.Text = client.FIO;
            }
            else
            {
                DeleteBtn.Visible = false;
            }

            if (client != null)
            {
                mainclient = client;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (FIOTextBox.Text != "")
            {
                MainClient mc = new MainClient()
                {
                    AgePacient = (int)AgePacientUpDown.Value,
                    FIO = FIOTextBox.Text,
                };
                if (EditMode)
                {
                    try
                    {
                        App.AModel.MainClient.ToList().Find(c => c.id == mainclient.id).UpdateValue(mc);
                        App.AModel.SaveChanges();
                        MessageBox.Show("Пациент успешно сохранён");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        App.AModel.MainClient.Add(mc);
                        App.AModel.SaveChanges();
                        MessageBox.Show("Пациент успешно добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Поле \"Имя пациента\" не может быть пустым");
            }

        }

        private void ClientEdit_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить пациента " + mainclient.FIO, "Удаление пациента", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (var clientproblem in App.AModel.ClientProblems)
                {
                    if (clientproblem.idClient == mainclient.id)
                    {
                        App.AModel.ClientProblems.Remove(clientproblem);
                        break;
                    }
                }
                App.AModel.MainClient.Remove(mainclient);
                App.AModel.SaveChanges();
                MessageBox.Show("Пациент успешно удалён");
            }
            this.Close();
        }

        private void articleNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
