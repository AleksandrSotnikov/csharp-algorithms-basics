using NUnit.Framework;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Test]
        public void TestOutput()
        {
            using (var sw = new System.IO.StringWriter())
            {
                System.Console.SetOut(sw);
                Program.Main(new string[] {});
                var result = sw.ToString().Trim();
                Assert.AreEqual("Hello, World!", result);
            }
        }
    }
}