using NUnit.Framework;
using NUnitMoqHandson7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary7
{
    [TestFixture]
    public class Tests
    {
        Calculator c = new Calculator();
        [TestCase]
        public void TestCheck_NullException()
        {
            Assert.Throws<ArgumentNullException>(() => c.Divide(5, 0));
        }
    }
}
