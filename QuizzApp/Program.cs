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

Console.WriteLine("Let's play a quitz game, if you're ready type \'y', if you're not type \'n'");
startGame = Console.ReadKey().KeyChar;

if(startGame == 'n')
{
    Console.WriteLine("\nWell let's play when you'll be ready!!!");
} else if(startGame == 'y')
{
    Console.WriteLine("\nAllright, let's begin!");
    Console.WriteLine("\n" + question1);
    int userNumberAnswer = int.Parse(Console.ReadLine());
    string userStringAnswer;
    if (userNumberAnswer == answer1)
        score++;
    Console.WriteLine("\n" + question2);
    userNumberAnswer = int.Parse(Console.ReadLine());
    if (userNumberAnswer == answer2)
        score++;
    Console.WriteLine("\n" + question3);
    userStringAnswer = Console.ReadLine();
    if (userStringAnswer == answer3)
        score++;
    Console.WriteLine("\n" + question4);
    userStringAnswer = Console.ReadLine();
    if (userStringAnswer == answer4)
        score++;

} else
    Console.WriteLine("/nSorry wrong input type \'y', if you're ready or \'n' if you're not");

Console.WriteLine("\n" + score);

Console.ReadKey();