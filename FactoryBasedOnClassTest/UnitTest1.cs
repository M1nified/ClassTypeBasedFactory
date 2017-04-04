using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryBasedOnClass;

namespace FactoryBasedOnClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetProductTest()
        {
            var factory = new Factory();
            var product = factory.GetProduct<Type1>();
            Assert.IsNotNull(product);
            Assert.IsInstanceOfType(product, typeof(Product1));
            Assert.IsInstanceOfType(product, typeof(IProduct<Type1>));
        }
    }
}
