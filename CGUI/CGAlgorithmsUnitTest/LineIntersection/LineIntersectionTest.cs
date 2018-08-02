using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGAlgorithms;
using CGUtilities;
using System.Collections.Generic;
using System.Linq;

namespace CGAlgorithmsUnitTest.LineIntersection
{
    /// <summary>
    /// Base Class for All Line Intersection Algorithms
    /// </summary>
    [TestClass]
    public class LineIntersectionTest
    {
        protected Algorithm lineIntersectionTester;
        protected List<Point> inputPoints;
        protected List<Line> inputLines;
        protected List<Polygon> inputPolygons;
        protected List<Point> outputPoints;
        protected List<Line> outputLines;
        protected List<Polygon> outputPolygons;
        protected List<Point> desiredIntersections;

        #region Cases
        [TestMethod]
        public void CaseRandom4LinesIntersectingWithRandom4Lines()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-547, -58), new Point(604, 317)));
            inputLines.Add(new Line(new Point(-626, -218), new Point(527, 225)));
            inputLines.Add(new Line(new Point(-349, -193), new Point(429, 108)));
            inputLines.Add(new Line(new Point(-247, 112), new Point(103, 221)));
            inputLines.Add(new Line(new Point(-344, 325), new Point(-18, -192)));
            inputLines.Add(new Line(new Point(-206, 308), new Point(198, -172)));
            inputLines.Add(new Line(new Point(9, 218), new Point(387, -182)));
            inputLines.Add(new Line(new Point(-148, 157), new Point(2, -268)));
            #endregion
            #region output
            desiredIntersections.Add(new Point(-178.2507, 62.13988));
            desiredIntersections.Add(new Point(-37.62879, 107.955));
            desiredIntersections.Add(new Point(77.53529, 145.4759));
            desiredIntersections.Add(new Point(-121.0925, 80.7622));
            desiredIntersections.Add(new Point(-123.3765, -24.88447));
            desiredIntersections.Add(new Point(25.90345, 32.47115));
            desiredIntersections.Add(new Point(142.1262, 77.12569));
            desiredIntersections.Add(new Point(-88.53075, -11.4962));
            desiredIntersections.Add(new Point(-82.40681, -89.85791));
            desiredIntersections.Add(new Point(76.96664, -28.19799));
            desiredIntersections.Add(new Point(197.565, 18.46026));
            desiredIntersections.Add(new Point(-63.46075, -82.52787));
            desiredIntersections.Add(new Point(-215.8146, 121.712));
            desiredIntersections.Add(new Point(-83.80885, 162.8224));
            desiredIntersections.Add(new Point(28.1835, 197.7));
            desiredIntersections.Add(new Point(-143.4946, 144.2346));
            desiredIntersections.Add(new Point(-33.49836, -167.4213));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": Case 1: (24 Lines Intersecting with 4 other Lines)");
        }

        [TestMethod]
        public void CaseRandom5GroupsOfLineIntersections()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-477, 27), new Point(452, 156)));
            inputLines.Add(new Line(new Point(-182, -35), new Point(573, 102)));
            inputLines.Add(new Line(new Point(-328, 162), new Point(490, -202)));
            inputLines.Add(new Line(new Point(-15, -244), new Point(292, -227)));
            inputLines.Add(new Line(new Point(95, -155), new Point(312, -311)));
            inputLines.Add(new Line(new Point(159, 274), new Point(450, 226)));
            inputLines.Add(new Line(new Point(370, 298), new Point(156, 177)));
            inputLines.Add(new Line(new Point(405, -21), new Point(628, -106)));
            inputLines.Add(new Line(new Point(569, -24), new Point(425, -104)));
            inputLines.Add(new Line(new Point(-523, -154), new Point(-300, -243)));
            inputLines.Add(new Line(new Point(-414, -148), new Point(-553, -295)));
            inputLines.Add(new Line(new Point(-608, 258), new Point(-348, 131)));
            inputLines.Add(new Line(new Point(-422, 265), new Point(-601, 103)));
            #endregion
            #region output
            desiredIntersections.Add(new Point(-132.2123, 74.87687));
            desiredIntersections.Add(new Point(28.76366, 3.244532));
            desiredIntersections.Add(new Point(202.0801, -231.9793));
            desiredIntersections.Add(new Point(289.4871, 252.4763));
            desiredIntersections.Add(new Point(505.4686, -59.29522));
            desiredIntersections.Add(new Point(-447.9835, -183.9393));
            desiredIntersections.Add(new Point(-492.2222, 201.447));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": Case 2: (Random 5 Groups Of Line Intersections)");
        }

        [TestMethod]
        public void CaseRandom4LinesIntersectingTogether()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-546, 315), new Point(499, -151)));
            inputLines.Add(new Line(new Point(-407, 97), new Point(296, -172)));
            inputLines.Add(new Line(new Point(-596, -192), new Point(616, 315)));
            inputLines.Add(new Line(new Point(-111, -110), new Point(-352, 249)));
            #endregion
            #region output
            desiredIntersections.Add(new Point(16.43476, 64.19177));
            desiredIntersections.Add(new Point(-332.3477, 219.7254));
            desiredIntersections.Add(new Point(-144.8927, -3.294241));
            desiredIntersections.Add(new Point(-195.6779, 16.1385));
            desiredIntersections.Add(new Point(-174.3581, -15.62009));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": Case 3: (Random 4 Lines Intersecting)");
        }

        [TestMethod]
        public void CaseEasyCase1LineIntersecting5Lines()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(493, -6), new Point(-172, 238)));
            inputLines.Add(new Line(new Point(357, -50), new Point(-274, 227)));
            inputLines.Add(new Line(new Point(126, -24), new Point(-444, 245)));
            inputLines.Add(new Line(new Point(-528, 259), new Point(23, -33)));
            inputLines.Add(new Line(new Point(-571, 253), new Point(-161, 3)));
            inputLines.Add(new Line(new Point(583, 242), new Point(-455, 21)));
            #endregion
            #region output
            desiredIntersections.Add(new Point(98.33356, 138.8099));
            desiredIntersections.Add(new Point(-17.11301, 114.2303));
            desiredIntersections.Add(new Point(-120.3357, 92.25318));
            desiredIntersections.Add(new Point(-186.692, 78.12532));
            desiredIntersections.Add(new Point(-258.9686, 62.73693));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": Case 4: (Easy Case: Line Intersecting 5 Lines)");
        }

        [TestMethod]
        public void CaseEasyCase2LinesIntersecting5Lines()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-558, 0), new Point(248, 283)));
            inputLines.Add(new Line(new Point(-575, -131), new Point(430, 257)));
            inputLines.Add(new Line(new Point(492, 265), new Point(-583, -168)));
            inputLines.Add(new Line(new Point(-244, -81), new Point(77, 53)));
            inputLines.Add(new Line(new Point(68, 33), new Point(-111, -147)));
            inputLines.Add(new Line(new Point(-331, 177), new Point(25, -195)));
            inputLines.Add(new Line(new Point(136, -122), new Point(-137, 191)));
            #endregion
            #region output
            desiredIntersections.Add(new Point(-261.3064, 104.1741));
            desiredIntersections.Add(new Point(-108.168, 157.9435));
            desiredIntersections.Add(new Point(-181.5961, 20.88131));
            desiredIntersections.Add(new Point(-37.23326, 76.61542));
            desiredIntersections.Add(new Point(-162.8084, 1.249257));
            desiredIntersections.Add(new Point(-21.2354, 58.27356));
            desiredIntersections.Add(new Point(-129.7419, -33.30345));
            desiredIntersections.Add(new Point(8.356988, 24.34529));
            desiredIntersections.Add(new Point(-65.10341, -100.847));
            desiredIntersections.Add(new Point(32.20409, -2.995891));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": Case 5: (Easy Case: 2 Lines Intersecting 5 Lines)");
        }

        [TestMethod]
        public void SpecialCase21HorizontalLinesPerpendicularOn1VerticalLines()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(0, -100), new Point(0, 100)));
            inputLines.Add(new Line(new Point(-100, -100), new Point(100, -100)));
            inputLines.Add(new Line(new Point(-100, -90), new Point(100, -90)));
            inputLines.Add(new Line(new Point(-100, -80), new Point(100, -80)));
            inputLines.Add(new Line(new Point(-100, -70), new Point(100, -70)));
            inputLines.Add(new Line(new Point(-100, -60), new Point(100, -60)));
            inputLines.Add(new Line(new Point(-100, -50), new Point(100, -50)));
            inputLines.Add(new Line(new Point(100, -40), new Point(-100, -40)));
            inputLines.Add(new Line(new Point(100, -30), new Point(-100, -30)));
            inputLines.Add(new Line(new Point(100, -20), new Point(-100, -20)));
            inputLines.Add(new Line(new Point(100, -10), new Point(-100, -10)));
            inputLines.Add(new Line(new Point(100, 0), new Point(-100, 0)));

            inputLines.Add(new Line(new Point(-100, 100), new Point(100, 100)));
            inputLines.Add(new Line(new Point(-100, 90), new Point(100, 90)));
            inputLines.Add(new Line(new Point(-100, 80), new Point(100, 80)));
            inputLines.Add(new Line(new Point(-100, 70), new Point(100, 70)));
            inputLines.Add(new Line(new Point(-100, 60), new Point(100, 60)));
            inputLines.Add(new Line(new Point(-100, 50), new Point(100, 50)));
            inputLines.Add(new Line(new Point(100, 40), new Point(-100, 40)));
            inputLines.Add(new Line(new Point(100, 30), new Point(-100, 30)));
            inputLines.Add(new Line(new Point(100, 20), new Point(-100, 20)));
            inputLines.Add(new Line(new Point(100, 10), new Point(-100, 10)));

            #endregion 
            #region output
            desiredIntersections.Add(new Point(0, 100));
            desiredIntersections.Add(new Point(0, 90));
            desiredIntersections.Add(new Point(0, 80));
            desiredIntersections.Add(new Point(0, 70));
            desiredIntersections.Add(new Point(0, 60));
            desiredIntersections.Add(new Point(0, 50));
            desiredIntersections.Add(new Point(0, 40));
            desiredIntersections.Add(new Point(0, 30));
            desiredIntersections.Add(new Point(0, 20));
            desiredIntersections.Add(new Point(0, 10));
            desiredIntersections.Add(new Point(0, 0));
            desiredIntersections.Add(new Point(0, -100));
            desiredIntersections.Add(new Point(0, -90));
            desiredIntersections.Add(new Point(0, -80));
            desiredIntersections.Add(new Point(0, -70));
            desiredIntersections.Add(new Point(0, -60));
            desiredIntersections.Add(new Point(0, -50));
            desiredIntersections.Add(new Point(0, -40));
            desiredIntersections.Add(new Point(0, -30));
            desiredIntersections.Add(new Point(0, -20));
            desiredIntersections.Add(new Point(0, -10));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": SpecialCase 1: (21 horizontal lines Perpendicular on a vertical line)");
        }

        [TestMethod]
        public void SpecialCase21HorizontalLinePerpendicularOn21VerticalLine()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-100, -100), new Point(-100, 100)));
            inputLines.Add(new Line(new Point(-90, -100), new Point(-90, 100)));
            inputLines.Add(new Line(new Point(-80, -100), new Point(-80, 100)));
            inputLines.Add(new Line(new Point(-70, -100), new Point(-70, 100)));
            inputLines.Add(new Line(new Point(-60, -100), new Point(-60, 100)));
            inputLines.Add(new Line(new Point(-50, -100), new Point(-50, 100)));
            inputLines.Add(new Line(new Point(-40, -100), new Point(-40, 100)));
            inputLines.Add(new Line(new Point(-30, -100), new Point(-30, 100)));
            inputLines.Add(new Line(new Point(-20, -100), new Point(-20, 100)));
            inputLines.Add(new Line(new Point(-10, -100), new Point(-10, 100)));
            inputLines.Add(new Line(new Point(0, 100), new Point(0, -100)));
            inputLines.Add(new Line(new Point(100, 100), new Point(100, -100)));
            inputLines.Add(new Line(new Point(90, 100), new Point(90, -100)));
            inputLines.Add(new Line(new Point(80, 100), new Point(80, -100)));
            inputLines.Add(new Line(new Point(70, 100), new Point(70, -100)));
            inputLines.Add(new Line(new Point(60, 100), new Point(60, -100)));
            inputLines.Add(new Line(new Point(50, 100), new Point(50, -100)));
            inputLines.Add(new Line(new Point(40, 100), new Point(40, -100)));
            inputLines.Add(new Line(new Point(30, 100), new Point(30, -100)));
            inputLines.Add(new Line(new Point(20, 100), new Point(20, -100)));
            inputLines.Add(new Line(new Point(10, 100), new Point(10, -100)));

            inputLines.Add(new Line(new Point(-100, -100), new Point(100, -100)));
            inputLines.Add(new Line(new Point(-100, -90), new Point(100, -90)));
            inputLines.Add(new Line(new Point(-100, -80), new Point(100, -80)));
            inputLines.Add(new Line(new Point(-100, -70), new Point(100, -70)));
            inputLines.Add(new Line(new Point(-100, -60), new Point(100, -60)));
            inputLines.Add(new Line(new Point(-100, -50), new Point(100, -50)));
            inputLines.Add(new Line(new Point(100, -40), new Point(-100, -40)));
            inputLines.Add(new Line(new Point(100, -30), new Point(-100, -30)));
            inputLines.Add(new Line(new Point(100, -20), new Point(-100, -20)));
            inputLines.Add(new Line(new Point(100, -10), new Point(-100, -10)));
            inputLines.Add(new Line(new Point(100, 0), new Point(-100, 0)));
            inputLines.Add(new Line(new Point(-100, 100), new Point(100, 100)));
            inputLines.Add(new Line(new Point(-100, 90), new Point(100, 90)));
            inputLines.Add(new Line(new Point(-100, 80), new Point(100, 80)));
            inputLines.Add(new Line(new Point(-100, 70), new Point(100, 70)));
            inputLines.Add(new Line(new Point(-100, 60), new Point(100, 60)));
            inputLines.Add(new Line(new Point(-100, 50), new Point(100, 50)));
            inputLines.Add(new Line(new Point(100, 40), new Point(-100, 40)));
            inputLines.Add(new Line(new Point(100, 30), new Point(-100, 30)));
            inputLines.Add(new Line(new Point(100, 20), new Point(-100, 20)));
            inputLines.Add(new Line(new Point(100, 10), new Point(-100, 10)));

            #endregion
            #region output
            desiredIntersections.Add(new Point(-100, 100));
            desiredIntersections.Add(new Point(-100, 90));
            desiredIntersections.Add(new Point(-100, 80));
            desiredIntersections.Add(new Point(-100, 70));
            desiredIntersections.Add(new Point(-100, 60));
            desiredIntersections.Add(new Point(-100, 50));
            desiredIntersections.Add(new Point(-100, 40));
            desiredIntersections.Add(new Point(-100, 30));
            desiredIntersections.Add(new Point(-100, 20));
            desiredIntersections.Add(new Point(-100, 10));
            desiredIntersections.Add(new Point(-100, 0));
            desiredIntersections.Add(new Point(-100, -100));
            desiredIntersections.Add(new Point(-100, -90));
            desiredIntersections.Add(new Point(-100, -80));
            desiredIntersections.Add(new Point(-100, -70));
            desiredIntersections.Add(new Point(-100, -60));
            desiredIntersections.Add(new Point(-100, -50));
            desiredIntersections.Add(new Point(-100, -40));
            desiredIntersections.Add(new Point(-100, -30));
            desiredIntersections.Add(new Point(-100, -20));
            desiredIntersections.Add(new Point(-100, -10));

            desiredIntersections.Add(new Point(-90, 100));
            desiredIntersections.Add(new Point(-90, 90));
            desiredIntersections.Add(new Point(-90, 80));
            desiredIntersections.Add(new Point(-90, 70));
            desiredIntersections.Add(new Point(-90, 60));
            desiredIntersections.Add(new Point(-90, 50));
            desiredIntersections.Add(new Point(-90, 40));
            desiredIntersections.Add(new Point(-90, 30));
            desiredIntersections.Add(new Point(-90, 20));
            desiredIntersections.Add(new Point(-90, 10));
            desiredIntersections.Add(new Point(-90, 0));
            desiredIntersections.Add(new Point(-90, -100));
            desiredIntersections.Add(new Point(-90, -90));
            desiredIntersections.Add(new Point(-90, -80));
            desiredIntersections.Add(new Point(-90, -70));
            desiredIntersections.Add(new Point(-90, -60));
            desiredIntersections.Add(new Point(-90, -50));
            desiredIntersections.Add(new Point(-90, -40));
            desiredIntersections.Add(new Point(-90, -30));
            desiredIntersections.Add(new Point(-90, -20));
            desiredIntersections.Add(new Point(-90, -10));


            desiredIntersections.Add(new Point(-80, 100));
            desiredIntersections.Add(new Point(-80, 90));
            desiredIntersections.Add(new Point(-80, 80));
            desiredIntersections.Add(new Point(-80, 70));
            desiredIntersections.Add(new Point(-80, 60));
            desiredIntersections.Add(new Point(-80, 50));
            desiredIntersections.Add(new Point(-80, 40));
            desiredIntersections.Add(new Point(-80, 30));
            desiredIntersections.Add(new Point(-80, 20));
            desiredIntersections.Add(new Point(-80, 10));
            desiredIntersections.Add(new Point(-80, 0));
            desiredIntersections.Add(new Point(-80, -100));
            desiredIntersections.Add(new Point(-80, -90));
            desiredIntersections.Add(new Point(-80, -80));
            desiredIntersections.Add(new Point(-80, -70));
            desiredIntersections.Add(new Point(-80, -60));
            desiredIntersections.Add(new Point(-80, -50));
            desiredIntersections.Add(new Point(-80, -40));
            desiredIntersections.Add(new Point(-80, -30));
            desiredIntersections.Add(new Point(-80, -20));
            desiredIntersections.Add(new Point(-80, -10));

            desiredIntersections.Add(new Point(-70, 100));
            desiredIntersections.Add(new Point(-70, 90));
            desiredIntersections.Add(new Point(-70, 80));
            desiredIntersections.Add(new Point(-70, 70));
            desiredIntersections.Add(new Point(-70, 60));
            desiredIntersections.Add(new Point(-70, 50));
            desiredIntersections.Add(new Point(-70, 40));
            desiredIntersections.Add(new Point(-70, 30));
            desiredIntersections.Add(new Point(-70, 20));
            desiredIntersections.Add(new Point(-70, 10));
            desiredIntersections.Add(new Point(-70, 0));
            desiredIntersections.Add(new Point(-70, -100));
            desiredIntersections.Add(new Point(-70, -90));
            desiredIntersections.Add(new Point(-70, -80));
            desiredIntersections.Add(new Point(-70, -70));
            desiredIntersections.Add(new Point(-70, -60));
            desiredIntersections.Add(new Point(-70, -50));
            desiredIntersections.Add(new Point(-70, -40));
            desiredIntersections.Add(new Point(-70, -30));
            desiredIntersections.Add(new Point(-70, -20));
            desiredIntersections.Add(new Point(-70, -10));

            desiredIntersections.Add(new Point(-60, 100));
            desiredIntersections.Add(new Point(-60, 90));
            desiredIntersections.Add(new Point(-60, 80));
            desiredIntersections.Add(new Point(-60, 70));
            desiredIntersections.Add(new Point(-60, 60));
            desiredIntersections.Add(new Point(-60, 50));
            desiredIntersections.Add(new Point(-60, 40));
            desiredIntersections.Add(new Point(-60, 30));
            desiredIntersections.Add(new Point(-60, 20));
            desiredIntersections.Add(new Point(-60, 10));
            desiredIntersections.Add(new Point(-60, 0));
            desiredIntersections.Add(new Point(-60, -100));
            desiredIntersections.Add(new Point(-60, -90));
            desiredIntersections.Add(new Point(-60, -80));
            desiredIntersections.Add(new Point(-60, -70));
            desiredIntersections.Add(new Point(-60, -60));
            desiredIntersections.Add(new Point(-60, -50));
            desiredIntersections.Add(new Point(-60, -40));
            desiredIntersections.Add(new Point(-60, -30));
            desiredIntersections.Add(new Point(-60, -20));
            desiredIntersections.Add(new Point(-60, -10));

            desiredIntersections.Add(new Point(-50, 100));
            desiredIntersections.Add(new Point(-50, 90));
            desiredIntersections.Add(new Point(-50, 80));
            desiredIntersections.Add(new Point(-50, 70));
            desiredIntersections.Add(new Point(-50, 60));
            desiredIntersections.Add(new Point(-50, 50));
            desiredIntersections.Add(new Point(-50, 40));
            desiredIntersections.Add(new Point(-50, 30));
            desiredIntersections.Add(new Point(-50, 20));
            desiredIntersections.Add(new Point(-50, 10));
            desiredIntersections.Add(new Point(-50, 0));
            desiredIntersections.Add(new Point(-50, -100));
            desiredIntersections.Add(new Point(-50, -90));
            desiredIntersections.Add(new Point(-50, -80));
            desiredIntersections.Add(new Point(-50, -70));
            desiredIntersections.Add(new Point(-50, -60));
            desiredIntersections.Add(new Point(-50, -50));
            desiredIntersections.Add(new Point(-50, -40));
            desiredIntersections.Add(new Point(-50, -30));
            desiredIntersections.Add(new Point(-50, -20));
            desiredIntersections.Add(new Point(-50, -10));

            desiredIntersections.Add(new Point(-40, 100));
            desiredIntersections.Add(new Point(-40, 90));
            desiredIntersections.Add(new Point(-40, 80));
            desiredIntersections.Add(new Point(-40, 70));
            desiredIntersections.Add(new Point(-40, 60));
            desiredIntersections.Add(new Point(-40, 50));
            desiredIntersections.Add(new Point(-40, 40));
            desiredIntersections.Add(new Point(-40, 30));
            desiredIntersections.Add(new Point(-40, 20));
            desiredIntersections.Add(new Point(-40, 10));
            desiredIntersections.Add(new Point(-40, 0));
            desiredIntersections.Add(new Point(-40, -100));
            desiredIntersections.Add(new Point(-40, -90));
            desiredIntersections.Add(new Point(-40, -80));
            desiredIntersections.Add(new Point(-40, -70));
            desiredIntersections.Add(new Point(-40, -60));
            desiredIntersections.Add(new Point(-40, -50));
            desiredIntersections.Add(new Point(-40, -40));
            desiredIntersections.Add(new Point(-40, -30));
            desiredIntersections.Add(new Point(-40, -20));
            desiredIntersections.Add(new Point(-40, -10));

            desiredIntersections.Add(new Point(-30, 100));
            desiredIntersections.Add(new Point(-30, 90));
            desiredIntersections.Add(new Point(-30, 80));
            desiredIntersections.Add(new Point(-30, 70));
            desiredIntersections.Add(new Point(-30, 60));
            desiredIntersections.Add(new Point(-30, 50));
            desiredIntersections.Add(new Point(-30, 40));
            desiredIntersections.Add(new Point(-30, 30));
            desiredIntersections.Add(new Point(-30, 20));
            desiredIntersections.Add(new Point(-30, 10));
            desiredIntersections.Add(new Point(-30, 0));
            desiredIntersections.Add(new Point(-30, -100));
            desiredIntersections.Add(new Point(-30, -90));
            desiredIntersections.Add(new Point(-30, -80));
            desiredIntersections.Add(new Point(-30, -70));
            desiredIntersections.Add(new Point(-30, -60));
            desiredIntersections.Add(new Point(-30, -50));
            desiredIntersections.Add(new Point(-30, -40));
            desiredIntersections.Add(new Point(-30, -30));
            desiredIntersections.Add(new Point(-30, -20));
            desiredIntersections.Add(new Point(-30, -10));

            desiredIntersections.Add(new Point(-20, 100));
            desiredIntersections.Add(new Point(-20, 90));
            desiredIntersections.Add(new Point(-20, 80));
            desiredIntersections.Add(new Point(-20, 70));
            desiredIntersections.Add(new Point(-20, 60));
            desiredIntersections.Add(new Point(-20, 50));
            desiredIntersections.Add(new Point(-20, 40));
            desiredIntersections.Add(new Point(-20, 30));
            desiredIntersections.Add(new Point(-20, 20));
            desiredIntersections.Add(new Point(-20, 10));
            desiredIntersections.Add(new Point(-20, 0));
            desiredIntersections.Add(new Point(-20, -100));
            desiredIntersections.Add(new Point(-20, -90));
            desiredIntersections.Add(new Point(-20, -80));
            desiredIntersections.Add(new Point(-20, -70));
            desiredIntersections.Add(new Point(-20, -60));
            desiredIntersections.Add(new Point(-20, -50));
            desiredIntersections.Add(new Point(-20, -40));
            desiredIntersections.Add(new Point(-20, -30));
            desiredIntersections.Add(new Point(-20, -20));
            desiredIntersections.Add(new Point(-20, -10));

            desiredIntersections.Add(new Point(-10, 100));
            desiredIntersections.Add(new Point(-10, 90));
            desiredIntersections.Add(new Point(-10, 80));
            desiredIntersections.Add(new Point(-10, 70));
            desiredIntersections.Add(new Point(-10, 60));
            desiredIntersections.Add(new Point(-10, 50));
            desiredIntersections.Add(new Point(-10, 40));
            desiredIntersections.Add(new Point(-10, 30));
            desiredIntersections.Add(new Point(-10, 20));
            desiredIntersections.Add(new Point(-10, 10));
            desiredIntersections.Add(new Point(-10, 0));
            desiredIntersections.Add(new Point(-10, -100));
            desiredIntersections.Add(new Point(-10, -90));
            desiredIntersections.Add(new Point(-10, -80));
            desiredIntersections.Add(new Point(-10, -70));
            desiredIntersections.Add(new Point(-10, -60));
            desiredIntersections.Add(new Point(-10, -50));
            desiredIntersections.Add(new Point(-10, -40));
            desiredIntersections.Add(new Point(-10, -30));
            desiredIntersections.Add(new Point(-10, -20));
            desiredIntersections.Add(new Point(-10, -10));

            desiredIntersections.Add(new Point(0, 100));
            desiredIntersections.Add(new Point(0, 90));
            desiredIntersections.Add(new Point(0, 80));
            desiredIntersections.Add(new Point(0, 70));
            desiredIntersections.Add(new Point(0, 60));
            desiredIntersections.Add(new Point(0, 50));
            desiredIntersections.Add(new Point(0, 40));
            desiredIntersections.Add(new Point(0, 30));
            desiredIntersections.Add(new Point(0, 20));
            desiredIntersections.Add(new Point(0, 10));
            desiredIntersections.Add(new Point(0, 0));
            desiredIntersections.Add(new Point(0, -100));
            desiredIntersections.Add(new Point(0, -90));
            desiredIntersections.Add(new Point(0, -80));
            desiredIntersections.Add(new Point(0, -70));
            desiredIntersections.Add(new Point(0, -60));
            desiredIntersections.Add(new Point(0, -50));
            desiredIntersections.Add(new Point(0, -40));
            desiredIntersections.Add(new Point(0, -30));
            desiredIntersections.Add(new Point(0, -20));
            desiredIntersections.Add(new Point(0, -10));

            desiredIntersections.Add(new Point(100, 100));
            desiredIntersections.Add(new Point(100, 90));
            desiredIntersections.Add(new Point(100, 80));
            desiredIntersections.Add(new Point(100, 70));
            desiredIntersections.Add(new Point(100, 60));
            desiredIntersections.Add(new Point(100, 50));
            desiredIntersections.Add(new Point(100, 40));
            desiredIntersections.Add(new Point(100, 30));
            desiredIntersections.Add(new Point(100, 20));
            desiredIntersections.Add(new Point(100, 10));
            desiredIntersections.Add(new Point(100, 0));
            desiredIntersections.Add(new Point(100, -100));
            desiredIntersections.Add(new Point(100, -90));
            desiredIntersections.Add(new Point(100, -80));
            desiredIntersections.Add(new Point(100, -70));
            desiredIntersections.Add(new Point(100, -60));
            desiredIntersections.Add(new Point(100, -50));
            desiredIntersections.Add(new Point(100, -40));
            desiredIntersections.Add(new Point(100, -30));
            desiredIntersections.Add(new Point(100, -20));
            desiredIntersections.Add(new Point(100, -10));

            desiredIntersections.Add(new Point(90, 100));
            desiredIntersections.Add(new Point(90, 90));
            desiredIntersections.Add(new Point(90, 80));
            desiredIntersections.Add(new Point(90, 70));
            desiredIntersections.Add(new Point(90, 60));
            desiredIntersections.Add(new Point(90, 50));
            desiredIntersections.Add(new Point(90, 40));
            desiredIntersections.Add(new Point(90, 30));
            desiredIntersections.Add(new Point(90, 20));
            desiredIntersections.Add(new Point(90, 10));
            desiredIntersections.Add(new Point(90, 0));
            desiredIntersections.Add(new Point(90, -100));
            desiredIntersections.Add(new Point(90, -90));
            desiredIntersections.Add(new Point(90, -80));
            desiredIntersections.Add(new Point(90, -70));
            desiredIntersections.Add(new Point(90, -60));
            desiredIntersections.Add(new Point(90, -50));
            desiredIntersections.Add(new Point(90, -40));
            desiredIntersections.Add(new Point(90, -30));
            desiredIntersections.Add(new Point(90, -20));
            desiredIntersections.Add(new Point(90, -10));


            desiredIntersections.Add(new Point(80, 100));
            desiredIntersections.Add(new Point(80, 90));
            desiredIntersections.Add(new Point(80, 80));
            desiredIntersections.Add(new Point(80, 70));
            desiredIntersections.Add(new Point(80, 60));
            desiredIntersections.Add(new Point(80, 50));
            desiredIntersections.Add(new Point(80, 40));
            desiredIntersections.Add(new Point(80, 30));
            desiredIntersections.Add(new Point(80, 20));
            desiredIntersections.Add(new Point(80, 10));
            desiredIntersections.Add(new Point(80, 0));
            desiredIntersections.Add(new Point(80, -100));
            desiredIntersections.Add(new Point(80, -90));
            desiredIntersections.Add(new Point(80, -80));
            desiredIntersections.Add(new Point(80, -70));
            desiredIntersections.Add(new Point(80, -60));
            desiredIntersections.Add(new Point(80, -50));
            desiredIntersections.Add(new Point(80, -40));
            desiredIntersections.Add(new Point(80, -30));
            desiredIntersections.Add(new Point(80, -20));
            desiredIntersections.Add(new Point(80, -10));

            desiredIntersections.Add(new Point(70, 100));
            desiredIntersections.Add(new Point(70, 90));
            desiredIntersections.Add(new Point(70, 80));
            desiredIntersections.Add(new Point(70, 70));
            desiredIntersections.Add(new Point(70, 60));
            desiredIntersections.Add(new Point(70, 50));
            desiredIntersections.Add(new Point(70, 40));
            desiredIntersections.Add(new Point(70, 30));
            desiredIntersections.Add(new Point(70, 20));
            desiredIntersections.Add(new Point(70, 10));
            desiredIntersections.Add(new Point(70, 0));
            desiredIntersections.Add(new Point(70, -100));
            desiredIntersections.Add(new Point(70, -90));
            desiredIntersections.Add(new Point(70, -80));
            desiredIntersections.Add(new Point(70, -70));
            desiredIntersections.Add(new Point(70, -60));
            desiredIntersections.Add(new Point(70, -50));
            desiredIntersections.Add(new Point(70, -40));
            desiredIntersections.Add(new Point(70, -30));
            desiredIntersections.Add(new Point(70, -20));
            desiredIntersections.Add(new Point(70, -10));

            desiredIntersections.Add(new Point(60, 100));
            desiredIntersections.Add(new Point(60, 90));
            desiredIntersections.Add(new Point(60, 80));
            desiredIntersections.Add(new Point(60, 70));
            desiredIntersections.Add(new Point(60, 60));
            desiredIntersections.Add(new Point(60, 50));
            desiredIntersections.Add(new Point(60, 40));
            desiredIntersections.Add(new Point(60, 30));
            desiredIntersections.Add(new Point(60, 20));
            desiredIntersections.Add(new Point(60, 10));
            desiredIntersections.Add(new Point(60, 0));
            desiredIntersections.Add(new Point(60, -100));
            desiredIntersections.Add(new Point(60, -90));
            desiredIntersections.Add(new Point(60, -80));
            desiredIntersections.Add(new Point(60, -70));
            desiredIntersections.Add(new Point(60, -60));
            desiredIntersections.Add(new Point(60, -50));
            desiredIntersections.Add(new Point(60, -40));
            desiredIntersections.Add(new Point(60, -30));
            desiredIntersections.Add(new Point(60, -20));
            desiredIntersections.Add(new Point(60, -10));

            desiredIntersections.Add(new Point(50, 100));
            desiredIntersections.Add(new Point(50, 90));
            desiredIntersections.Add(new Point(50, 80));
            desiredIntersections.Add(new Point(50, 70));
            desiredIntersections.Add(new Point(50, 60));
            desiredIntersections.Add(new Point(50, 50));
            desiredIntersections.Add(new Point(50, 40));
            desiredIntersections.Add(new Point(50, 30));
            desiredIntersections.Add(new Point(50, 20));
            desiredIntersections.Add(new Point(50, 10));
            desiredIntersections.Add(new Point(50, 0));
            desiredIntersections.Add(new Point(50, -100));
            desiredIntersections.Add(new Point(50, -90));
            desiredIntersections.Add(new Point(50, -80));
            desiredIntersections.Add(new Point(50, -70));
            desiredIntersections.Add(new Point(50, -60));
            desiredIntersections.Add(new Point(50, -50));
            desiredIntersections.Add(new Point(50, -40));
            desiredIntersections.Add(new Point(50, -30));
            desiredIntersections.Add(new Point(50, -20));
            desiredIntersections.Add(new Point(50, -10));

            desiredIntersections.Add(new Point(40, 100));
            desiredIntersections.Add(new Point(40, 90));
            desiredIntersections.Add(new Point(40, 80));
            desiredIntersections.Add(new Point(40, 70));
            desiredIntersections.Add(new Point(40, 60));
            desiredIntersections.Add(new Point(40, 50));
            desiredIntersections.Add(new Point(40, 40));
            desiredIntersections.Add(new Point(40, 30));
            desiredIntersections.Add(new Point(40, 20));
            desiredIntersections.Add(new Point(40, 10));
            desiredIntersections.Add(new Point(40, 0));
            desiredIntersections.Add(new Point(40, -100));
            desiredIntersections.Add(new Point(40, -90));
            desiredIntersections.Add(new Point(40, -80));
            desiredIntersections.Add(new Point(40, -70));
            desiredIntersections.Add(new Point(40, -60));
            desiredIntersections.Add(new Point(40, -50));
            desiredIntersections.Add(new Point(40, -40));
            desiredIntersections.Add(new Point(40, -30));
            desiredIntersections.Add(new Point(40, -20));
            desiredIntersections.Add(new Point(40, -10));

            desiredIntersections.Add(new Point(30, 100));
            desiredIntersections.Add(new Point(30, 90));
            desiredIntersections.Add(new Point(30, 80));
            desiredIntersections.Add(new Point(30, 70));
            desiredIntersections.Add(new Point(30, 60));
            desiredIntersections.Add(new Point(30, 50));
            desiredIntersections.Add(new Point(30, 40));
            desiredIntersections.Add(new Point(30, 30));
            desiredIntersections.Add(new Point(30, 20));
            desiredIntersections.Add(new Point(30, 10));
            desiredIntersections.Add(new Point(30, 0));
            desiredIntersections.Add(new Point(30, -100));
            desiredIntersections.Add(new Point(30, -90));
            desiredIntersections.Add(new Point(30, -80));
            desiredIntersections.Add(new Point(30, -70));
            desiredIntersections.Add(new Point(30, -60));
            desiredIntersections.Add(new Point(30, -50));
            desiredIntersections.Add(new Point(30, -40));
            desiredIntersections.Add(new Point(30, -30));
            desiredIntersections.Add(new Point(30, -20));
            desiredIntersections.Add(new Point(30, -10));

            desiredIntersections.Add(new Point(20, 100));
            desiredIntersections.Add(new Point(20, 90));
            desiredIntersections.Add(new Point(20, 80));
            desiredIntersections.Add(new Point(20, 70));
            desiredIntersections.Add(new Point(20, 60));
            desiredIntersections.Add(new Point(20, 50));
            desiredIntersections.Add(new Point(20, 40));
            desiredIntersections.Add(new Point(20, 30));
            desiredIntersections.Add(new Point(20, 20));
            desiredIntersections.Add(new Point(20, 10));
            desiredIntersections.Add(new Point(20, 0));
            desiredIntersections.Add(new Point(20, -100));
            desiredIntersections.Add(new Point(20, -90));
            desiredIntersections.Add(new Point(20, -80));
            desiredIntersections.Add(new Point(20, -70));
            desiredIntersections.Add(new Point(20, -60));
            desiredIntersections.Add(new Point(20, -50));
            desiredIntersections.Add(new Point(20, -40));
            desiredIntersections.Add(new Point(20, -30));
            desiredIntersections.Add(new Point(20, -20));
            desiredIntersections.Add(new Point(20, -10));

            desiredIntersections.Add(new Point(10, 100));
            desiredIntersections.Add(new Point(10, 90));
            desiredIntersections.Add(new Point(10, 80));
            desiredIntersections.Add(new Point(10, 70));
            desiredIntersections.Add(new Point(10, 60));
            desiredIntersections.Add(new Point(10, 50));
            desiredIntersections.Add(new Point(10, 40));
            desiredIntersections.Add(new Point(10, 30));
            desiredIntersections.Add(new Point(10, 20));
            desiredIntersections.Add(new Point(10, 10));
            desiredIntersections.Add(new Point(10, 0));
            desiredIntersections.Add(new Point(10, -100));
            desiredIntersections.Add(new Point(10, -90));
            desiredIntersections.Add(new Point(10, -80));
            desiredIntersections.Add(new Point(10, -70));
            desiredIntersections.Add(new Point(10, -60));
            desiredIntersections.Add(new Point(10, -50));
            desiredIntersections.Add(new Point(10, -40));
            desiredIntersections.Add(new Point(10, -30));
            desiredIntersections.Add(new Point(10, -20));
            desiredIntersections.Add(new Point(10, -10));

            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": SpecialCase 2: (21 horizontal lines Perpendicular on 21 vertical lines)");
        }

        [TestMethod]
        public void SpecialCase2PerpendicularLinesIntersectingInStartOfOneOfThem()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-100, 100), new Point(100, -100)));
            inputLines.Add(new Line(new Point(0, 0), new Point(100, 100)));
            #endregion

            #region output
            desiredIntersections.Add(new Point(0, 0));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": SpecialCase 3: (2 Perpendicular Lines Intersecting In Start Of One Of Them)");
        }
        
        [TestMethod]
        public void SpecialCase3LinesIntersectingTogetherWithOneIntersectionEndAndStartOf2Lines()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-390, 260), new Point(72, -211)));
            inputLines.Add(new Line(new Point(72, -211), new Point(238, 305)));
            inputLines.Add(new Line(new Point(-354, -1), new Point(357, 146)));
            #endregion

            #region output
            desiredIntersections.Add(new Point(72, -211));
            desiredIntersections.Add(new Point(-171.0829, 36.8183));
            desiredIntersections.Add(new Point(174.7252, 108.3145));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": SpecialCase 4: (3 Lines Intersecting Together With One Intersection End And Start Of 2 Lines)");
        }
        [TestMethod]
        public void SpecialCase3LinesEndAndStartOfEachOther()
        {
            InitializeData();

            #region input
            inputLines.Add(new Line(new Point(-100, -200), new Point(200, 100)));
            inputLines.Add(new Line(new Point(-100, -200), new Point(-200, 100)));
            inputLines.Add(new Line(new Point(200, 100), new Point(-200, 100)));
            #endregion

            #region output
            desiredIntersections.Add(new Point(-100, -200));
            desiredIntersections.Add(new Point(200, 100));
            desiredIntersections.Add(new Point(-200, 100));
            #endregion

            lineIntersectionTester.Run(inputPoints, inputLines, inputPolygons, ref outputPoints, ref outputLines, ref outputPolygons);

            bool success = CompareDesiredWithActual(desiredIntersections, outputPoints);
            Assert.IsTrue(success, "Fails in " + lineIntersectionTester.ToString() + ": SpecialCase 5: (3 Lines End And Start Of Each Other)");
        }

        #endregion

        private void InitializeData()
        {
            inputPoints = new List<Point>();
            outputPoints = new List<Point>();
            inputLines = new List<Line>();
            outputLines = new List<Line>();
            desiredIntersections = new List<Point>();
            inputPolygons = new List<Polygon>();
            outputPolygons = new List<Polygon>();
        }

        private bool CompareDesiredWithActual(List<Point> _desiredIntersections, List<Point> _outputIntersections)
        {
            if (_desiredIntersections == null && _outputIntersections != null || _desiredIntersections != null && _outputIntersections == null)
                return false;

            // make sure list is unique (with 1 digit precision)
            _outputIntersections = GetUniqueElements1DigitPrecision(_outputIntersections);
            _desiredIntersections = GetUniqueElements1DigitPrecision(_desiredIntersections);
            
            if (_desiredIntersections.Count != _outputIntersections.Count)
                return false;

            for (int i = 0; i < _desiredIntersections.Count; i++)
            {
                bool isFound = false;

                for (int j = 0; j < _outputIntersections.Count; j++)
                {
                    if (_desiredIntersections[i].Equals(_outputIntersections[j]))
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                    return false;
            }

            return true;
        }

        private List<Point> GetUniqueElements1DigitPrecision(List<Point> intersectionPoints)
        {
            foreach (var p1 in intersectionPoints)
            {
                p1.X = ((int)(p1.X * 10)) / 10.0;
                p1.Y = ((int)(p1.Y * 10)) / 10.0;
            }

            //return intersectionPoints.Distinct().ToList(); // commented bcz it needs equal to be overridden + it's not working when its overriden .. need further debugging

            for (int i = 0; i < intersectionPoints.Count; i++)
            {
                for (int j = 0; j < intersectionPoints.Count; j++)
                {
                    if (i != j && intersectionPoints[i].Equals(intersectionPoints[j]))
                    {
                        intersectionPoints.RemoveAt(j);
                        break;
                    }
                }
            }

            return intersectionPoints;
        }
    }
}