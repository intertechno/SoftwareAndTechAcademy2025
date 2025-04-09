using System.Text;

Console.WriteLine("Starting the string manipulation operation...");

DateTime start = DateTime.Now;
StringBuilder builder = new();
for (int i = 0; i < 500_000; i++)
{
    builder.Append('A');
}
string s = builder.ToString();
DateTime stop = DateTime.Now;
Console.WriteLine("String has been created.");

// DateTime start = DateTime.Now;
// string s = "";
// for (int i = 0; i < 500_000; i++)
// {
//     s += "A";
// }
// DateTime stop = DateTime.Now;
// Console.WriteLine("String has been created.");


TimeSpan timeTaken = stop - start;
Console.WriteLine($"Operation took {timeTaken.TotalSeconds:0.000} seconds.");
