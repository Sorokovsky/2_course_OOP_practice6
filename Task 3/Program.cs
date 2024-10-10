namespace Task_3;
public static class Program
{
    public static void Main()
    {
        MyDictionary<string, int> dictionary = new();
        dictionary.Add("i", 2);
        Console.WriteLine($"Size: {dictionary.Count}");
        Console.WriteLine($"At 'i' = {dictionary["i"]}");
        Console.WriteLine($"Count: {dictionary.Count}");
        
    }
}