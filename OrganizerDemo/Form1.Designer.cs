
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
            this.remindersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delRemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.categoryList = new System.Windows.Forms.CheckedListBox();
            this.eventsList = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteToolStripMenuItem.Text = "&Видалити подію";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editToolStripMenuItem.Text = "&Редагувати подію";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(347, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(6, 35);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(120, 225);
            this.categoryList.TabIndex = 5;
            // 
            // eventsList
            // 
            this.eventsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.columnHeader2});
            this.eventsList.Dock = System.Windows.Forms.DockStyle.Right;
            this.eventsList.HideSelection = false;
            this.eventsList.Location = new System.Drawing.Point(206, 18);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(671, 394);
            this.eventsList.TabIndex = 6;
            this.eventsList.UseCompatibleStateImageBehavior = false;
            this.eventsList.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eventsList);
            this.groupBox2.Controls.Add(this.categoryList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 415);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Події";
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
            // Name
            // 
            this.Name.Text = "Назва";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Категорія";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер Мо";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox categoryList;
        private System.Windows.Forms.ListView eventsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem editCatStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCatStripMenuItem;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

