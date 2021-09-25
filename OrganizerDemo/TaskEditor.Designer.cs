
namespace OrganizerDemo
{
    partial class TaskEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.taskField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoField = new System.Windows.Forms.TextBox();
            this.dateSet = new System.Windows.Forms.DateTimePicker();
            this.isDoneCheck = new System.Windows.Forms.CheckBox();
            this.flaggedCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.ComboBox();
            this.timeSet = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(39, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(28, 16);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(81, 466);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(125, 27);
            this.executeButton.TabIndex = 3;
            this.executeButton.Text = "Застосувати";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // taskField
            // 
            this.taskField.Location = new System.Drawing.Point(42, 77);
            this.taskField.Name = "taskField";
            this.taskField.Size = new System.Drawing.Size(220, 22);
            this.taskField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назва задачі";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Назва категорії:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Розширена інформація:";
            // 
            // infoField
            // 
            this.infoField.Location = new System.Drawing.Point(42, 191);
            this.infoField.Multiline = true;
            this.infoField.Name = "infoField";
            this.infoField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoField.Size = new System.Drawing.Size(220, 138);
            this.infoField.TabIndex = 5;
            // 
            // dateSet
            // 
            this.dateSet.Location = new System.Drawing.Point(42, 371);
            this.dateSet.Name = "dateSet";
            this.dateSet.Size = new System.Drawing.Size(158, 22);
            this.dateSet.TabIndex = 6;
            // 
            // isDoneCheck
            // 
            this.isDoneCheck.AutoSize = true;
            this.isDoneCheck.Location = new System.Drawing.Point(42, 408);
            this.isDoneCheck.Name = "isDoneCheck";
            this.isDoneCheck.Size = new System.Drawing.Size(186, 20);
            this.isDoneCheck.TabIndex = 7;
            this.isDoneCheck.Text = "Позначити, як виконане";
            this.isDoneCheck.UseVisualStyleBackColor = true;
            // 
            // flaggedCheck
            // 
            this.flaggedCheck.AutoSize = true;
            this.flaggedCheck.Location = new System.Drawing.Point(42, 434);
            this.flaggedCheck.Name = "flaggedCheck";
            this.flaggedCheck.Size = new System.Drawing.Size(180, 20);
            this.flaggedCheck.TabIndex = 7;
            this.flaggedCheck.Text = "Позначити, як важливе";
            this.flaggedCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата і час виконання:";
            // 
            // categoriesList
            // 
            this.categoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(42, 134);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(220, 24);
            this.categoriesList.TabIndex = 8;
            // 
            // timeSet
            // 
            this.timeSet.Location = new System.Drawing.Point(206, 371);
            this.timeSet.Name = "timeSet";
            this.timeSet.ShowUpDown = true;
            this.timeSet.Size = new System.Drawing.Size(56, 22);
            this.timeSet.TabIndex = 6;
            // 
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 531);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.flaggedCheck);
            this.Controls.Add(this.isDoneCheck);
            this.Controls.Add(this.timeSet);
            this.Controls.Add(this.dateSet);
            this.Controls.Add(this.infoField);
            this.Controls.Add(this.taskField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskEditor";
            this.Text = "Редактор задач";
            this.Load += new System.EventHandler(this.TaskEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox taskField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox infoField;
        private System.Windows.Forms.DateTimePicker dateSet;
        private System.Windows.Forms.CheckBox isDoneCheck;
        private System.Windows.Forms.CheckBox flaggedCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoriesList;
        private System.Windows.Forms.DateTimePicker timeSet;
    }
}