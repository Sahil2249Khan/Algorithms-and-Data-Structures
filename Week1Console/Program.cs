class Program
{
    static void Main(string[] args)
    {
        PrintMessage("Hello, World!");
    }
    
    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }


}