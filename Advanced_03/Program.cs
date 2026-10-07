
namespace Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //Console.WriteLine($"Grades Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades[0]}");
            //Console.WriteLine($"Last Grade: {grades[^1]}");

            //grades.Sort();
            //Helper.PrintList("Sorted Grades", grades);

            //Console.WriteLine($"First grade above 90: {grades.Find(n => n > 90)}");
            //List<int> failing = grades.FindAll(n => n < 75);
            //Helper.PrintList("Failing Grades", failing);
            //grades.RemoveAll(n => n < 75);
            //Helper.PrintList("Passing Grades", grades);

            //Console.WriteLine($"Has grade equals 100:  {grades.Contains(100)}");

            //List<string> formattedGrades = grades.Select(g => $"Grade: {g}").ToList();
            //Helper.PrintList("Formatted Grades", formattedGrades); 
            #endregion
            #region Exercise 2
            //SortedList<int, string> leaderboard = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}
            //Console.WriteLine($"First Key: {leaderboard.Keys[0]}, First Value: {leaderboard.Values[0]}");

            //Console.WriteLine($"500 Exists: {leaderboard.ContainsKey(500)}");
            //if (leaderboard.TryGetValue(999, out string? player))
            //{
            //    Console.WriteLine($"Player with score 999: {player}");
            //}
            //else
            //{
            //    Console.WriteLine("Score 999 not found in leaderboard.");
            //}
            //leaderboard.Remove(200);
            //Helper.PrintSortedList("Updated Leaderboard", leaderboard); 
            #endregion
            #region Exercise 3
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    ["Alice"] = "123-456-7890",
            //    ["Bob"] = "987-654-3210",
            //    ["Charlie"] = "555-555-5555"
            //};
            //phoneBook["John"] = "111-222-3333";
            //try
            //{
            //    phoneBook.Add("Alice", "123-456-7890");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error adding entry to phone book: {ex.Message}");
            //}
            //Console.WriteLine($"TryAdd result: {phoneBook.TryAdd("Alice", "123-456-7890")}");
            //if (phoneBook.TryGetValue("Hasona", out string? Number))
            //{
            //    Console.WriteLine($" number: {Number}");
            //}
            //else
            //{
            //    Console.WriteLine(" not found.");
            //}
            //Console.WriteLine($"phone book keys:  {string.Join(", ", phoneBook.Keys)}");
            //Console.WriteLine($"phone book values:  {string.Join(", ", phoneBook.Values)}");

            #endregion
        }
    }
}