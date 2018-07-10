using System.Runtime.CompilerServices;

namespace EasyMonad.Core.Option
{
    public static class OptionSyntax
    {
        public static OptionNotifyCompletion<T> GetAwaiter<T>(this Option<T> option)
        {
            return new OptionNotifyCompletion<T>(option);
        }
        
        public static NoneOptionNotifyCompletion GetAwaiter(this NoneOption option)
        {
            return new NoneOptionNotifyCompletion();
        }
    }
}