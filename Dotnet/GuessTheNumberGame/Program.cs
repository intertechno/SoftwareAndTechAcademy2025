Console.WriteLine("Welcome to the Number Guessing game!");

// calculate a randon number between 1 and 20
int correct = Random.Shared.Next(1, 21);
Console.WriteLine(correct);

// give the player three attempts
for (int attempt = 0; attempt < 3; attempt++)
{
    // ask the user for the guess
    Console.WriteLine("Please enter a guess between 1 and 20:");
    string input = Console.ReadLine() ?? "";
    int guess = int.Parse(input);

    // did the user guess correctly?
    if (guess == correct)
    {
        Console.WriteLine("Correct, you won the game!");
        break;
    }
    else if (guess < correct)
    {
        Console.WriteLine("Not quite, it is larger!");
    }
    else
    {
        Console.WriteLine("Not quite, it is smaller!");
    }
}

Console.WriteLine("Game ends.");
