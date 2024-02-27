using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task3;

namespace TestTask3
{
    [TestClass]
    public class TestLine
    {
        private (string LineString, int Index, bool IsBroken, decimal? Sum)[] LineLiterals;


        [TestInitialize]
        public void TestInitialize()
        {
            LineLiterals = new (string, int, bool, decimal?)[]
            {
                ("1,2,3,4", 1, false, 10),
                ("1,2,3.5,4.756", 2,  false, 11.256m),
                ("   12.6522   ,   4.1,  555  ,-3.13", 3, false, 568.6222m),

                ("", 4, true, null),
                ("123.   32, 67.345", 5, true, null),
                ("abcdef", 6, true, null)
            };
        }
        
        [TestMethod]
        public void TestLineParsing()
        {
            foreach (var lineLiteral in LineLiterals)
            {
                var lineInstance = new Line(lineLiteral.LineString, lineLiteral.Index);
                Assert.AreEqual(lineLiteral.IsBroken, lineInstance.IsBroken);
            }
        }
        
        [TestMethod]
        public void TestLineSum()
        {
            foreach (var lineLiteral in LineLiterals)
            {
                var lineInstance = new Line(lineLiteral.LineString, lineLiteral.Index);
                if (lineLiteral.Sum == null)
                {
                    Assert.ThrowsException<InvalidOperationException>(() => lineInstance.GetSum());
                }
                else
                {

                    Assert.AreEqual(lineLiteral.Sum, lineInstance.GetSum());
                }

            }
        }

    }
}