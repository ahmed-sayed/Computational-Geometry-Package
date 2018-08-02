using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGUtilities.DataStructures;
using CGUtilities;
using System.Collections.Generic;

namespace CGUtilitiesUnitTest
{
    [TestClass]
    public class OrderedSetTest
    {
        [TestMethod]
        public void DirectRightAndLeftNormalTestCase()
        {
            OrderedSet<int> tree = new OrderedSet<int>();
            tree.Add(10);
            tree.Add(-10);
            tree.Add(20);
            tree.Add(-20);

            OrderedSet<int> expectedOutputTree = new OrderedSet<int>();
            expectedOutputTree.Add(10);
            expectedOutputTree.Add(-10);
            expectedOutputTree.Add(20);
            expectedOutputTree.Add(-20);

            var outputRL = tree.DirectRightAndLeft(11);
            var expectedOutputRL = new KeyValuePair<int, int>(20, 10);

            Assert.AreEqual(outputRL.Key, expectedOutputRL.Key, "Right element is incorrect");
            Assert.AreEqual(outputRL.Value, expectedOutputRL.Value, "Left element is incorrect");

            Assert.AreEqual(expectedOutputTree.Count, tree.Count, "Tree size is incorrect!");

            for (int i = 0; i < expectedOutputTree.Count; i++)
            {
                Assert.AreEqual(expectedOutputTree[i], tree[i], "Tree Element at index " + i + " is incorrect");
            }
        }

        [TestMethod]
        public void DirectRightAndLeftCheckExistingItem()
        {
            OrderedSet<int> tree = new OrderedSet<int>();
            tree.Add(10);
            tree.Add(-10);
            tree.Add(20);
            tree.Add(-20);

            OrderedSet<int> expectedOutputTree = new OrderedSet<int>();
            expectedOutputTree.Add(10);
            expectedOutputTree.Add(-10);
            expectedOutputTree.Add(20);
            expectedOutputTree.Add(-20);

            var outputRL = tree.DirectRightAndLeft(10);
            var expectedOutputRL = new KeyValuePair<int, int>(20, -10);

            Assert.AreEqual(outputRL.Key, expectedOutputRL.Key, "Right element is incorrect");
            Assert.AreEqual(outputRL.Value, expectedOutputRL.Value, "Left element is incorrect");

            Assert.AreEqual(expectedOutputTree.Count, tree.Count, "Tree size is incorrect!");

            for (int i = 0; i < expectedOutputTree.Count; i++)
            {
                Assert.AreEqual(expectedOutputTree[i], tree[i], "Tree Element at index " + i + " is incorrect");
            }
        }

        class ClassTester
        {
            public int compareByValue;
            public int otherProperties;

            public ClassTester(int x, int y)
            {
                compareByValue = x;
                otherProperties = y;
            }

            public override bool Equals(object obj)
            {
                ClassTester c2 = (ClassTester)obj;

                return c2.compareByValue == compareByValue && c2.otherProperties == otherProperties;
            }
        }

        [TestMethod]
        public void DirectRightAndLeftCheckExistingObject()
        {
            OrderedSet<ClassTester> tree = new OrderedSet<ClassTester>((x, y) => { return x.compareByValue.CompareTo(y.compareByValue); });
            tree.Add(new ClassTester(10, 2));
            tree.Add(new ClassTester(-10, 1));
            tree.Add(new ClassTester(20, 3));
            tree.Add(new ClassTester(-20, 0));

            OrderedSet<ClassTester> expectedOutputTree = new OrderedSet<ClassTester>((x, y) => { return x.compareByValue.CompareTo(y.compareByValue); });
            expectedOutputTree.Add(new ClassTester(10, 2));
            expectedOutputTree.Add(new ClassTester(-10, 1));
            expectedOutputTree.Add(new ClassTester(20, 3));
            expectedOutputTree.Add(new ClassTester(-20, 0));

            var outputRL = tree.DirectRightAndLeft(new ClassTester(-20, 2));
            var expectedOutputRL = new KeyValuePair<ClassTester, ClassTester>(new ClassTester(-10, 1), null);

            Assert.AreEqual(outputRL.Key.compareByValue, expectedOutputRL.Key.compareByValue, "Right element is incorrect");
            Assert.AreEqual(outputRL.Key.otherProperties, expectedOutputRL.Key.otherProperties, "Right element is incorrect");
            Assert.AreEqual(outputRL.Value, expectedOutputRL.Value, "Left element is incorrect");
            Assert.AreEqual(outputRL.Value, expectedOutputRL.Value, "Left element is incorrect");

            Assert.AreEqual(expectedOutputTree.Count, tree.Count, "Tree size is incorrect!");

            for (int i = 0; i < expectedOutputTree.Count; i++)
            {
                Assert.AreEqual(expectedOutputTree[i], tree[i], "Tree Element at index " + i + " is incorrect");
            }
        }

        [TestMethod]
        public void DirectRightAndLeftCheckExistingObjectWithDifferentValue()
        {
            OrderedSet<ClassTester> tree = new OrderedSet<ClassTester>((x, y) => { return x.compareByValue.CompareTo(y.compareByValue); });
            tree.Add(new ClassTester(10, 2));
            tree.Add(new ClassTester(-10, 1));
            tree.Add(new ClassTester(20, 3));
            tree.Add(new ClassTester(-20, 0));

            OrderedSet<ClassTester> expectedOutputTree = new OrderedSet<ClassTester>((x, y) => { return x.compareByValue.CompareTo(y.compareByValue); });
            expectedOutputTree.Add(new ClassTester(10, 2));
            expectedOutputTree.Add(new ClassTester(-10, 1));
            expectedOutputTree.Add(new ClassTester(20, 3));
            expectedOutputTree.Add(new ClassTester(-20, 0));

            var outputRL = tree.DirectRightAndLeft(new ClassTester(-20, 100));
            var expectedOutputRL = new KeyValuePair<ClassTester, ClassTester>(new ClassTester(-10, 1), null);

            Assert.AreEqual(outputRL.Key.compareByValue, expectedOutputRL.Key.compareByValue, "Right element is incorrect");
            Assert.AreEqual(outputRL.Key.otherProperties, expectedOutputRL.Key.otherProperties, "Right element is incorrect");
            Assert.AreEqual(outputRL.Value, expectedOutputRL.Value, "Left element is incorrect");
            Assert.AreEqual(outputRL.Value, expectedOutputRL.Value, "Left element is incorrect");

            Assert.AreEqual(expectedOutputTree.Count, tree.Count, "Tree size is incorrect!");

            for (int i = 0; i < expectedOutputTree.Count; i++)
            {
                Assert.AreEqual(expectedOutputTree[i], tree[i], "Tree Element at index " + i + " is incorrect");
            }
        }
    }
}
