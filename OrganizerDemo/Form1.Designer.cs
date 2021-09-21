
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
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remindersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.categoryList = new System.Windows.Forms.CheckedListBox();
            this.eventsList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textInfo = new System.Windows.Forms.TextBox();
            this.checkAsDone = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.remindersToolStripMenuItem,
            this.authorizationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.eventsToolStripMenuItem.Text = "&Події";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addToolStripMenuItem.Text = "&Додати подію";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editToolStripMenuItem.Text = "&Редагувати подію";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteToolStripMenuItem.Text = "&Видалити подію";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCatStripMenuItem,
            this.editCatStripMenuItem,
            this.deleteCatStripMenuItem});
            this.categoriesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.categoriesToolStripMenuItem.Text = "&Категорії";
            // 
            // addCatStripMenuItem
            // 
            this.addCatStripMenuItem.Name = "addCatStripMenuItem";
            this.addCatStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addCatStripMenuItem.Text = "&Додати категорію";
            // 
            // editCatStripMenuItem
            // 
            this.editCatStripMenuItem.Name = "editCatStripMenuItem";
            this.editCatStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.editCatStripMenuItem.Text = "&Редагувати категорію";
            // 
            // deleteCatStripMenuItem
            // 
            this.deleteCatStripMenuItem.Name = "deleteCatStripMenuItem";
            this.deleteCatStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.deleteCatStripMenuItem.Text = "&Видалити категорію";
            // 
            // remindersToolStripMenuItem
            // 
            this.remindersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRemToolStripMenuItem,
            this.addRemToolStripMenuItem,
            this.editRemToolStripMenuItem,
            this.delRemToolStripMenuItem});
            this.remindersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.remindersToolStripMenuItem.Name = "remindersToolStripMenuItem";
            this.remindersToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.remindersToolStripMenuItem.Text = "&Нагадування";
            // 
            // viewRemToolStripMenuItem
            // 
            this.viewRemToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.viewRemToolStripMenuItem.Name = "viewRemToolStripMenuItem";
            this.viewRemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewRemToolStripMenuItem.Text = "&Перегляд";
            // 
            // addRemToolStripMenuItem
            // 
            this.addRemToolStripMenuItem.Name = "addRemToolStripMenuItem";
            this.addRemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRemToolStripMenuItem.Text = "&Додати";
            // 
            // editRemToolStripMenuItem
            // 
            this.editRemToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.editRemToolStripMenuItem.Name = "editRemToolStripMenuItem";
            this.editRemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRemToolStripMenuItem.Text = "&Редагувати";
            // 
            // delRemToolStripMenuItem
            // 
            this.delRemToolStripMenuItem.Name = "delRemToolStripMenuItem";
            this.delRemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delRemToolStripMenuItem.Text = "&Видалити";
            // 
            // authorizationToolStripMenuItem
            // 
            this.authorizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.authorizationToolStripMenuItem.Name = "authorizationToolStripMenuItem";
            this.authorizationToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.authorizationToolStripMenuItem.Text = "&Авторізація";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "&Змінити пароль";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.categoryList);
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
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(183, 19);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 22);
            this.dateTime.TabIndex = 3;
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(402, 19);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(115, 140);
            this.categoryList.TabIndex = 5;
            // 
            // eventsList
            // 
            this.eventsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.categoryColumn,
            this.timeColumn,
            this.statusColumn});
            this.eventsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.eventsList.HideSelection = false;
            this.eventsList.Location = new System.Drawing.Point(3, 18);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(671, 394);
            this.eventsList.TabIndex = 6;
            this.eventsList.UseCompatibleStateImageBehavior = false;
            this.eventsList.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Назва";
            this.nameColumn.Width = 390;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Категорія";
            this.categoryColumn.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.eventsList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 415);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Події";
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Заплановано на";
            this.timeColumn.Width = 120;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Статус";
            this.statusColumn.Width = 80;
            // 
            // textInfo
            // 
            this.textInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.textInfo.Location = new System.Drawing.Point(3, 18);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(194, 341);
            this.textInfo.TabIndex = 7;
            // 
            // checkAsDone
            // 
            this.checkAsDone.AutoSize = true;
            this.checkAsDone.Location = new System.Drawing.Point(6, 365);
            this.checkAsDone.Name = "checkAsDone";
            this.checkAsDone.Size = new System.Drawing.Size(91, 20);
            this.checkAsDone.TabIndex = 6;
            this.checkAsDone.Text = "Виконане";
            this.checkAsDone.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkAsDone);
            this.groupBox3.Controls.Add(this.textInfo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(677, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 394);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Опис події:";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem remindersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCatStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delRemToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem authorizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.CheckedListBox categoryList;
        private System.Windows.Forms.ListView eventsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem editCatStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCatStripMenuItem;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.ColumnHeader timeColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkAsDone;
    }
}

