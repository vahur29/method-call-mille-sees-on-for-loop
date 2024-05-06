namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Inside the for loop: " + i);
                AnotherMethod(i); 
            }
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello, world!");
        }
        static void AnotherMethod(int num)
        {
            Console.WriteLine("Another method called with: " + num);
        }
    }
}
