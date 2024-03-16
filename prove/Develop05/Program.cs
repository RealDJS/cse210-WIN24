using System;

class Program
{
    static void Main(string[] args)//write separate JSON files for each goal type
    {
        Goals goals = new Goals(new List<Goal>());
        EternalQuestMenu.UseMenu(goals);
    }
}