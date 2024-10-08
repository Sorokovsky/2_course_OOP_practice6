namespace Task_2;
public static class Program
{
    public static void Main()
    {
       int number = MyClass<int>.FactoryMethod();
       bool boolean = MyClass<bool>.FactoryMethod();
       Console.WriteLine($"Number: {number}");
       Console.WriteLine($"Bool: {boolean}");
    }
}