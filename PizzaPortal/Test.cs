using NuGet.ContentModel;
using NUnit.Framework;
using PizzaPortal.Models;

namespace PizzaPortal
{
    [TestFixture]
    public class Test
    {
        Info info = null;
        public Test()
        {
            info = new Info();
            info.InsertData();

        }
        [TestCase]
        public void menucheck()
        {
            PizzaDetails p1 = new PizzaDetails();
            p1.Price = 100;
            Assert.AreEqual(p1.Price, 100);

        }
    }
}
