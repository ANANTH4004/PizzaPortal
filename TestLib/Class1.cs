using NUnit.Framework;
using PizzaPortal;
using PizzaPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    [TestFixture]
    public class Class1
    {
        Info info = null;
        public Class1()
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
