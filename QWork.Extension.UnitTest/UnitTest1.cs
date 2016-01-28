using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QWork.Extension;

namespace QWork.Extension.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string number = "1";
            if (number.ToInt().IsLargerThan(-10))
            {

            }
        }
    }
}
