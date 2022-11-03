using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaPortal;
using PizzaPortal.Models;

namespace Test
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
