using NUnit.Framework;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string h = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello",h); 
        }
        [Test]
        public void Test2()
        {
            string e = Program.Prefix(""); 
            Assert.AreEqual("0,0:", e);
        }
        [Test]
        public void Test3()
        {
            string i = Program.Prefix("what   ... did you say?? ");
            Assert.AreEqual("27,5:what    ... did you say?? ", i);
        }

    }
}