namespace FactoryBasedOnClass
{
    public interface IProduct<T> where T : IType
    {
        void Action1();
        void Action2();
    }
}
