// Develop 05
// Dennis Skoy
// Mar 2024

// Serializer Class

using System.Text.Json;

public class Serializer
{
    // Attributess
    private string filename;


    // Constructor
    public Serializer() { this.filename = "goals.json"; }
    public Serializer(string filename) { this.filename = filename; }


    // Methods
    /** Serialize: writes to file*/
    private void Serialize<T>(T data, string filename)
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filename, jsonString);
        }
        catch (Exception ex) { Console.WriteLine($"An error occurred during serialization: {ex.Message}"); }
    }


    /** SerializeTypes: serializes different types of goals*/
    public void SerializeTypes(Goals goals)
    {
        var simpleGoals = goals.GoalsList.OfType<Simple>().ToList();
        Serialize(simpleGoals, "simpleGoals.json");
        var eternalGoals = goals.GoalsList.OfType<Eternal>().ToList();
        Serialize(eternalGoals, "eternalGoals.json");
        var checklistGoals = goals.GoalsList.OfType<Checklist>().ToList();
        Serialize(checklistGoals, "checklistGoals.json");
        Console.WriteLine("Data saved successfully.");
    }


    /** Deserialize: reads from file*/
    public T Deserialize<T>(string filename)
    {
        try
        {
            string jsonFromFile = File.ReadAllText(filename);//reads from file
            return JsonSerializer.Deserialize<T>(jsonFromFile);//converts to Goals object
        }
        catch (Exception ex)//catches errors
        { Console.WriteLine($"An error occurred during deserialization: {ex.Message}"); return default; }
    }

    public List<Simple> DeserializeSimple() { return Deserialize<List<Simple>>("simpleGoals.json"); }//gets Simple Goals from files

    public List<Eternal> DeserializeEternal() { return Deserialize<List<Eternal>>("eternalGoals.json"); }//gets Eternal Goals from files

    public List<Checklist> DeserializeChecklist() { return Deserialize<List<Checklist>>("checklistGoals.json"); }//gets Checklist Goals from files
}