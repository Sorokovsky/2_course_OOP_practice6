namespace Task_3
{
    public class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary = new(); 

        public TValue this[TKey key] 
        {
            get
            {
                if(_dictionary.TryGetValue(key, out TValue value))
                {
                    return value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public int Count => _dictionary.Count;

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }
    }
}