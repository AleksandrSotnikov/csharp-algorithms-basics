using NUnit.Framework;

namespace BasicSyntax.Tests
{
    public class VariableTests
    {
        [Test]
        public void TestIntAssignment()
        {
            int a = 1;
            Assert.AreEqual(1, a);
        }

        [Test]
        public void TestDoubleAssignment()
        {
            double b = 2.2;
            Assert.AreEqual(2.2, b, 0.01);
        }

        [Test]
        public void TestStringAssignment()
        {
            string c = "test";
            Assert.AreEqual("test", c);
        }

        [Test]
        public void TestBoolAssignment()
        {
            bool d = true;
            Assert.IsTrue(d);
        }

        [Test]
        public void TestCircleArea()
        {
            const double Pi = 3.1415;
            double r = 5;
            double S = Pi * r * r;
            Assert.AreEqual(78.5375, S, 0.01);
        }

        [Test]
        public void TestIntToStringAndBack()
        {
            int x = 99;
            string s = x.ToString();
            int y = int.Parse(s);
            Assert.AreEqual(99, y);
        }
    }
}