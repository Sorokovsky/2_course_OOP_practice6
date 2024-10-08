namespace Task_1
{
    public interface IList<T>
    {
        public void Add(T item);

        public T this[int index] {get;}

        public int Count {get;}
    }
}