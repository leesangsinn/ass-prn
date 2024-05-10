public class Bai2
{
    public static int Main(string[] args)
    { 
        Console.Write("Enter a number 1:");
        int num1 =Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a number 2:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Sum of two number:");
        Console.WriteLine(num1 + num2);
        return 0;
    }
}