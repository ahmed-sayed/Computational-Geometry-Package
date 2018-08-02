using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGAlgorithms.Algorithms.SegmentIntersection;

namespace CGAlgorithmsUnitTest.LineIntersection
{
    /// <summary>
    /// 10 Test Cases, each 10% from the total grade.
    /// Grade is 0.1 for each test case where total algorithm grade is 10.
    /// </summary>
    [TestClass]
    public class SweepLineTest : LineIntersectionTest
    {
        [TestMethod]
        public void SweepLineNormalTestCaseRandom4LinesIntersectingWithRandom4Lines()
        {
            lineIntersectionTester = new SweepLine();
            CaseRandom4LinesIntersectingWithRandom4Lines();
        }

        [TestMethod]
        public void SweepLineNormalTestCaseRandom5GroupsOfLineIntersections()
        {
            lineIntersectionTester = new SweepLine();
            CaseRandom5GroupsOfLineIntersections();
        }

        [TestMethod]
        public void SweepLineNormalTestCaseRandom4LinesIntersectingTogether()
        {
            lineIntersectionTester = new SweepLine();
            CaseRandom4LinesIntersectingTogether();
        }

        [TestMethod]
        public void SweepLineNormalTestCaseEasyCase1LineIntersecting5Lines()
        {
            lineIntersectionTester = new SweepLine();
            CaseEasyCase1LineIntersecting5Lines();
        }

        [TestMethod]
        public void SweepLineNormalTestCaseEasyCase2LinesIntersecting5Lines()
        {
            lineIntersectionTester = new SweepLine();
            CaseEasyCase2LinesIntersecting5Lines();
        }

        [TestMethod]
        public void SweepLineSpecialTestCase21HorizontalLinesPerpendicularOn1VerticalLines()
        {
            lineIntersectionTester = new SweepLine();
            SpecialCase21HorizontalLinesPerpendicularOn1VerticalLines();
        }

        [TestMethod]
        public void SweepLineSpecialTestCase21HorizontalLinePerpendicularOn21VerticalLine()
        {
            lineIntersectionTester = new SweepLine();
            SpecialCase21HorizontalLinePerpendicularOn21VerticalLine();
        }

        [TestMethod]
        public void SweepLineSpecialTestCase2PerpendicularLinesIntersectingInStartOfOneOfThem()
        {
            lineIntersectionTester = new SweepLine();
            SpecialCase2PerpendicularLinesIntersectingInStartOfOneOfThem();
        }

        [TestMethod]
        public void SweepLineSpecialTestCase3LinesIntersectingTogetherWithOneIntersectionEndAndStartOf2Lines()
        {
            lineIntersectionTester = new SweepLine();
            SpecialCase3LinesIntersectingTogetherWithOneIntersectionEndAndStartOf2Lines();
        }

        [TestMethod]
        public void SweepLineSpecialTestCase3LinesEndAndStartOfEachOther()
        {
            lineIntersectionTester = new SweepLine();
            SpecialCase3LinesEndAndStartOfEachOther();
        }
    }
}
