using System;

namespace FactoryBasedOnClass
{
    public class Product2 : IProduct<Type2>
    {
        public void Action1()
        {
            throw new NotImplementedException();
        }

        public void Action2()
        {
            throw new NotImplementedException();
        }
    }
}
