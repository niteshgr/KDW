﻿namespace projectKDW
{
    partial class change_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmtextBox = new System.Windows.Forms.TextBox();
            this.newtextBox = new System.Windows.Forms.TextBox();
            this.change_password_button = new System.Windows.Forms.Button();
            this.label01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter New Password";
            // 
            // confirmtextBox
            // 
            this.confirmtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmtextBox.Location = new System.Drawing.Point(618, 287);
            this.confirmtextBox.Name = "confirmtextBox";
            this.confirmtextBox.PasswordChar = '*';
            this.confirmtextBox.Size = new System.Drawing.Size(235, 32);
            this.confirmtextBox.TabIndex = 3;
            this.confirmtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmtextBox_KeyDown);
            // 
            // newtextBox
            // 
            this.newtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtextBox.Location = new System.Drawing.Point(618, 233);
            this.newtextBox.Name = "newtextBox";
            this.newtextBox.PasswordChar = '*';
            this.newtextBox.Size = new System.Drawing.Size(232, 32);
            this.newtextBox.TabIndex = 4;
            this.newtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.newtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newtextBox_KeyDown);
            // 
            // change_password_button
            // 
            this.change_password_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_password_button.Location = new System.Drawing.Point(500, 370);
            this.change_password_button.Name = "change_password_button";
            this.change_password_button.Size = new System.Drawing.Size(235, 36);
            this.change_password_button.TabIndex = 5;
            this.change_password_button.Text = "Change Password";
            this.change_password_button.UseVisualStyleBackColor = true;
            this.change_password_button.Click += new System.EventHandler(this.change_password_button_Click);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Enabled = false;
            this.label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.ForeColor = System.Drawing.Color.Red;
            this.label01.Location = new System.Drawing.Point(520, 426);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(0, 25);
            this.label01.TabIndex = 6;
            // 
            // change_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label01);
            this.Controls.Add(this.change_password_button);
            this.Controls.Add(this.newtextBox);
            this.Controls.Add(this.confirmtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "change_UserControl";
            this.Size = new System.Drawing.Size(1262, 655);
            this.Load += new System.EventHandler(this.change_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmtextBox;
        private System.Windows.Forms.TextBox newtextBox;
        private System.Windows.Forms.Button change_password_button;
        private System.Windows.Forms.Label label01;
    }
}
