# csharp-guessing_game
Console application where the user tries to guess the generated random number

What it does:
-Generates a random target number between 1 and 100 using the .NET Random class
-Gives the player 10 attempts to guess it
-After each guess, tells the player whether their guess was too high, too low, or correct
-Displays the current attempt number (e.g. "Attempt 3 of 10")
-Warns the player if their guess falls outside the valid 1–100 range
-If all attempts are used without a correct guess, reveals the correct number

Tech used:
-C#
-.NET Console Application

How to run:
-Clone this repo
-Navigate to the project folder
-Run:
   dotnet run
-Enter a guess between 1 and 100 when prompted, repeat until correct or out of attempts

Concepts practiced:
-Calling a method from the .NET Class Library (Random.Next())
-for loops
-If / else-if / else conditional logic
-break to exit a loop early
-Basic input validation

Planned improvement:
Range validation currently runs after the too-high/too-low check, so an out-of-range guess can print both messages. A future revision will move the range check to run first, before any other guess logic.
