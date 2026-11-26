class Program
{
    static void Main(string[] args)
{
    string input;
    int num1, num2;

    Console.WriteLine("Enter the first number:");
    input = Console.ReadLine();
    num1 = Convert.ToInt32(input);

    Console.WriteLine("Enter the second number:");
    input = Console.ReadLine();
    num2 = Convert.ToInt32(input);

    Console.WriteLine("Sum is: {0}", Sum(num1, num2));
    Console.ReadKey();
}     
static int Sum(int x, int y)
    {
        return x + y;
    }

}


