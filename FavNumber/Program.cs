Console.WriteLine("Enter a number between 1 and 100:");
var r = new Random();
var randomNumber = r.Next(1, 100);
var userInput = int.Parse(Console.ReadLine());
bool gameOver = false;

do
{

    if (userInput > randomNumber)
    {
        Console.WriteLine("Too High");
    }

    else if (userInput < randomNumber)
    {
        Console.WriteLine("Too Low");
    }

    else
    {
        Console.WriteLine("You got it! Good guess!");
    }
    break;
}

while (gameOver = true);
{
    Console.WriteLine("You lose, game over...");
}