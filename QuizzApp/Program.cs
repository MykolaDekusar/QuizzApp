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

} else
    Console.WriteLine("\nSorry wrong input type \'y', if you're ready or \'n' if you're not");

Console.ReadKey();