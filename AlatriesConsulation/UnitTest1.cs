using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KordellGiffordCapstone;

namespace AlatriesConsulation
{
    [TestClass]
    public class UnitTest1
    {
        DataAccess da = new DataAccess();

        [TestMethod]
        public void ModifyCustomerLookupTest()
        {
            var name = "";
            da.OpenConnection();
            
            da.CloseConnection();

            Assert.IsTrue();
        }
    }
}
