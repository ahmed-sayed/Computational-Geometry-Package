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
    public class IncrementalTest : ConvexHullTest
    {
        [TestMethod]
        public void IncrementalNormalTestCase20Points()
        {
            convexHullTester = new Incremental();
            Case20Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase40Points()
        {
            convexHullTester = new Incremental();
            Case40Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase60Points()
        {
            convexHullTester = new Incremental();
            Case60Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase80Points()
        {
            convexHullTester = new Incremental();
            Case80Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase100Points()
        {
            convexHullTester = new Incremental();
            Case100Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase200Points()
        {
            convexHullTester = new Incremental();
            Case200Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase400Points()
        {
            convexHullTester = new Incremental();
            Case400Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase600Points()
        {
            convexHullTester = new Incremental();
            Case600Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase800Points()
        {
            convexHullTester = new Incremental();
            Case800Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase1000Points()
        {
            convexHullTester = new Incremental();
            Case1000Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase2000Points()
        {
            convexHullTester = new Incremental();
            Case2000Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase3000Points()
        {
            convexHullTester = new Incremental();
            Case3000Points();
        }
        [TestMethod]
        public void IncrementalNormalTestCase4000Points()
        {
            convexHullTester = new Incremental();
            Case4000Points();
        }
		[TestMethod]
		public void IncrementalNormalTestCase5000Points()
		{
			convexHullTester = new Incremental();
			Case5000Points();
		}
		[TestMethod]
		public void IncrementalNormalTestCase10000Points()
		{
			convexHullTester = new Incremental();
			Case10000Points();
		}
		[TestMethod]
		public void IncrementalSpecialCase10SamePoints()
		{
			convexHullTester = new Incremental();
			SpecialCase10SamePoints();
		}
		[TestMethod]
		public void IncrementalSpecialCaseLine()
		{
			convexHullTester = new Incremental();
			SpecialCaseLine();
		}
		[TestMethod]
		public void IncrementalSpecialCaseTriangle()
		{
			convexHullTester = new Incremental();
			SpecialCaseTriangle();
		}
		[TestMethod]
		public void IncrementalSpecialCaseCircle()
		{
			convexHullTester = new Incremental();
			SpecialCaseCircle();
		}
		[TestMethod]
		public void IncrementalSpecialCaseConvexPolygon()
		{
			convexHullTester = new Incremental();
			SpecialCaseConvexPolygon();
		}
    }
}
