//Objective: create questions with relative answers, if the user answers correctly add a point, show the final result
string question1 = "How many months are is a year?";
string question2 = "How many fingers are in a hand?";
string question3 = "If you close your eyes what do you see?";
string question4 = "What is the fastest running animal on earth?";
int answer1 = 12;
int answer2 = 5;
string answer3 = "Nothing";
string answer4 = "Ghepard";

//Let's set the global score

int score = 0;

char startGame;

Console.WriteLine("Let's play a quitz game, if you're ready type \'y', if you're not type \'n'\n");
startGame = Console.ReadKey().KeyChar;

if(startGame == 'n')
{
    Console.WriteLine("\n\nWell let's play when you'll be ready!!!");
} else if(startGame == 'y')
{
    Console.WriteLine("\n\nAllright, let's begin!");
    Console.WriteLine("\n" + question1 + "\n");
    int userNumberAnswer = int.Parse(Console.ReadLine());
    string userStringAnswer;
    if (userNumberAnswer == answer1)
        score++;
    Console.WriteLine("\n" + question2 + "\n");
    userNumberAnswer = int.Parse(Console.ReadLine());
    if (userNumberAnswer == answer2)
        score++;
    Console.WriteLine("\n" + question3 + "\n");
    userStringAnswer = Console.ReadLine();
    if (userStringAnswer == answer3)
        score++;
    Console.WriteLine("\n" + question4 + "\n");
    userStringAnswer = Console.ReadLine();
    if (userStringAnswer == answer4)
        score++;
    //Answer based on score
    switch (score)
    {
        case 0:
            Console.WriteLine($"\nYou got {score} out of 4, you need to study some more");
            break;
        case 1:
            Console.WriteLine($"\nYou got {score} out of 4, you're getting smarter");
            break;
        case 2:
            Console.WriteLine($"\nYou got {score} out of 4, you're half way there");
            break;
        case 3:
            Console.WriteLine($"\nYou got {score} out of 4, really nice");
            break;
        case 4:
            Console.WriteLine($"\nYou got {score} out of 4, you're super smart!!!");
            break;
    }

} else
    Console.WriteLine("\n\nSorry wrong input type \'y', if you're ready or \'n' if you're not");

Console.ReadKey();