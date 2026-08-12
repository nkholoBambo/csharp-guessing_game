/*
 This is a simple number guessing game where the player tries to guess a randomly generated number between 1 and 100.
*/
Random attempt = new();
int target = attempt.Next(1,101);
Console.WriteLine("Welcome to the Losman Guessing game!");
Console.WriteLine("The objective of this game is to guess the number that the computer has randomly generated between 1 and 100."); 
Console.WriteLine("You have 10 attempts to guess the correct number. All the best!");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Attempt {i + 1} of 10:");
    Console.WriteLine("Please enter your guess: ");
    int userGuess = Convert.ToInt32(Console.ReadLine());

    if (userGuess < target)
    {
        Console.WriteLine("Your guess is too low. Try again.");
    }
    else if (userGuess > target)
    {
        Console.WriteLine("Your guess is too high. Try again.");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the correct number!");
        break;
    }

    if (i == 9)
    {
        Console.WriteLine($"Sorry, you've used all your attempts. The correct number was {target}.");
    }

    if (userGuess > 100 || userGuess < 1)
    {
        Console.WriteLine("Please enter a number between 1 and 100.");
    }
}