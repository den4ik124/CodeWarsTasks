using Array.diff;
using NUnit.Framework;

using System;

namespace CodeWarsTasks
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 2 }, Program.SubstractArray(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 2, 2 }, Program.SubstractArray(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 1 }, Program.SubstractArray(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { 1, 2, 2 }, Program.SubstractArray(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.AreEqual(new int[] { }, Program.SubstractArray(new int[] { }, new int[] { 1, 2 }));
            Assert.AreEqual(new int[] { 3 }, Program.SubstractArray(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }
    }
}