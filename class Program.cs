class Program
{
    static void Main()
    {
        Console.WriteLine("~~~~~ FizzBuzz ~~~~~");
        Console.WriteLine("Enter a number:");
        var input = int.Parse(Console.ReadLine());
        Console.WriteLine(FizzBuzz(input));
    }
    
    static string FizzBuzz (int num)
    {
        if (num % 3 == 0 && num % 5 == 0) {return "fizzbuzz";}
        if (num % 3 == 0) {return "fizz";}
        if (num % 5 == 0) {return "buzz";}
        return "Try another number";
    }
}