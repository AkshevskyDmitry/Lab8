using System.ComponentModel;

namespace SessionForms
{
	partial class AddRow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
            this.CourseText = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HireDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Commision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseText
            // 
            this.CourseText.Location = new System.Drawing.Point(12, 33);
            this.CourseText.Name = "CourseText";
            this.CourseText.Size = new System.Drawing.Size(100, 23);
            this.CourseText.TabIndex = 0;
            this.CourseText.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(106, 30);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 1;
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(106, 59);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(100, 22);
            this.Department.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(106, 88);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 22);
            this.LastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            // 
            // HireDate
            // 
            this.HireDate.Location = new System.Drawing.Point(106, 118);
            this.HireDate.Name = "HireDate";
            this.HireDate.Size = new System.Drawing.Size(100, 22);
            this.HireDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hire date";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(106, 146);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(100, 22);
            this.Salary.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // Commision
            // 
            this.Commision.Location = new System.Drawing.Point(106, 174);
            this.Commision.Name = "Commision";
            this.Commision.Size = new System.Drawing.Size(100, 22);
            this.Commision.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Commision";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(76, 214);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 25);
            this.Add.TabIndex = 12;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddRow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(246, 261);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Commision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HireDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.CourseText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить ";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.Button Add;
		public System.Windows.Forms.TextBox ID;
		private System.Windows.Forms.Label CourseText;
		public System.Windows.Forms.TextBox HireDate;
		public System.Windows.Forms.TextBox Department;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox LastName;
		public System.Windows.Forms.TextBox Salary;
		public System.Windows.Forms.TextBox Commision;

		#endregion
	}
}