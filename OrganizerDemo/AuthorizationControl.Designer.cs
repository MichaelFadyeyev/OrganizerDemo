
namespace OrganizerDemo
{
    partial class AuthorizationControl
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
            this.passwProtection = new System.Windows.Forms.CheckBox();
            this.controls = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwProtection
            // 
            this.passwProtection.AutoSize = true;
            this.passwProtection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwProtection.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.passwProtection.Location = new System.Drawing.Point(36, 23);
            this.passwProtection.Name = "passwProtection";
            this.passwProtection.Size = new System.Drawing.Size(132, 20);
            this.passwProtection.TabIndex = 9;
            this.passwProtection.Text = "Захист паролем";
            this.passwProtection.UseVisualStyleBackColor = true;
            // 
            // controls
            // 
            this.controls.Controls.Add(this.resetButton);
            this.controls.Controls.Add(this.setButton);
            this.controls.Controls.Add(this.textBox1);
            this.controls.Controls.Add(this.label1);
            this.controls.Controls.Add(this.passwField);
            this.controls.Controls.Add(this.label2);
            this.controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controls.Location = new System.Drawing.Point(0, 44);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(317, 200);
            this.controls.TabIndex = 10;
            this.controls.TabStop = false;
            this.controls.Text = "controls";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(169, 132);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 30);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Скинути";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // setButton
            // 
            this.setButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setButton.Location = new System.Drawing.Point(39, 132);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(100, 30);
            this.setButton.TabIndex = 12;
            this.setButton.Text = "Встановити";
            this.setButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(39, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Повторне введення паролю:";
            // 
            // passwField
            // 
            this.passwField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwField.Location = new System.Drawing.Point(39, 35);
            this.passwField.Name = "passwField";
            this.passwField.PasswordChar = '*';
            this.passwField.Size = new System.Drawing.Size(230, 22);
            this.passwField.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль:";
            // 
            // AuthorizationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 244);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.passwProtection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthorizationControl";
            this.Text = "Керування авторизацією";
            this.Load += new System.EventHandler(this.AuthorizationControl_Load);
            this.controls.ResumeLayout(false);
            this.controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox passwProtection;
        private System.Windows.Forms.GroupBox controls;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwField;
        private System.Windows.Forms.Label label2;
    }
}