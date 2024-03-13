// ICE Smarthome
// Dennis Skoy
// Mar 2024

// Room Class

class Room
{
    // Attributes
    private List<SmartDevice> devices;

    // Constructor
    public Room() { this.devices = new List<SmartDevice>(); }


    // Member Methods
    /** AddDevice: adds SmartDevices to devices */
    private void AddDevice(SmartDevice device) { devices.Add(device); }
    public void AddSmartTV(string name) { AddDevice(new SmartTV(name)); }//adds SmartTV
    public void AddSmartHeater(string name) { AddDevice(new SmartHeater(name)); }//adds SmartHeater
    public void AddSmartLight(string name) { AddDevice(new SmartLight(name)); }//addsSmartLight


    /** IterateThroughDevices: goes through every item on devices */
    private void IterateThroughDevices(Action<SmartDevice> action)
    { foreach (var i in devices) { action(i); } }


    /** TurnOnLights: sets all SmartLights to true */
    public void TurnOnLights()
    { IterateThroughDevices(i => { if (i is SmartLight) { i.SetPower(true); } }); }


    /** TurnOnOffDevice: sets any SmartDevice powerOn values */
    private void TurnOnOffDevice(string name, bool powerOn)
    {
        var device = devices.FirstOrDefault(d => d.GetName().Equals(name, StringComparison.CurrentCultureIgnoreCase));// returns first item to match the string name
        if (device != null) { device.SetPower(powerOn); }// turns on if device was found
        else { Console.WriteLine("Device not found"); };
    }
    public void TurnOnDevice(string name) { TurnOnOffDevice(name, true); }//turn on
    public void TurnOffDevice(string name) { TurnOnOffDevice(name, false); }// turn off


    /** TurnOnOffRoomDevices: sets all SmartDevices powerON values */
    public void TurnOnOffDevices(bool power) { IterateThroughDevices(i => { i.SetPower(power); }); }


    /** DisplayItemStatus: displays item name and powerOn status */
    public void DisplayItemStatus()
    { IterateThroughDevices(i => { Console.WriteLine($"{i.GetName()}: {i.GetPower()}"); }); }


    /** DisplayDevicesOn: displays devices with powerON true */
    public void DisplayDevicesOn()
    { IterateThroughDevices(i => { if (i.GetPower()) Console.WriteLine($"{i.GetName()}"); }); }



    /** DisplayItemOnLongest: displays which item was on the longest */
    public void DisplayItemOnLongest()
    {
        SmartDevice deviceOnLongest = null;
        double longestTimeOn = -1;
        IterateThroughDevices(i =>// for current item:
        {
            if (i.GetPower())// if item is on:
            {
                double timeOn = i.GetTimeOn();// get time its been on
                if (timeOn > longestTimeOn)// replaces deviceOnLongest if it has been on longer 
                { longestTimeOn = timeOn; deviceOnLongest = i; }
            }
        });
        if (deviceOnLongest != null)// if the longest was found:
        { Console.WriteLine($"{deviceOnLongest.GetName()} is on the longest"); }// names longest
        else { Console.WriteLine("No devices on"); }// if no devices are on
    }
}