namespace EasyMonad.Core.Option
{
    public class Some<T> : Option<T>
    {
        public Some(T item)
        {
            this.Get = item;
        }
        
        public override T Get { get; }

        public override bool IsEmpty { get; } = false;
    }
}