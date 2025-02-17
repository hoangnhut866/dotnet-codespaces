class Utilities
{
    //Generic method to swap two values
    public void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }

    //Generic method with multiple type parameters
    public void PrintPair<T1, T2>(T1 first, T2 second)
    {
        Console.WriteLine($"First: {first}, Second: {second}");
        Console.WriteLine(first?.GetType());
        Console.WriteLine(second?.GetType());
    }

}

class Program
{
    static void Main(string[] args)
    {
        Utilities utilities = new Utilities();

        //Swap intergers
        int x = 3;
        int y = 5;
        utilities.Swap<int>(ref x, ref y);
        Console.WriteLine($"After swap: x = {x}, y = {y}");

        //Swap strings
        string a = "Xin chao";
        string b = "Hello";
        utilities.Swap<string>(ref a, ref b);
        Console.WriteLine($"After swap: a = {a}, b = {b}");

        //Print a pair of int and string
        utilities.PrintPair<int, string>(1, "Nhut");

        //Print a pair of double and boolean
        utilities.PrintPair<double, bool>(3.45, false);

    }
}