using EasyMonad.Core.Option;

namespace EasyMonad.Core
{
    public static class Prelude
    {
        public static Option<T> Some<T>(T item) => new Some<T>(item);
        
        public static NoneOption None => new NoneOption();
    }
}
