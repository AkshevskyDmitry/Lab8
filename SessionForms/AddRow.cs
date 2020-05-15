using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SessionForms
{
	public partial class AddRow : Form
	{
		public bool ShouldAdd;
		public AddRow()
		{
			InitializeComponent();
			ShouldAdd = false;
			ID.Leave += CheckID;
			Department.Leave += CheckDepartment;
			LastName.Leave += CheckLastName;
			HireDate.Leave += CheckHireDate;
			Salary.Leave += CheckSalary;
			Commision.Leave += CheckCommision;
		}

		public void Clear()
		{
			ID.Text = "";
			Department.Text = "";
			LastName.Text = "";
			HireDate.Text = "";
			Salary.Text = "";
			Commision.Text = "";
		}

		protected override void OnShown(EventArgs e)
		{
			ShouldAdd = false;
			base.OnShown(e);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			ShouldAdd = true;
			Close();
		}

		private void CheckID(object sender, EventArgs e)
		{
			if (FileChecker.CheckID(ID.Text))
				return;
			MessageBox.Show("Неверные данные!!!");
			ID.Text = "";
		}
		
		private void CheckDepartment(object sender, EventArgs e)
		{
			if (FileChecker.CheckDepartment(Department.Text))
				return;
			MessageBox.Show("Неверные данные!!!");
			Department.Text = "";
		}
		
		private void CheckLastName(object sender, EventArgs e)
		{
			if (FileChecker.CheckLastName(LastName.Text))
				return;
			MessageBox.Show("Неверные данные!!!");
			LastName.Text = "";
		}
		
		private void CheckHireDate(object sender, EventArgs e)
		{
			if (FileChecker.CheckHireDate(HireDate.Text))
				return;
			MessageBox.Show("Неверные данные!!!");
			HireDate.Text = "";
		}
		
		private void CheckSalary(object sender, EventArgs e)
		{
			if (FileChecker.CheckSalary(Salary.Text))
				return;
			MessageBox.Show("Неверные данные!!!");
			Salary.Text = "";
		}
		
		private void CheckCommision(object sender, EventArgs e)
		{
			if (FileChecker.CheckCommision(Commision.Text))
				return;
			MessageBox.Show("Неверные данные!!!");
			Commision.Text = "";
		}
	}
}