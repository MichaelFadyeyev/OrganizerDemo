using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizerDemo.Models;

namespace OrganizerDemo
{
    public partial class TaskEditor : Form
    {
        public string OperationTitle { get; set; }
        public string TaskName { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string Info { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool IsDone { get; set; }
        public bool Flagged { get; set; }
        public List<Category> Categories { get; set; }
        public List<Task_> Tasks { get; set; }

        public TaskEditor()
        {
            InitializeComponent();
        }

        private void TaskEditor_Load(object sender, EventArgs e)
        {
            title.Text = OperationTitle;
            foreach (var category in Categories)
            {
                categoriesList.Items.Add(category.Name);
            }
            timeSet.Format = DateTimePickerFormat.Custom;
            timeSet.CustomFormat = "HH:MM";
            timeSet.ShowUpDown = true;
            if (OperationTitle== "Редагувння задачі")
            {
                taskField.Text = TaskName;
                infoField.Text = Info;
                dateSet.Value = Date;
                timeSet.Value = Time;
                isDoneCheck.Checked = IsDone;
                flaggedCheck.Checked = Flagged;
                categoriesList.SelectedIndex = categoriesList.FindStringExact(CategoryName);
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(taskField.Text))
                MessageBox.Show("Введіть назву задачі", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (OperationTitle == "Нова задача" &&
               Tasks.Find(t => t.Name == taskField.Text) != null &&
               Tasks.Find(t => t.Date == dateSet.Value) != null &&
               Tasks.Find(t => t.Time == timeSet.Value) != null)
            {
                MessageBox.Show("Задача вже запланована на даний час", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                TaskName = taskField.Text;

            if (String.IsNullOrEmpty(infoField.Text))
                Info = "";
            else
                Info = infoField.Text;

            if (dateSet.Value < DateTime.Today)
                    MessageBox.Show("Введіть коректну дату початку для задачі", "Увага",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
                Date = dateSet.Value;

            if (timeSet.Value < DateTime.Now)
                    MessageBox.Show("Введіть коректний час початку для задачі", "Увага",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Time = timeSet.Value;

            IsDone = isDoneCheck.Checked;
            Flagged = flaggedCheck.Checked;
            CategoryId = Categories.Find(c => c.Name == (string)categoriesList.SelectedItem).Id;
            this.DialogResult = DialogResult.OK;
        }
    }
}
