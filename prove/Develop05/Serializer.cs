// Develop 05
// Dennis Skoy
// Mar 2024

// Serializer Class

using System.Text.Json;

public class Serializer
{
    // Attributes
    private string filename;


    // Constructor
    public Serializer(string filename) { this.filename = filename; }


    // Methods
    /** Serialize: writes to file*/
    public void Serialize(Goals goals)
    {
        string jsonString = JsonSerializer.Serialize(goals);//converts to json
        File.WriteAllText(filename, jsonString);//writes to file
    }


    /** Deserialize: reads from file*/
    public Goals Deserialize()
    {
        string jsonFromFile = File.ReadAllText(filename);//reads from file
        return JsonSerializer.Deserialize<Goals>(jsonFromFile);//converts to Goals object
    }
}