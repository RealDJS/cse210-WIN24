// Sandbox

class Program
{
    static void Main(string[] args)
    {
        SmartLight light = new SmartLight("light");
        light.SetPower(true);
        Thread.Sleep(1000);
        Console.Write($"{light.GetTimeOn()}");
    }
}