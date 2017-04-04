using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBasedOnClass
{
    public class Factory
    {
        public IProduct<T> GetProduct<T>() where T : IType
        {
            Type type = typeof(T);
            if( type == typeof(Type1))
            {
                return (IProduct<T>)new Product1();
            }
            else if(type == typeof(Type2))
            {
                return (IProduct<T>)new Product2();
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
