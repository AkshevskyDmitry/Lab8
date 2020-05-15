using System;
using System.Text.RegularExpressions;

namespace SessionForms
{
	public static class FileChecker
	{
		public static bool CheckID(string text)
		{
			int id;
			if(Int32.TryParse(text, out id))
			{
				if ((id >= 1000) && (id <= 9999))
					return true;
			}
			return false;
			
		}
		
		public static bool CheckDepartment(string text)
		{
			int dep;
			if (Int32.TryParse(text, out dep))
			{
				if ((dep >= 1) && (dep <= 10))
					return true;
			}
			return false;
		}
		
		public static bool CheckSalary(string text)
		{
			int sal;
			if (Int32.TryParse(text, out sal))
			{
				if ((sal >= 50000) && (sal <= 99999))
					return true;
			}
			return false;
		}
		
		public static bool CheckLastName(string text)
		{
			return (Regex.IsMatch(text, "^[a-zA-Z]+$") && (text.Length <= 10));
		}
		
		public static bool CheckHireDate(string text)
		{
			DateTime hd;
			DateTime foundation = DateTime.Parse("01.01.2010");
			DateTime today = DateTime.Today;
			if (DateTime.TryParse(text, out hd))
			{
				if ((hd >= foundation) && (hd <= today))
					return true;
			}
			return false;
		}
		
		public static bool CheckCommision(string text)
		{
			float pct;
			if (Single.TryParse(text, out pct))
			{
				if ((pct >= 0.1) && (pct <= 0.8))
					return true;
			}
			return false;
		}
	}
}