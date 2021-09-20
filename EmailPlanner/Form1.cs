using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows.Forms;

namespace EmailPlanner
{
    public partial class mainForm : Form
    {
        EmailPlannerContext db;
        public mainForm()
        {
            InitializeComponent();

            db = new EmailPlannerContext();
            db.EmailPlans.Load();

            emailPlansDataGridView.DataSource = db.EmailPlans.Local.ToBindingList();

            emailPlansDataGridView.Sort(emailPlansDataGridView.Columns["Id"], ListSortDirection.Descending);

            emailPlansDataGridView.Columns[0].HeaderText = "ID";
            emailPlansDataGridView.Columns[1].HeaderText = "Ім’я";
            emailPlansDataGridView.Columns[2].HeaderText = "Email";
            emailPlansDataGridView.Columns[3].HeaderText = "Перший лист";
            emailPlansDataGridView.Columns[4].HeaderText = "Другий лист";
            emailPlansDataGridView.Columns[5].HeaderText = "Третій лист";
            emailPlansDataGridView.Columns[6].HeaderText = "Четвертий лист";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PlanForm planForm = new PlanForm();
            DialogResult result = planForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            
                EmailPlan emailPlan = new EmailPlan();
                emailPlan.Name = planForm.nameTextBox.Text;
                emailPlan.Email = planForm.emailTextBox.Text;
                emailPlan.FirstLetterDate = Convert.ToDateTime(planForm.firstLetterDateTimePicker.Value.ToShortDateString());
                emailPlan.SecondLetterDate = Convert.ToDateTime(planForm.secondLetterDateTimePicker.Value.ToShortDateString());
                emailPlan.ThirdLetterDate = Convert.ToDateTime(planForm.thirdLetterDateTimePicker.Value.ToShortDateString());
                emailPlan.FourthLetterDate = Convert.ToDateTime(planForm.fourthLetterDateTimePicker.Value.ToShortDateString());

                db.EmailPlans.Add(emailPlan);
                db.SaveChanges();
            emailPlansDataGridView.Sort(emailPlansDataGridView.Columns["Id"], ListSortDirection.Descending);
            MessageBox.Show("Додано");
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            if (emailPlansDataGridView.SelectedRows.Count > 0)
            {
                int index = emailPlansDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(emailPlansDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                EmailPlan emailPlan= db.EmailPlans.Find(id);

                PlanForm planForm = new PlanForm();

                planForm.nameTextBox.Text = emailPlan.Name;

                planForm.emailTextBox.Text= emailPlan.Email;
                planForm.firstLetterDateTimePicker.Value=emailPlan.FirstLetterDate;
                planForm.secondLetterDateTimePicker.Value = emailPlan.SecondLetterDate;
                planForm.thirdLetterDateTimePicker.Value = emailPlan.ThirdLetterDate;
                planForm.fourthLetterDateTimePicker.Value = emailPlan.FourthLetterDate;

                DialogResult result = planForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                emailPlan.Name = planForm.nameTextBox.Text;
                emailPlan.Email = planForm.emailTextBox.Text;
                emailPlan.FirstLetterDate = Convert.ToDateTime(planForm.firstLetterDateTimePicker.Value.ToShortDateString());
                emailPlan.SecondLetterDate = Convert.ToDateTime(planForm.secondLetterDateTimePicker.Value.ToShortDateString());
                emailPlan.ThirdLetterDate = Convert.ToDateTime(planForm.thirdLetterDateTimePicker.Value.ToShortDateString());
                emailPlan.FourthLetterDate = Convert.ToDateTime(planForm.fourthLetterDateTimePicker.Value.ToShortDateString());

                db.SaveChanges();
                emailPlansDataGridView.Refresh(); // обновляем грид
                MessageBox.Show("Дані оновлено");

            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (emailPlansDataGridView.SelectedRows.Count > 0)
            {
                int index = emailPlansDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(emailPlansDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                EmailPlan emailPlan = db.EmailPlans.Find(id);
                db.EmailPlans.Remove(emailPlan);
                db.SaveChanges();

                MessageBox.Show("Видалено");
            }
        }

    }
}
