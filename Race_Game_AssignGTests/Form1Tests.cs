using Microsoft.VisualStudio.TestTools.UnitTesting;
using Race_Game_AssignG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Game_AssignG.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void form1Test()
        {
            ResultDeclare rst = new ResultDeclare();
            if (rst.jumpStep() > 10)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void form2Test()
        {
            ResultDeclare rst = new ResultDeclare();
            int budget = rst.budgetSet("Harpreet choose 2 dog and 30 dollar", 100, 2);
            if (budget==130)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}