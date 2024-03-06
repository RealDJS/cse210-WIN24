// ICE Smarthome
// Dennis Skoy
// Mar 2024

// SmartDevice class

abstract class SmartDevice
{
    // Attributes
    protected string name;
    protected bool powerOn;
    protected DateTime timeTurnedOn;
    protected SmartDevice(string name) { this.name = name; }


    // Getters
    public string GetName() { return name; }
    public bool GetPower() { return powerOn; }
    public double GetTimeOn()
    {
        if (!powerOn) { return 0; }
        return (int)(DateTime.Now - timeTurnedOn).TotalSeconds;
    }


    // Setters
    public void SetPower(bool power)
    {
        if (this.powerOn != power)
        {
            this.powerOn = power;//sets powerOn bool
            if (power) { timeTurnedOn = DateTime.Now; };//if changed from false to true, sets timeTurnedOn
        }
    }
}