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
    public class JarvisMarchTest : ConvexHullTest
    {
        [TestMethod]
        public void JarvisMarchNormalTestCase20Points()
        {
            convexHullTester = new JarvisMarch();
            Case20Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase40Points()
        {
            convexHullTester = new JarvisMarch();
            Case40Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase60Points()
        {
            convexHullTester = new JarvisMarch();
            Case60Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase80Points()
        {
            convexHullTester = new JarvisMarch();
            Case80Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase100Points()
        {
            convexHullTester = new JarvisMarch();
            Case100Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase200Points()
        {
            convexHullTester = new JarvisMarch();
            Case200Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase400Points()
        {
            convexHullTester = new JarvisMarch();
            Case400Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase600Points()
        {
            convexHullTester = new JarvisMarch();
            Case600Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase800Points()
        {
            convexHullTester = new JarvisMarch();
            Case800Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase1000Points()
        {
            convexHullTester = new JarvisMarch();
            Case1000Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase2000Points()
        {
            convexHullTester = new JarvisMarch();
            Case2000Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase3000Points()
        {
            convexHullTester = new JarvisMarch();
            Case3000Points();
        }
        [TestMethod]
        public void JarvisMarchNormalTestCase4000Points()
        {
            convexHullTester = new JarvisMarch();
            Case4000Points();
        }
		[TestMethod]
		public void JarvisMarchNormalTestCase5000Points()
		{
			convexHullTester = new JarvisMarch();
			Case5000Points();
		}
		[TestMethod]
		public void JarvisMarchNormalTestCase10000Points()
		{
			convexHullTester = new JarvisMarch();
			Case10000Points();
		}
		[TestMethod]
		public void JarvisMarchSpecialCase10SamePoints()
		{
			convexHullTester = new JarvisMarch();
			SpecialCase10SamePoints();
		}
		[TestMethod]
		public void JarvisMarchSpecialCaseLine()
		{
			convexHullTester = new JarvisMarch();
			SpecialCaseLine();
		}
		[TestMethod]
		public void JarvisMarchSpecialCaseTriangle()
		{
			convexHullTester = new JarvisMarch();
			SpecialCaseTriangle();
		}
		[TestMethod]
		public void JarvisMarchSpecialCaseCircle()
		{
			convexHullTester = new JarvisMarch();
			SpecialCaseCircle();
		}
		[TestMethod]
		public void JarvisMarchSpecialCaseConvexPolygon()
		{
			convexHullTester = new JarvisMarch();
			SpecialCaseConvexPolygon();
		}
    }
}
