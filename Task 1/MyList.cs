namespace Task_1
{
    public class MyList<T> : IList<T>
    {
        private readonly List<T> _list = new();

        public int Count => _list.Count;

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                return _list.ElementAt(index);
            }
        }

        public void Add(T item)
        {
            _list.Add(item);
        }
    }
}