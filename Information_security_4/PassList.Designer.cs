﻿
namespace Information_security_4
{
    partial class PassList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.app_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.exit_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.Copy_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.PasswordColumn,
            this.AppColumn,
            this.DescriptionColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.Name = "PasswordColumn";
            // 
            // AppColumn
            // 
            this.AppColumn.HeaderText = "App/URL";
            this.AppColumn.Name = "AppColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.Width = 1000;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(677, 43);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(42, 20);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "[titel]";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(677, 101);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(85, 20);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "[password]";
            // 
            // app_label
            // 
            this.app_label.AutoSize = true;
            this.app_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.app_label.Location = new System.Drawing.Point(677, 155);
            this.app_label.Name = "app_label";
            this.app_label.Size = new System.Drawing.Size(44, 20);
            this.app_label.TabIndex = 3;
            this.app_label.Text = "[app]";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(677, 250);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(64, 13);
            this.description_label.TabIndex = 4;
            this.description_label.Text = "[description]";
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_label.Location = new System.Drawing.Point(949, 12);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(41, 20);
            this.exit_label.TabIndex = 5;
            this.exit_label.Text = "[exit]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(885, 93);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(105, 38);
            this.show_button.TabIndex = 7;
            this.show_button.Text = "Show";
            this.show_button.UseVisualStyleBackColor = true;
            // 
            // Copy_button
            // 
            this.Copy_button.Location = new System.Drawing.Point(885, 137);
            this.Copy_button.Name = "Copy_button";
            this.Copy_button.Size = new System.Drawing.Size(105, 38);
            this.Copy_button.TabIndex = 8;
            this.Copy_button.Text = "Copy";
            this.Copy_button.UseVisualStyleBackColor = true;
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(885, 181);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(105, 38);
            this.Update_button.TabIndex = 9;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(885, 225);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(105, 38);
            this.Delete_button.TabIndex = 10;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // PassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 545);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Copy_button);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.app_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PassList";
            this.Text = "PassList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label app_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label exit_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button Copy_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
    }
}