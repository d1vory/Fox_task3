using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace TestTask3
{
    [TestClass]
    public class TestFileParser
    {
        [TestMethod]
        public void TestGetLineWithMaximumSum()
        {
            var filename = @"C:\Users\Olexandr\MyProjects\CSHARP\foxminded\task3\TestTask3\files\test_numbers.txt";
            var parser = new FileParser(filename);
            var maxSumLine = parser.GetLineWithMaximumSum();
            Assert.AreEqual(2, maxSumLine);
        }

        [TestMethod]
        public void TestGetBrokenLinesIndexes()
        {
            var filename = @"C:\Users\Olexandr\MyProjects\CSHARP\foxminded\task3\TestTask3\files\test_numbers.txt";
            var parser = new FileParser(filename);
            var brokenLines = parser.GetBrokenLinesIndexes();
            var expectedBrokenLines = new[] { 3, 4 };

            Assert.IsTrue(expectedBrokenLines.SequenceEqual(brokenLines));
        }
    }
}