namespace Task_3
{
    public interface IDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value);

        public TValue this[TKey key] {get;}

        public int Count {get;}
    }
}