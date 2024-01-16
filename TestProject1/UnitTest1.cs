using NUnit.Framework;
using Project.Service;

namespace UnitTest
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
            Assert.IsTrue(Utility.CompareVersions("0123", "123") == 0);
        }

        [Test]
        public void Test2()
        {
            int number = 967;
            Assert.IsTrue(Utility.IsPrime(number), $"{number} should not be prime");
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(PolishServices.GetResult("1 2 + 4 * 3 +") == 15);
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(PolishServices.GetResult("7,2,3,*,-") == 1);
        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(PolishServices.GetResult("20,5,/,3,*") == 12);
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(Utility.Scrabble("rkqodlw", "world"));
        }

        [Test]
        public void Test7()
        {
            Assert.IsTrue(Utility.Scrabble("avj", "java") == false);
        }

        [Test]
        public void Test8()
        {
            Assert.IsTrue(Utility.Scrabble("avjafff", "java"));
        }

        [Test]
        public void Test9()
        {
            Assert.IsTrue(Utility.Scrabble("", "hexlet") == false);
        }

        [Test]
        public void Test10()
        {
            Assert.IsTrue(Utility.Scrabble("scriptingjava", "JavaScript"));
        }

        [Test]
        public void Test11()
        {
            Assert.IsTrue(Utility.Scrabble("scriptingjava", ""));
        }

        [Test]
        public void Test12()
        {
            Counter<char> counter = new Counter<char>("AAAABBBCCD");
            Assert.IsTrue(counter.Total == 10);
        }

        [Test]
        public void Test13()
        {
            Counter<char> counter = new Counter<char>("AAAABBBCCD");
            Assert.IsTrue(counter.TryGetValue('A') == 4);
        }

        [Test]
        public void Test14()
        {
            int number = 126;
            Assert.IsTrue(Utility.IsEven(number), $"{number} should be even");
        }
    }
}