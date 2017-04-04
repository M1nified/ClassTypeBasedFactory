using System;

namespace FactoryBasedOnClass
{
    public class Product1 : IProduct<Type1>
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
