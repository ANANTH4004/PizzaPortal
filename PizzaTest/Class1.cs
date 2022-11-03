using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaPortal;
using PizzaPortal.Models;

namespace PizzaTest
{
    [TestFixture]
    public class Test
    {
       Info Op = null;
        public Test()
        {
            Op = new Info();
        }
        [TestCase(ExpectedResult = true)]
        [TestCase(ExpectedResult = true)]
        [TestCase(ExpectedResult = true)]
        public bool test()
        {
            return Op.ans();
        }
    }
}
