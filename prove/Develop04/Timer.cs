// // Source Code for Develop04
// // Dennis Skoy
// // Last edit: Feb 2024

// // Timer Class

// public static class TimedUtility
// {
//     // Attributes



//     // Member Methods
//     public static void Loading(string message = "") { }


//     public static void MakeTimeFrame(int time, Action activity)
//     {
//         DateTime startTime = DateTime.Now;//Animation Start
//         DateTime endTime = startTime.AddSeconds(time);// Animation End
//         DateTime currentTime = DateTime.Now;
//         while (currentTime < endTime)// until time equals the activity's time limit
//         {
//             activity();
//             Thread.Sleep(1000);
//         }
//     }


//     private static int ConvertTime(int seconds) { return seconds * 1000; }
// }