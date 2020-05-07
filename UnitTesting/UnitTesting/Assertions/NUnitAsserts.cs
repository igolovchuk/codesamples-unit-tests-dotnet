namespace UnitTesting.Assertions
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class NUnitAsserts
    {
        private readonly string testText ="test";
        
        [Test]
        public void AssertsTest()
        {
            Assert.Greater(5, 3); // The same 5 > 3
        }

        [Test]
        public void AssertsNotNull()
        {
            Assert.IsNotNull(this.testText);
        }

        [Test]
        public void AbsTest()
        {
            int actual = 5*2;
            int result = 10;
            
            Assert.AreEqual(actual, result);
        }
    }
}
