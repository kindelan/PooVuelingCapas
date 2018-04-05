using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class AlumnoDaoTests
    {

        [TestInitialize]
        public void testInit()
        {
            
        }

        [DataRow(1, "dd", "dd", "dd", "10-03-1988")]
        [DataTestMethod]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestCleanup]
        public void testClean()
        {
            //
        }
    }
}