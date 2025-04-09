Console.WriteLine("Starting to read the numbers file...");
string[] lines = File.ReadAllLines("Numbers.txt");

int sum = 0;
int count = lines.Length;
foreach (string line in lines)
{
    int number = int.Parse(line);
    sum += number;
}

Console.WriteLine($"The sum of numbers in the file is: {sum}.");
double average = (double)sum / count;
Console.WriteLine($"The average of numbers in the file is: {average}.");
