const int numQuestions = 10;
const int minNumber = -10;
const int maxNumber = 10;

var rng = new Random(DateTime.Now.Millisecond);
var score = 0;

Console.WriteLine("Welcome to my first game!");
Console.WriteLine();

for (var i = 1; i <= numQuestions; i++)
{
    var a = rng.Next(minNumber, maxNumber);
    var b = rng.Next(minNumber, maxNumber);

    Console.WriteLine();
    Console.WriteLine($"Question {i}) What is: {a} + {b}");

    Console.WriteLine();
    Console.Write("What's your answer? ");

    if (int.TryParse(Console.ReadLine(), out int result) && result == a + b)
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }
}

Console.WriteLine();
Console.WriteLine($"Your final score is {score} out of {numQuestions}!");
Console.WriteLine();