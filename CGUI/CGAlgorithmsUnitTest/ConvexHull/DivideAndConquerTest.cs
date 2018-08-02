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
    public class DivideAndConquerTest : ConvexHullTest
    {
        [TestMethod]
        public void DivideAndConquerNormalTestCase20Points()
        {
            convexHullTester = new DivideAndConquer();
            Case20Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase40Points()
        {
            convexHullTester = new DivideAndConquer();
            Case40Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase60Points()
        {
            convexHullTester = new DivideAndConquer();
            Case60Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase80Points()
        {
            convexHullTester = new DivideAndConquer();
            Case80Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase100Points()
        {
            convexHullTester = new DivideAndConquer();
            Case100Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase200Points()
        {
            convexHullTester = new DivideAndConquer();
            Case200Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase400Points()
        {
            convexHullTester = new DivideAndConquer();
            Case400Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase600Points()
        {
            convexHullTester = new DivideAndConquer();
            Case600Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase800Points()
        {
            convexHullTester = new DivideAndConquer();
            Case800Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase1000Points()
        {
            convexHullTester = new DivideAndConquer();
            Case1000Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase2000Points()
        {
            convexHullTester = new DivideAndConquer();
            Case2000Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase3000Points()
        {
            convexHullTester = new DivideAndConquer();
            Case3000Points();
        }
        [TestMethod]
        public void DivideAndConquerNormalTestCase4000Points()
        {
            convexHullTester = new DivideAndConquer();
            Case4000Points();
        }
		[TestMethod]
		public void DivideAndConquerNormalTestCase5000Points()
		{
			convexHullTester = new DivideAndConquer();
			Case5000Points();
		}
		[TestMethod]
		public void DivideAndConquerNormalTestCase10000Points()
		{
			convexHullTester = new DivideAndConquer();
			Case10000Points();
		}
		[TestMethod]
		public void DivideAndConquerSpecialCase10SamePoints()
		{
			convexHullTester = new DivideAndConquer();
			SpecialCase10SamePoints();
		}
		[TestMethod]
		public void DivideAndConquerSpecialCaseLine()
		{
			convexHullTester = new DivideAndConquer();
			SpecialCaseLine();
		}
		[TestMethod]
		public void DivideAndConquerSpecialCaseTriangle()
		{
			convexHullTester = new DivideAndConquer();
			SpecialCaseTriangle();
		}
		[TestMethod]
		public void DivideAndConquerSpecialCaseCircle()
		{
			convexHullTester = new DivideAndConquer();
			SpecialCaseCircle();
		}
		[TestMethod]
		public void DivideAndConquerSpecialCaseConvexPolygon()
		{
			convexHullTester = new DivideAndConquer();
			SpecialCaseConvexPolygon();
		}
    }
}
