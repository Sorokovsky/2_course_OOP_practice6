namespace Individual
{
    public class PharmacyList<T> where T : Pharmacy
    {        
        public delegate bool IsNeed(T item);

        private T[] _array;

        public int Count => _array.Count();

        public PharmacyList(int count)
        {
            _array = new T[count];
        }

        public void Add(T item)
        {
            _array.Append(item);
        }

        public T this[int index]
        {
            get
            {
                if(IsValidIndex(index))
                {
                    return _array.ElementAt(index);
                }
                else 
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if(IsValidIndex(index))
                {
                    _array[index] = value;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private bool IsValidIndex(int index)
        {
            if(index < 0 || index >= Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Remove(IsNeed isNeed)
        {
            
        }
    }
}