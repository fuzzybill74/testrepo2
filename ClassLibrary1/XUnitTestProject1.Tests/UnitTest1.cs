using System;
using Xunit;

namespace XUnitTestProject1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cls = new ClassLibrary1.Class1();

            var result = cls.Add(1, 2);
            Assert.Equal(3, result);
        }
    }
}
