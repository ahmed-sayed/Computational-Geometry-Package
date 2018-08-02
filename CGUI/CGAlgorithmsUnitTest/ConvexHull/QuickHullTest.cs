using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGAlgorithms.Algorithms.ConvexHull;
using CGAlgorithms;
using CGUtilities;
using System.Collections.Generic;

namespace CGAlgorithmsUnitTest
{
    /// <summary>
    /// 20 Test Cases, each 5% from the total grade.
    /// Grade is 0.05 for each test case where total algorithm grade is 10.
    /// </summary>
    [TestClass]
    public class QuickHullTest : ConvexHullTest
    {
        [TestMethod]
        public void QuickHullNormalTestCase20Points()
        {
            convexHullTester = new QuickHull();
            Case20Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase40Points()
        {
            convexHullTester = new QuickHull();
            Case40Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase60Points()
        {
            convexHullTester = new QuickHull();
            Case60Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase80Points()
        {
            convexHullTester = new QuickHull();
            Case80Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase100Points()
        {
            convexHullTester = new QuickHull();
            Case100Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase200Points()
        {
            convexHullTester = new QuickHull();
            Case200Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase400Points()
        {
            convexHullTester = new QuickHull();
            Case400Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase600Points()
        {
            convexHullTester = new QuickHull();
            Case600Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase800Points()
        {
            convexHullTester = new QuickHull();
            Case800Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase1000Points()
        {
            convexHullTester = new QuickHull();
            Case1000Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase2000Points()
        {
            convexHullTester = new QuickHull();
            Case2000Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase3000Points()
        {
            convexHullTester = new QuickHull();
            Case3000Points();
        }
        [TestMethod]
        public void QuickHullNormalTestCase4000Points()
        {
            convexHullTester = new QuickHull();
            Case4000Points();
        }
		[TestMethod]
		public void QuickHullNormalTestCase5000Points()
		{
			convexHullTester = new QuickHull();
			Case5000Points();
		}
		[TestMethod]
		public void QuickHullNormalTestCase10000Points()
		{
			convexHullTester = new QuickHull();
			Case10000Points();
		}
		[TestMethod]
		public void QuickHullSpecialCase10SamePoints()
		{
			convexHullTester = new QuickHull();
			SpecialCase10SamePoints();
		}
		[TestMethod]
		public void QuickHullSpecialCaseLine()
		{
			convexHullTester = new QuickHull();
			SpecialCaseLine();
		}
		[TestMethod]
		public void QuickHullSpecialCaseTriangle()
		{
			convexHullTester = new QuickHull();
			SpecialCaseTriangle();
		}
		[TestMethod]
		public void QuickHullSpecialCaseCircle()
		{
			convexHullTester = new QuickHull();
			SpecialCaseCircle();
		}
		[TestMethod]
		public void QuickHullSpecialCaseConvexPolygon()
		{
			convexHullTester = new QuickHull();
			SpecialCaseConvexPolygon();
		}
    }
}
