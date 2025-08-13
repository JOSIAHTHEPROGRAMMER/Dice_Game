// See https://aka.ms/new-console-template for more information

int length, n1, n2, c1 = 0,c2 = 0;
Console.WriteLine("Hello, Welcome to this simple dice game!!\n");

string? player1, player2;

Console.WriteLine("Enter the name of Player 1:");
player1 = Console.ReadLine();

Console.WriteLine("\nEnter the name of Player 2");
player2 = Console.ReadLine();







Console.WriteLine("\nEnter the number of rounds you wish to play: ");
length = Convert.ToInt32(Console.ReadLine());


Random rand = new Random();

string? winner = "";

for (int i = 0; i < length; i++)
{
    Console.WriteLine("\nOk " + player1 +  ", press any button to roll a dice! (1-6)");
    Console.ReadKey();

    n1 = rand.Next(1, 6+1);

    Console.WriteLine("\nOk " + player2 + ", press any button to roll a dice! (1-6)");
    Console.ReadKey();

    n2 = rand.Next(1, 6+1);

    Console.WriteLine($"\n{player1} rolled {n1}\n{player2} rolled {n2}\n\n");
   


    if (n1 == n2)


    {
        winner = "Nobody";

    }
    else if (n1 > n2)
    {

        winner = player1;
        c1++;
    }
    else if (n1 < n2)
    {
        winner = player2;
        c2++;
    }

    Console.WriteLine(winner + " won this round\n");
    Console.WriteLine($"\n{player1} score: {c1} | {player2} score: {c2}\n");



}



if (c1 > c2)
{
    winner = player1;
}
else if (c1 < c2)
{
    winner = player2;
}

else winner = "Nobody";

Console.WriteLine(winner + " won this game!!\nCongrats :)");

Console.WriteLine("\n\nThank you for playing!");

Console.ReadKey();
