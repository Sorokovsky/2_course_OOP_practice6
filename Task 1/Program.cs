namespace Task_1;
public static class Program
{
    public static void Main()
    {
        MyList<int> myList = new();
        myList.Add(1);
        myList.Add(3);
        Console.WriteLine("Size: {0}", myList.Count);
        Console.WriteLine($"At index 1 = {myList[1]}");
    }
}