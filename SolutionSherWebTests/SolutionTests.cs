using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace SolutionSherWeb.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        [DataRow(18, 3, 4, 9, 8, 2, 6)]
        [DataRow(20, 5, 5, 6, 3, 4, 2)]
        [DataRow(-1, 1, 7, 7, 7, 7, 7)]
        [DataRow(-1, 1000, 2)]
        [DataRow(12, 3, 2, 3, 3, 5, 5)]
        public void mySolutionTest(int r, int K, params int[] data)
        {
            var o = new Solution();
            var result = o.mySolution(data, K);
            result.Should().Be(r);
        }
    }
}