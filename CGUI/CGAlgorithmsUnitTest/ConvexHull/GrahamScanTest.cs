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
    public class GrahamScanTest : ConvexHullTest
    {
        [TestMethod]
        public void GrahamScanNormalTestCase20Points()
        {
            convexHullTester = new GrahamScan();
            Case20Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase40Points()
        {
            convexHullTester = new GrahamScan();
            Case40Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase60Points()
        {
            convexHullTester = new GrahamScan();
            Case60Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase80Points()
        {
            convexHullTester = new GrahamScan();
            Case80Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase100Points()
        {
            convexHullTester = new GrahamScan();
            Case100Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase200Points()
        {
            convexHullTester = new GrahamScan();
            Case200Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase400Points()
        {
            convexHullTester = new GrahamScan();
            Case400Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase600Points()
        {
            convexHullTester = new GrahamScan();
            Case600Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase800Points()
        {
            convexHullTester = new GrahamScan();
            Case800Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase1000Points()
        {
            convexHullTester = new GrahamScan();
            Case1000Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase2000Points()
        {
            convexHullTester = new GrahamScan();
            Case2000Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase3000Points()
        {
            convexHullTester = new GrahamScan();
            Case3000Points();
        }
        [TestMethod]
        public void GrahamScanNormalTestCase4000Points()
        {
            convexHullTester = new GrahamScan();
            Case4000Points();
        }
		[TestMethod]
		public void GrahamScanNormalTestCase5000Points()
		{
			convexHullTester = new GrahamScan();
			Case5000Points();
		}
		[TestMethod]
		public void GrahamScanNormalTestCase10000Points()
		{
			convexHullTester = new GrahamScan();
			Case10000Points();
		}
		[TestMethod]
		public void GrahamScanSpecialCase10SamePoints()
		{
			convexHullTester = new GrahamScan();
			SpecialCase10SamePoints();
		}
		[TestMethod]
		public void GrahamScanSpecialCaseLine()
		{
			convexHullTester = new GrahamScan();
			SpecialCaseLine();
		}
		[TestMethod]
		public void GrahamScanSpecialCaseTriangle()
		{
			convexHullTester = new GrahamScan();
			SpecialCaseTriangle();
		}
		[TestMethod]
		public void GrahamScanSpecialCaseCircle()
		{
			convexHullTester = new GrahamScan();
			SpecialCaseCircle();
		}
		[TestMethod]
		public void GrahamScanSpecialCaseConvexPolygon()
		{
			convexHullTester = new GrahamScan();
			SpecialCaseConvexPolygon();
		}
    }
}
