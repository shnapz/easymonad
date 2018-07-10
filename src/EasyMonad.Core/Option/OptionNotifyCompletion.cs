using System;
using System.Runtime.CompilerServices;

namespace EasyMonad.Core.Option
{
    public class NoneOptionNotifyCompletion : INotifyCompletion
    {
        public void OnCompleted(Action continuation)
        {
            throw new NotImplementedException();
        }

        public bool IsCompleted { get; } = true;

        public void GetResult()
        {
            throw new NoneAwaiterException();
        }
    }
    
    public class OptionNotifyCompletion<T> : INotifyCompletion
    {
        private readonly Option<T> item;

        public OptionNotifyCompletion(Option<T> item)
        {
            this.item = item ?? throw new ArgumentNullException();
        }
        
        public void OnCompleted(Action continuation)
        {
            throw new NotImplementedException();
        }

        public bool IsCompleted { get; } = true;

        public T GetResult()
        {
            if (this.item.IsEmpty)
            {
                throw new NoneAwaiterException();
            }

            return this.item.Get;
        }
    }
}