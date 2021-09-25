
namespace OrganizerDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tasksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remindersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delRemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorizationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authControlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ignoreDate = new System.Windows.Forms.CheckBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.categoriesList = new System.Windows.Forms.CheckedListBox();
            this.tasksList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkAsDone = new System.Windows.Forms.CheckBox();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.programMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flaggedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programMenuItem,
            this.tasksMenuItem,
            this.categoriesMenuItem,
            this.remindersMenuItem,
            this.authorizationMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tasksMenuItem
            // 
            this.tasksMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskMenuItem,
            this.editTaskMenuItem,
            this.deleteTaskMenuItem});
            this.tasksMenuItem.Name = "tasksMenuItem";
            this.tasksMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tasksMenuItem.Text = "&Задачі";
            // 
            // addTaskMenuItem
            // 
            this.addTaskMenuItem.Name = "addTaskMenuItem";
            this.addTaskMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addTaskMenuItem.Text = "&Нова задача";
            this.addTaskMenuItem.Click += new System.EventHandler(this.addTaskMenuItem_Click);
            // 
            // editTaskMenuItem
            // 
            this.editTaskMenuItem.Name = "editTaskMenuItem";
            this.editTaskMenuItem.Size = new System.Drawing.Size(205, 22);
            this.editTaskMenuItem.Text = "&Редагувати задачу";
            this.editTaskMenuItem.Click += new System.EventHandler(this.editTaskMenuItem_Click);
            // 
            // deleteTaskMenuItem
            // 
            this.deleteTaskMenuItem.Name = "deleteTaskMenuItem";
            this.deleteTaskMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deleteTaskMenuItem.Text = "&Видалити задачу";
            // 
            // categoriesMenuItem
            // 
            this.categoriesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCatStripMenuItem,
            this.editCatStripMenuItem,
            this.deleteCatStripMenuItem});
            this.categoriesMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.categoriesMenuItem.Name = "categoriesMenuItem";
            this.categoriesMenuItem.Size = new System.Drawing.Size(79, 20);
            this.categoriesMenuItem.Text = "&Категорії";
            // 
            // addCatStripMenuItem
            // 
            this.addCatStripMenuItem.Name = "addCatStripMenuItem";
            this.addCatStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addCatStripMenuItem.Text = "&Додати категорію";
            this.addCatStripMenuItem.Click += new System.EventHandler(this.addCatStripMenuItem_Click);
            // 
            // editCatStripMenuItem
            // 
            this.editCatStripMenuItem.Name = "editCatStripMenuItem";
            this.editCatStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.editCatStripMenuItem.Text = "&Редагувати категорію";
            this.editCatStripMenuItem.Click += new System.EventHandler(this.editCatStripMenuItem_Click);
            // 
            // deleteCatStripMenuItem
            // 
            this.deleteCatStripMenuItem.Name = "deleteCatStripMenuItem";
            this.deleteCatStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.deleteCatStripMenuItem.Text = "&Видалити категорію";
            this.deleteCatStripMenuItem.Click += new System.EventHandler(this.deleteCatStripMenuItem_Click);
            // 
            // remindersMenuItem
            // 
            this.remindersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRemMenuItem,
            this.addRemMenuItem,
            this.editRemMenuItem,
            this.delRemMenuItem});
            this.remindersMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.remindersMenuItem.Name = "remindersMenuItem";
            this.remindersMenuItem.Size = new System.Drawing.Size(107, 20);
            this.remindersMenuItem.Text = "&Нагадування";
            // 
            // viewRemMenuItem
            // 
            this.viewRemMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.viewRemMenuItem.Name = "viewRemMenuItem";
            this.viewRemMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewRemMenuItem.Text = "&Перегляд";
            // 
            // addRemMenuItem
            // 
            this.addRemMenuItem.Name = "addRemMenuItem";
            this.addRemMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addRemMenuItem.Text = "&Додати";
            // 
            // editRemMenuItem
            // 
            this.editRemMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.editRemMenuItem.Name = "editRemMenuItem";
            this.editRemMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editRemMenuItem.Text = "&Редагувати";
            // 
            // delRemMenuItem
            // 
            this.delRemMenuItem.Name = "delRemMenuItem";
            this.delRemMenuItem.Size = new System.Drawing.Size(154, 22);
            this.delRemMenuItem.Text = "&Видалити";
            // 
            // authorizationMenuItem
            // 
            this.authorizationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authControlMenuItem});
            this.authorizationMenuItem.Name = "authorizationMenuItem";
            this.authorizationMenuItem.Size = new System.Drawing.Size(97, 20);
            this.authorizationMenuItem.Text = "&Авторізація";
            // 
            // authControlMenuItem
            // 
            this.authControlMenuItem.Name = "authControlMenuItem";
            this.authControlMenuItem.Size = new System.Drawing.Size(230, 22);
            this.authControlMenuItem.Text = "&Параметри авторизації";
            this.authControlMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.authControlMenuItem.Click += new System.EventHandler(this.authControlMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ignoreDate);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.categoriesList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(880, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ignoreDate
            // 
            this.ignoreDate.AutoSize = true;
            this.ignoreDate.Location = new System.Drawing.Point(158, 50);
            this.ignoreDate.Name = "ignoreDate";
            this.ignoreDate.Size = new System.Drawing.Size(149, 20);
            this.ignoreDate.TabIndex = 6;
            this.ignoreDate.Text = "Задачі за весь час";
            this.ignoreDate.UseVisualStyleBackColor = true;
            this.ignoreDate.CheckedChanged += new System.EventHandler(this.ignoreDate_CheckedChanged);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(158, 22);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 22);
            this.dateTime.TabIndex = 3;
            // 
            // categoriesList
            // 
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(364, 19);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(236, 140);
            this.categoriesList.TabIndex = 5;
            this.categoriesList.SelectedIndexChanged += new System.EventHandler(this.categoriesList_SelectedIndexChanged);
            // 
            // tasksList
            // 
            this.tasksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.categoryColumn,
            this.dateColumn,
            this.timeColumn,
            this.statusColumn,
            this.flaggedColumn});
            this.tasksList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksList.FullRowSelect = true;
            this.tasksList.HideSelection = false;
            this.tasksList.Location = new System.Drawing.Point(3, 18);
            this.tasksList.Name = "tasksList";
            this.tasksList.Size = new System.Drawing.Size(874, 282);
            this.tasksList.TabIndex = 6;
            this.tasksList.UseCompatibleStateImageBehavior = false;
            this.tasksList.View = System.Windows.Forms.View.Details;
            this.tasksList.SelectedIndexChanged += new System.EventHandler(this.tasksList_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Задача";
            this.nameColumn.Width = 140;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Категорія";
            this.categoryColumn.Width = 140;
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Час";
            this.timeColumn.Width = 120;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Статус";
            this.statusColumn.Width = 146;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkAsDone);
            this.groupBox2.Controls.Add(this.textInfo);
            this.groupBox2.Controls.Add(this.tasksList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 455);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задачі";
            // 
            // checkAsDone
            // 
            this.checkAsDone.AutoSize = true;
            this.checkAsDone.Location = new System.Drawing.Point(631, 344);
            this.checkAsDone.Name = "checkAsDone";
            this.checkAsDone.Size = new System.Drawing.Size(237, 20);
            this.checkAsDone.TabIndex = 6;
            this.checkAsDone.Text = "Позначити задачу, як виконану";
            this.checkAsDone.UseVisualStyleBackColor = true;
            // 
            // textInfo
            // 
            this.textInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.textInfo.Location = new System.Drawing.Point(3, 300);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(622, 152);
            this.textInfo.TabIndex = 7;
            // 
            // programMenuItem
            // 
            this.programMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.programMenuItem.Name = "programMenuItem";
            this.programMenuItem.Size = new System.Drawing.Size(85, 20);
            this.programMenuItem.Text = "&Програма";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.exitMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitMenuItem.Text = "&Вихід";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::OrganizerDemo.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Дата";
            this.dateColumn.Width = 145;
            // 
            // flaggedColumn
            // 
            this.flaggedColumn.Text = "Позначена";
            this.flaggedColumn.Width = 220;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер Мо";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem remindersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCatStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delRemMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem authorizationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authControlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskMenuItem;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.CheckedListBox categoriesList;
        private System.Windows.Forms.ListView tasksList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem editCatStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCatStripMenuItem;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.ColumnHeader timeColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.CheckBox checkAsDone;
        private System.Windows.Forms.CheckBox ignoreDate;
        private System.Windows.Forms.ToolStripMenuItem programMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader flaggedColumn;
    }
}

