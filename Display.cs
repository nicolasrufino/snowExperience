public static class Messages 
{
    public static void Welcome()
    {
        Console.Clear();
        Console.WriteLine("WELCOME TO SNOW EXPERIENCE");
        Thread.Sleep(2000);
        Console.Clear();
        // string[] snow = File.ReadAllLines("snowWelcome.txt"); 
        // Console.WriteLine($"{snow}");
        string path = "snowWelcome.txt";
        if (File.Exists(path))
        {
            string[] snow = File.ReadAllLines(path);
            // Console.WriteLine(snow);
            foreach(var i in snow){
                Console.WriteLine(i);
            }
        }
        Thread.Sleep(2000);
    }
}