// Sandbox

class Program
{
    static void Main(string[] args)
    {
        House house = new House();
        Room room = new Room();
        house.AddRoom(room);

        room.AddSmartTV("Big TV");
        room.AddSmartLight("Light1");
        room.AddSmartLight("Light2");
        room.AddSmartHeater("Heater");

        Thread.Sleep(1000);
        Thread.Sleep(1000);
        room.TurnOnLights();
        Thread.Sleep(1000);
        room.TurnOnOffDevices(true);
        Thread.Sleep(1000);
        room.TurnOnDevice("Heater");

        Console.WriteLine("Devices on");
        room.DisplayDevicesOn();
        room.TurnOffDevice("Light1");

        Console.WriteLine("\nItem on the Longest: ");
        room.DisplayItemOnLongest();
    }
}