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
			var res = FileChecker.CheckCourse("31");
			Assert.AreEqual(res, true);
		}
		[TestMethod]
		public void TestMethod2()
		{
			var res = FileChecker.CheckMark("6");
			Assert.AreEqual(res, false);
		}
		[TestMethod]
		public void TestMethod3()
		{
			var res = FileChecker.CheckLesson("Hello");
			Assert.AreEqual(res, true);
		}
		[TestMethod]
		public void TestMethod4()
		{
			var res = FileChecker.CheckLastName("");
			Assert.AreEqual(res, false);
		}
		[TestMethod]
		public void TestMethod5()
		{
			var res = FileChecker.CheckDocument("_34./cx");
			Assert.AreEqual(res, false);
		}
		[TestMethod]
		public void TestMethod6()
		{
			var res = FileChecker.CheckGroup("343.34");
			Assert.AreEqual(res, false);
		}
	}
}