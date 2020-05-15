using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionForms;

namespace TestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var res = FileChecker.CheckID("13");
			Assert.AreEqual(res, false);
		}

		[TestMethod]
		public void TestMethod2()
		{
			var res = FileChecker.CheckID("");
			Assert.AreEqual(res, false);
		}

		[TestMethod]
		public void TestMethod3()
		{
			var res = FileChecker.CheckDepartment("13");
			Assert.AreEqual(res, false);
		}

		[TestMethod]
		public void TestMethod4()
		{
			var res = FileChecker.CheckDepartment("ert456");
			Assert.AreEqual(res, false);
		}
		[TestMethod]
		public void TestMethod5()
		{
			var res = FileChecker.CheckHireDate("01.01.4999");
			Assert.AreEqual(res, false);
		}

		[TestMethod]
		public void TestMethod6()
		{
			var res = FileChecker.CheckHireDate("12");
			Assert.AreEqual(res, false);
		}
		[TestMethod]
		public void TestMethod7()
		{
			var res = FileChecker.CheckLastName("345345");
			Assert.AreEqual(res, false);
		}

		[TestMethod]
		public void TestMethod8()
		{
			var res = FileChecker.CheckLastName("Romomomomomomomom");
			Assert.AreEqual(res, false);
		}
		[TestMethod]
		public void TestMethod9()
		{
			var res = FileChecker.CheckSalary("-3444");
			Assert.AreEqual(res, false);
		}

		[TestMethod]
		public void TestMethod10()
		{
			var res = FileChecker.CheckSalary("-3444");
			Assert.AreEqual(res, false);
		}
		[TestMethod]
		public void TestMethod11()
		{
			var res = FileChecker.CheckCommision("343.34");
			Assert.AreEqual(res, false);
		}
	}
}