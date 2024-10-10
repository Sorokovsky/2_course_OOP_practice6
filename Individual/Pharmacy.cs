namespace Individual
{
    public class Pharmacy
    {
        private int _count;

        public string Name {get; set;} = string.Empty;

        public int Count   
        {
            get
            {
                return _count;
            }
            set
            {
                if(value < 0) _count = 0;
                else _count = value;
            }
        }     

        public Pharmacy(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nCount: {Count}";
        }

        public static Pharmacy Enter()
        {
            Console.Write("Enter a name: "); string name = Console.ReadLine();
            Console.Write("Enter a count: "); int count = Convert.ToInt32(Console.ReadLine());
            return new(name, count);
        }
    }
}