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
    public partial class MainClientForm : Form
    {
        public MainClientForm()
        {
            InitializeComponent();
            ClientGrid.AutoGenerateColumns = true;
            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void MainClientForm_Load(object sender, EventArgs e)
        {

        }

        void UpdateGrid(List<MainClient> rows)
        {
            switch (SortBox.SelectedIndex)
            {
                default:
                    ClientBindingSource.DataSource = rows;
                    break;
                case 1:
                    ClientBindingSource.DataSource = (DownCheck.Checked) ? rows.OrderBy(c => c.id) : rows.OrderByDescending(c => c.id);
                    break;
                case 2:
                    ClientBindingSource.DataSource = (DownCheck.Checked) ? rows.OrderBy(c => c.AgePacient) : rows.OrderByDescending(c => c.AgePacient);
                    break;
                case 3:
                    ClientBindingSource.DataSource = (DownCheck.Checked) ? rows.OrderBy(c => c.FIO) : rows.OrderByDescending(c => c.FIO);
                    break;
            }
        }

        private void AddProblemBtn_Click(object sender, EventArgs e)
        {
            ClientEdit clientedit = new ClientEdit(false);
            clientedit.ShowDialog();

            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void EditProblemBtn_Click(object sender, EventArgs e)
        {
            if (ClientGrid.SelectedRows.Count > 0)
            {
                int id = int.Parse(ClientGrid.SelectedRows[0].Cells[0].Value.ToString());
                MainClient client = App.AModel.MainClient.ToList().Find(p => p.id == id);
                ClientEdit problemedit = new ClientEdit(true, client);
                problemedit.ShowDialog();

                UpdateGrid(App.AModel.MainClient.ToList());
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (ClientGrid.SelectedRows.Count > 0)
            {
                int id = int.Parse(ClientGrid.SelectedRows[0].Cells[0].Value.ToString());
                MainClient client = App.AModel.MainClient.ToList().Find(p => p.id == id);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить пациента " + client.FIO, "Удаление записи", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (var clientproblem in App.AModel.ClientProblems)
                    {
                        if (clientproblem.idClient == int.Parse(ClientGrid.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            int problemid = clientproblem.idProblems;
                            App.AModel.ClientProblems.Remove(clientproblem);
                            App.AModel.Problems.Remove(App.AModel.Problems.Find(problemid));
                            break;
                        }
                    }
                    App.AModel.MainClient.Remove(client);
                    App.AModel.SaveChanges();
                    MessageBox.Show("Пациент успешно удалён");
                }

                UpdateGrid(App.AModel.MainClient.ToList());
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text.Length == 0)
            {
                UpdateGrid(App.AModel.MainClient.ToList());
                return;
            }
            UpdateGrid(App.AModel.MainClient.ToList().FindAll(grm => grm.FIO.Contains(SearchTxt.Text)));
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void DownCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid(App.AModel.MainClient.ToList());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MainClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
