using NUnit.Framework;
namespace Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method called before each test.");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine(" Its Test 1");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine(" Its Test 2");
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.Progress.WriteLine("Teardown Method");
        }
    }
}
