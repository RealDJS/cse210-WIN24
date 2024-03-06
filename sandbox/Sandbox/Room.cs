// ICE Smarthome
// Dennis Skoy
// Mar 2024

// Room Class

class Room
{
    private List<SmartDevice> devices;


    // Member Methods
    /** TurnOnLights */
    public void TurnOnLights() { foreach (SmartDevice i in devices) { if (i is SmartLight) { i.SetPower(true); } } }


    /** TurnOnOffDevice */
    public void TurnOnOffDevices() { foreach (SmartDevice i in devices) { i.SetPower(true); } }


    /** TurnOnOffRoomDevices */
    public void TurnOnOffDevices(bool power) { foreach (SmartDevice i in devices) { i.SetPower(power); } }


    /** DisplayItemStatus */
    public void DisplayItemStatus()
    { foreach (SmartDevice i in devices) { Console.WriteLine($"{i.GetName()}: {i.GetPower()}"); } }


    /** DisplayDevicesOn */
    public void DisplayDevicesOn()
    {
        foreach (SmartDevice i in devices)
        { if (i.GetPower()) Console.WriteLine($"{i.GetName()}"); }
    }


    /** DisplayItemOnLongest */
    public void DisplayItemOnLongest()
    {
        SmartDevice deviceOnLongest = null;
        double longestTimeOn = 0;
        foreach (SmartDevice i in devices)
        {
            if (deviceOnLongest.GetPower())
            {
                double timeOn = deviceOnLongest.GetTimeOn(); if (timeOn > longestTimeOn) { longestTimeOn = timeOn; deviceOnLongest = i; }
            }
        }

        if (deviceOnLongest != null)
        { Console.WriteLine($"{deviceOnLongest.GetName()} is on the longest"); }
        else { Console.WriteLine("No devices on"); }
    }
}