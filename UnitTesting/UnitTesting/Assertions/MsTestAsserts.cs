namespace UnitTesting.Assertions
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class MsTestAsserts
    {

        [TestMethod]
        public void TestListOfT()
        {
            var list1 = new List<MyPerson>()
                {
                    new MyPerson()
                    {
                        Name = "A",
                        Age = 20
                    },
                    new MyPerson()
                    {
                        Name = "B",
                        Age = 30
                    }
                };
                        var list2 = new List<MyPerson>()
                {
                    new MyPerson()
                    {
                        Name = "A",
                        Age = 20
                    },
                    new MyPerson()
                    {
                        Name = "B",
                        Age = 30
                    }
                };

            CollectionAssert.AreEquivalent(list1.ToList(), list2.ToList());
        }

        public class MyPerson
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        [TestMethod]
        public void SimpleStringAssert()
        {
            StringAssert.Contains("ABCD", "BC");
        }

        [TestMethod]
        public void SimpleTestExample()
        {
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void AdditionTestNotEquals6()
        {
            Assert.AreNotEqual<double>((1.2 * 4.2), 6.1);
        }

    }
}
