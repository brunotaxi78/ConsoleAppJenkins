using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {

        [Fact]
        public void Test_Equal()
        {
            
            Assert.Equal("1","1");
        }

        [Fact]
        public void Test_Not_Equal()
        {

            Assert.Equal("1", "2");
        }

        [Fact]
        public void Test1()
        {
            DateTime dt = DateTime.Now;
            Assert.Equal("Bruno's Jenkins Pipeline Example" + " - " + DateTime.Now.ToString(), Lib.Class1.Execute("Teste Bruno", dt));
        }
    }
}
