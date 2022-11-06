namespace COMP282_Assignment_2
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.PeopleOutputBox = new System.Windows.Forms.ListBox();
            this.NameSortButton = new System.Windows.Forms.Button();
            this.AgeSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(13, 42);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(373, 22);
            this.NameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(418, 42);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 22);
            this.AgeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 80);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 31);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(121, 79);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 32);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(234, 79);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 32);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PeopleOutputBox
            // 
            this.PeopleOutputBox.FormattingEnabled = true;
            this.PeopleOutputBox.ItemHeight = 16;
            this.PeopleOutputBox.Location = new System.Drawing.Point(13, 124);
            this.PeopleOutputBox.Name = "PeopleOutputBox";
            this.PeopleOutputBox.Size = new System.Drawing.Size(505, 180);
            this.PeopleOutputBox.TabIndex = 7;
            this.PeopleOutputBox.SelectedIndexChanged += new System.EventHandler(this.PeopleOutputBox_SelectedIndexChanged);
            // 
            // NameSortButton
            // 
            this.NameSortButton.Location = new System.Drawing.Point(13, 322);
            this.NameSortButton.Name = "NameSortButton";
            this.NameSortButton.Size = new System.Drawing.Size(105, 28);
            this.NameSortButton.TabIndex = 8;
            this.NameSortButton.Text = "Name Sort";
            this.NameSortButton.UseVisualStyleBackColor = true;
            this.NameSortButton.Click += new System.EventHandler(this.NameSortButton_Click);
            // 
            // AgeSortButton
            // 
            this.AgeSortButton.Location = new System.Drawing.Point(141, 322);
            this.AgeSortButton.Name = "AgeSortButton";
            this.AgeSortButton.Size = new System.Drawing.Size(96, 28);
            this.AgeSortButton.TabIndex = 9;
            this.AgeSortButton.Text = "Age Sort";
            this.AgeSortButton.UseVisualStyleBackColor = true;
            this.AgeSortButton.Click += new System.EventHandler(this.AgeSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 372);
            this.Controls.Add(this.AgeSortButton);
            this.Controls.Add(this.NameSortButton);
            this.Controls.Add(this.PeopleOutputBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "COMP282 Assignment 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox PeopleOutputBox;
        private System.Windows.Forms.Button NameSortButton;
        private System.Windows.Forms.Button AgeSortButton;
    }
}

