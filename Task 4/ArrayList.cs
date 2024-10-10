namespace Task_4
{
    public class ArrayList<T>
    {
        private System.Collections.ArrayList _arrayList = new();

        public int Count => _arrayList.Count;

        public void Add(T item) 
        {
            _arrayList.Add(item);
        }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return (T)_arrayList[index];
            }
        }     
    }
}