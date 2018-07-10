using System;
using System.Runtime.CompilerServices;

namespace EasyMonad.Core.Option
{
    public struct AsyncOptionBuilder<TResult>
    {
        public static AsyncOptionBuilder<TResult> Create()
        {
            return new AsyncOptionBuilder<TResult>();
        }
        
        public void Start<TStateMachine>(ref TStateMachine stateMachine)
            where TStateMachine : IAsyncStateMachine
        {
            stateMachine.MoveNext();
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            
        }

        public void SetResult(TResult result)
        {
            this.Task = new Some<TResult>(result);
        }

        public void SetException(Exception exception)
        {
            this.Task = new NoneOption();
        }
        
        // Returns HardTask<TResult>, not Task<TResult>
        public Option<TResult> Task { get; private set; }

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(
            ref TAwaiter awaiter,
            ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
            
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(
            ref TAwaiter awaiter,
            ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
            
        }
    }
}