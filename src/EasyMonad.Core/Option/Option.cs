using System.Runtime.CompilerServices;

namespace EasyMonad.Core.Option
{
    [AsyncMethodBuilder(typeof(AsyncOptionBuilder<>))]
    public abstract class Option<T>
    {
        public abstract T Get { get; }
        
        public abstract bool IsEmpty { get; }
        
        public static implicit operator Option<T>(NoneOption _)
        {
            return new None<T>();
        }
    }
}