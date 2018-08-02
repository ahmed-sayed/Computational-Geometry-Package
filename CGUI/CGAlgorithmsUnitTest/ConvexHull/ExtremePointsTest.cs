using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGAlgorithms.Algorithms.ConvexHull;
using CGAlgorithms;
using CGUtilities;
using System.Collections.Generic;

namespace CGAlgorithmsUnitTest
{
    /// <summary>
    /// 10 test cases, each 10% of the total grade.
    /// Grade is 0.1 for each test case where total algorithm grade is 10.
    /// </summary>
    [TestClass]
    public class ExtremePointsTest : ConvexHullTest
    {
		[TestMethod]
		public void ExtremePointsNormalTestCase20Points()
		{
			convexHullTester = new ExtremePoints();
			Case20Points();
		}
		[TestMethod]
		public void ExtremePointsNormalTestCase40Points()
		{
			convexHullTester = new ExtremePoints();
			Case40Points();
		}
		[TestMethod]
		public void ExtremePointsNormalTestCase60Points()
		{
			convexHullTester = new ExtremePoints();
			Case60Points();
		}
		[TestMethod]
		public void ExtremePointsNormalTestCase80Points()
		{
			convexHullTester = new ExtremePoints();
			Case80Points();
		}
		[TestMethod]
		public void ExtremePointsNormalTestCase100Points()
		{
			convexHullTester = new ExtremePoints();
			Case100Points();
		}
		[TestMethod]
		public void ExtremePointsSpecialCase10SamePoints()
		{
			convexHullTester = new ExtremePoints();
			SpecialCase10SamePoints();
		}
		[TestMethod]
		public void ExtremePointsSpecialCaseLine()
		{
			convexHullTester = new ExtremePoints();
			SpecialCaseLine();
		}
		[TestMethod]
		public void ExtremePointsSpecialCaseTriangle()
		{
			convexHullTester = new ExtremePoints();
			SpecialCaseTriangle();
		}
		[TestMethod]
		public void ExtremePointsSpecialCaseCircle()
		{
			convexHullTester = new ExtremePoints();
			SpecialCaseCircle();
		}
		[TestMethod]
		public void ExtremePointsSpecialCaseConvexPolygon()
		{
			convexHullTester = new ExtremePoints();
			SpecialCaseConvexPolygon();
		}
    }
}
