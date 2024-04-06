public class Program
{
    static void Main()
    {
        Welcome();
    }
    static void Welcome()
    {
        Console.Clear();
        Console.WriteLine("WELCOME TO SNOW EXPERIENCE");
        Thread.Sleep(2000);
        Console.Clear();
        // string[] snow = File.ReadAllLines("snowWelcome.txt"); 
        // Console.WriteLine($"{snow}");
        if (File.Exists("snowWelcome.txt"))
        {
            string[] snow = File.ReadAllLines("snowWelcome.txt");
            Console.WriteLine(snow);
            foreach(var i in snow){
                Console.WriteLine(i);
            }
        }
        Thread.Sleep(2000);
    }
}