using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace TestTask3
{
    [TestClass]
    public class TestFileParser
    {
        readonly string _filePath = Path.Combine(new[]{"..", "..", "..", "files", "test_numbers.txt"});
        
        [TestMethod]
        public void TestGetLineWithMaximumSum()
        {
            var parser = new FileParser(_filePath);
            var maxSumLine = parser.LineWithMaximumSum;
            Assert.AreEqual(2, maxSumLine);
        }

        [TestMethod]
        public void TestGetBrokenLinesIndexes()
        {
            var parser = new FileParser(_filePath);
            var brokenLines = parser.GetBrokenLinesIndexes();
            var expectedBrokenLines = new[] { 3, 4 };

            Assert.IsTrue(expectedBrokenLines.SequenceEqual(brokenLines));
        }
    }
}