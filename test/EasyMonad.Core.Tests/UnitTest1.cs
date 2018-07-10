using System;
using System.Threading.Tasks;
using Xunit;

namespace EasyMonad.Core.Tests
{
    using static EasyMonad.Core.Prelude;
    using EasyMonad.Core.Option;
    
    public class UnitTest1W
    {
        private Option<int> GetOption(int item) => item > 10 ? Some(item) : None;

        public async Option<int> InvokeSequence()
        {
            var result1 = await GetOption(12);
            Console.WriteLine(result1);
            var result2 = await GetOption(300);
            Console.WriteLine(result2);
            return await GetOption(30);
        }

        [Fact]
        public async Task Test1()
        {
            await InvokeSequence();
        }
    }
}
