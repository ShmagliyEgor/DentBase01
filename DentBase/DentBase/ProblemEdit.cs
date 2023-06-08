using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace DentBase
{
    public partial class ProblemEdit : Form
    {
        public bool EditMode;
        Problems thisProblem;
        int targetClient;
        public ProblemEdit(bool editMode, Problems problem = null)
        {
            InitializeComponent();
            foreach (MainClient client in App.AModel.MainClient)
            {
                ClientComboBox.Items.Add(client.FIO);
            }
            EditMode = editMode;
            if (editMode)
            {
                CostTextBox.Text = problem.Cost.ToString();
                descriptionTextBox.Text = problem.Description;
                LabelTalon.Text = problem.id.ToString();
                dateTimePickerRegister.Value = problem.TimeRegister;
                ClientProblems cp = App.AModel.ClientProblems.ToList().Find(p => p.idProblems == problem.id);
                targetClient = App.AModel.MainClient.ToList().Find(c => c.id == cp.idClient).id-1;
                ClientComboBox.SelectedIndex = targetClient;
            }
            else
            {
                DeleteBtn.Visible = false;
            }

            if (problem != null)
            {
                thisProblem = problem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            decimal cost;
            if (decimal.TryParse(CostTextBox.Text, out cost))
            {
                Problems problem = new Problems()
                {
                    Cost = int.Parse(CostTextBox.Text),
                    Description = descriptionTextBox.Text,
                    TimeRegister = dateTimePickerRegister.Value
                };
                if (EditMode)
                {
                    try
                    {
                        App.AModel.Problems.ToList().Find(p => p.id == thisProblem.id).UpdateValue(problem);
                        App.AModel.SaveChanges();
                        MessageBox.Show("Запись успешно сохранена");
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
                        App.AModel.Problems.Add(problem);
                        App.AModel.SaveChanges();
                        App.AModel.ClientProblems.Add(new ClientProblems() {idProblems = App.AModel.Problems.ToList().Last().id, idClient = targetClient });
                        App.AModel.SaveChanges();
                        MessageBox.Show("Запись успешно добавлена");
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
                MessageBox.Show("в поле \"Цена\" могут быть только десятичные дроби");
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись  №" + thisProblem.id, "Удаление записи", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach(var clientproblem  in App.AModel.ClientProblems)
                {
                    if(clientproblem.idProblems == thisProblem.id)
                    {
                        App.AModel.ClientProblems.Remove(clientproblem);
                        break;
                    }
                }
                App.AModel.Problems.Remove(thisProblem);
                App.AModel.SaveChanges();
            }
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetClient = App.AModel.MainClient.ToList().Find(c => c.FIO == ClientComboBox.Items[ClientComboBox.SelectedIndex]).id;
        }

        private void ProblemEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
