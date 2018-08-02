using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGAlgorithms.Algorithms.ConvexHull;
using CGAlgorithms;
using CGUtilities;
using System.Collections.Generic;

namespace CGAlgorithmsUnitTest
{
    /// <summary>
    /// 15 test case, each 6.67% from the total grade
    /// Grade is 0.67 for each test case that passes where total algorithm grade is 10
    /// </summary>
    [TestClass]
    public class ExtremeSegmentsTest : ConvexHullTest
    {
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase20Points()
		{
			convexHullTester = new ExtremeSegments();
			Case20Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase40Points()
		{
			convexHullTester = new ExtremeSegments();
			Case40Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase60Points()
		{
			convexHullTester = new ExtremeSegments();
			Case60Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase80Points()
		{
			convexHullTester = new ExtremeSegments();
			Case80Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase100Points()
		{
			convexHullTester = new ExtremeSegments();
			Case100Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase200Points()
		{
			convexHullTester = new ExtremeSegments();
			Case200Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase400Points()
		{
			convexHullTester = new ExtremeSegments();
			Case400Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase600Points()
		{
			convexHullTester = new ExtremeSegments();
			Case600Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase800Points()
		{
			convexHullTester = new ExtremeSegments();
			Case800Points();
		}
		[TestMethod]
		public void ExtremeSegmentsNormalTestCase1000Points()
		{
			convexHullTester = new ExtremeSegments();
			Case1000Points();
		}
		
		[TestMethod]
		public void ExtremeSegmentsSpecialCase10SamePoints()
		{
			convexHullTester = new ExtremeSegments();
			SpecialCase10SamePoints();
		}
		[TestMethod]
		public void ExtremeSegmentsSpecialCaseLine()
		{
			convexHullTester = new ExtremeSegments();
			SpecialCaseLine();
		}
		[TestMethod]
		public void ExtremeSegmentsSpecialCaseTriangle()
		{
			convexHullTester = new ExtremeSegments();
			SpecialCaseTriangle();
		}
		[TestMethod]
		public void ExtremeSegmentsSpecialCaseCircle()
		{
			convexHullTester = new ExtremeSegments();
			SpecialCaseCircle();
		}
		[TestMethod]
		public void ExtremeSegmentsSpecialCaseConvexPolygon()
		{
			convexHullTester = new ExtremeSegments();
			SpecialCaseConvexPolygon();
		}
    }
}
