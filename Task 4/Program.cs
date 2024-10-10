
namespace Task_4;
public static class Program
{
    public static void Main()
    {
        ArrayList<int> numbers = new();
        numbers.Add(3);
        numbers.Add(5);
        Console.WriteLine($"At 0 = {numbers[0]}");
        Console.WriteLine($"Count = {numbers.Count}");
    }
}