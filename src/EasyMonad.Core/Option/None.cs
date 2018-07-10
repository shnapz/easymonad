using System;

namespace EasyMonad.Core.Option
{
    public class None<T> : Option<T>
    {
        public override T Get => throw new InvalidOperationException();

        public override bool IsEmpty { get; } = true;
    }

    public class NoneOption
    {
    }
}