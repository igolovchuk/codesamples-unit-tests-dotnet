namespace UnitTesting.TestImplementation
{
    using NUnit.Framework;

    [TestFixture]
    public class NUnitExample
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
        }
        
        [SetUp]
        public static void TestInit()
        {
        }

        [Test, Description("Example")]
        public void SimpleTestExample()
        {
        }

        [Test, Timeout(500)]
        public void SimpleTestTime()
        {
        }

        [Test, Category("Regression")]
        public void SimpleTestCategory()
        {
        }

        [Test, ExpectedException("System.AgrumentException")]
        public void SimpleTestException()
        {
        }
        
        [TearDown]
        public static void TestClean()
        {
        }
        
        [TestFixtureTearDown]
        public static void ClassClean()
        {
        }
    }
}
