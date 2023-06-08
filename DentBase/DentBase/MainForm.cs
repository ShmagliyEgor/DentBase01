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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewClient.AutoGenerateColumns = true;
            UpdateGrid(AllList());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void AddProblemBtn_Click(object sender, EventArgs e)
        {
            ProblemEdit problemedit = new ProblemEdit(false);
            problemedit.ShowDialog();
            
            UpdateGrid(AllList());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EditProblemBtn_Click(object sender, EventArgs e)
        {
            if(dataGridViewClient.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString());
                Problems problem = App.AModel.Problems.ToList().Find(p => p.id == id);
                ProblemEdit problemedit = new ProblemEdit(true, problem);
                problemedit.ShowDialog();

                UpdateGrid(AllList());
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString());
                Problems problem = App.AModel.Problems.ToList().Find(p => p.id == id);
                
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись  №" + problem.id, "Удаление записи", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (var clientproblem in App.AModel.ClientProblems)
                    {
                        if (clientproblem.idProblems == int.Parse(dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            App.AModel.ClientProblems.Remove(clientproblem);
                            break;
                        }
                    }
                    App.AModel.Problems.Remove(problem);
                    App.AModel.SaveChanges();
                }

                UpdateGrid(AllList());
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if(SearchTxt.Text.Length == 0)
            {
                UpdateGrid(AllList());
                return;
            }
            UpdateGrid(AllList().FindAll(grm => grm.FIO.Contains(SearchTxt.Text)));
        }

        List<GridRowModel> AllList()
        {
            List<GridRowModel> TargetList = new List<GridRowModel>();
            foreach(Problems problem in App.AModel.Problems.ToList())
            {
                GridRowModel newModel = new GridRowModel();
                MainClient client = App.AModel.MainClient.ToList().Find(c => c.id ==
                (App.AModel.ClientProblems.ToList().Find(cp => cp.idProblems == problem.id).idClient));
                newModel.SetValue(problem.id, client.FIO,problem.Description , problem.TimeRegister, problem.Cost, client.AgePacient);
                TargetList.Add(newModel);
            }
            return TargetList;
        }

        void UpdateGrid(List<GridRowModel> rows)
        {
            switch (SortBox.SelectedIndex)
            {
                default:
                    ClientBindingSource.DataSource = rows;
                    break;
                case 1:
                    ClientBindingSource.DataSource = (DownCheck.Checked)? rows.OrderBy(c => c.Cost): rows.OrderByDescending(c=> c.Cost);
                    break;
                case 2:
                    ClientBindingSource.DataSource = (DownCheck.Checked) ? rows.OrderBy(c => c.AgePacient): rows.OrderByDescending(c => c.AgePacient);
                    break;
                case 3:
                    ClientBindingSource.DataSource = (DownCheck.Checked)? rows.OrderBy(c => c.TimeRegister):rows.OrderByDescending(c=> c.TimeRegister);
                    break;
            }
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid(AllList());
        }

        private void DownCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid(AllList());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
