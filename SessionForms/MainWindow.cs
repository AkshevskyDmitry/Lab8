using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SessionForms
{
	public partial class MainWindow : Form
	{
		private bool IsFileOpened => FilePath.Text == "Файл не открыт";
		private List<string> _dropDown = new List<string>
		{
			"All",
			"ID",
			"Department",
			"LastName",
			"HireDate",
			"Salary",
			"Commision"
		};
		
		private IEnumerable<XElement> _data;
		private IEnumerable<XElement> _originalData;
		
		private Search _search;
		private AddRow _addRow;

		public MainWindow()
		{
			InitializeComponent();
			
			_search = new Search();
			_addRow = new AddRow();
			
		}

		private void UpdateData()
		{
			Data.Text =  $"  ID  |  Department  |  Last name  |  Hire date  |  Salary  |  Commision  \n";
			Data.Text += "-".PadLeft(Data.Text.Length, '-') + "\n";
			
			foreach (var employees in _data)
			{
				if (FileChecker.CheckID(employees.Element("ID").Value) &&
					FileChecker.CheckDepartment(employees.Element("Department").Value) &&
					FileChecker.CheckLastName(employees.Element("LastName").Value) &&
					FileChecker.CheckHireDate(employees.Element("HireDate").Value) &&
					FileChecker.CheckSalary(employees.Element("Salary").Value) &&
					FileChecker.CheckCommision(employees.Element("Commision").Value))
				{
					Data.Text += $"{employees.Element("ID").Value}|" +
					$"{employees.Element("Department").Value.PadLeft(11)+ " ".PadLeft(10)}|"+
					//$"{ekzam.Element("Department").Value.PadRight(14)}  |" +
					$"{employees.Element("LastName").Value.PadLeft(13)+"  "}|" +
				    $"{employees.Element("HireDate").Value.PadLeft(10)+"  "}|" +
					$"{employees.Element("Salary").Value.PadLeft(7)+"  "}|" +
					$"{"   " + employees.Element("Commision").Value.PadRight(13)}  \n";
				}
				else
				{
					MessageBox.Show("Неверные данные!!!");
				}
			}
		}

		//Window control buttons
		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void MaximizeButton_Click(object sender, EventArgs e)
		{
			switch (this.WindowState)
			{
				case FormWindowState.Maximized:
					this.WindowState = FormWindowState.Normal;
					break;
				case FormWindowState.Normal:
					this.WindowState = FormWindowState.Maximized;
					break;
			}
		}
		
		private void OpenButton_Click(object sender, EventArgs e)
		{
			var filePath = ChooseFile();
			if (filePath == string.Empty) 
				return;
			
			FilePath.Text = filePath;
			
			_data = XElement.Load(filePath).Descendants("Person");
			_originalData = _data;
			UpdateData();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var element = new XElement("Employees", _originalData);
			OnDataSaved();
			element.Save(FilePath.Text);
		}

		private void FilterButton_Click(object sender, EventArgs e)
		{
			_search.Text.Text = "Выбрать:";
			_search.ShowDialog();
			var searchText = _search.Input.Text;
			IEnumerable<XElement> filteredData;
			if (_dropDown[_search.DropDown.SelectedIndex] == "All")
				filteredData = 
					_originalData.Where(x => x.Value.Contains(searchText));
			else 
				filteredData = 
					_originalData.Where(x => x.Element(_dropDown[_search.DropDown.SelectedIndex]).Value.Contains(searchText));
			
			_data = filteredData;
			UpdateData();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (IsFileOpened)
			{
				MessageBox.Show("Пожалуйста, откройте файл!");
				return;
			}

			OnDataChanged();
			_addRow.Clear();
			_addRow.ShowDialog();
			if (_addRow.ShouldAdd)
			{
				_originalData = _originalData.Concat(
					new [] {
						new XElement("Person", 
							new XElement("ID", _addRow.ID.Text),
							new XElement("Department", _addRow.Department.Text),
							new XElement("LastName", _addRow.LastName.Text),
							new XElement("HireDate", _addRow.HireDate.Text),
							new XElement("Salary", _addRow.Salary.Text),
							new XElement("Commision", _addRow.Commision.Text)
					)
				});
			}

			_data = _originalData;
			UpdateData();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			_search.Text.Text = "Удалить: ";
			_search.ShowDialog();
			var searchText = _search.Input.Text;
			IEnumerable<XElement> filteredData;
			if (_dropDown[_search.DropDown.SelectedIndex] == "All")
				filteredData = 
					_originalData.Where(x => !x.Value.Contains(searchText));
			else 
				filteredData = 
					_originalData.Where(x => !x.Element(_dropDown[_search.DropDown.SelectedIndex]).Value.Contains(searchText));

			_originalData = filteredData;
			_data = _originalData;
			UpdateData();
		}

		private string ChooseFile()
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "XML files (*.xml)|*.xml|All files|*.*", 
				FilterIndex = 1,
				RestoreDirectory = true
			};

			return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : string.Empty;
		}

		private void OnDataChanged()
		{
			FilePath.Font = new Font(FilePath.Font, FontStyle.Italic);
			if (!FilePath.Text.EndsWith("*"))
				FilePath.Text += "*";
		}

		private void OnDataSaved()
		{
			FilePath.Font = new Font(FilePath.Font, FontStyle.Regular);
			if (FilePath.Text.EndsWith("*"))
				FilePath.Text = FilePath.Text.Substring(0, FilePath.Text.Length - 1);
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			_data = _originalData;
			UpdateData();
		}
	}
}