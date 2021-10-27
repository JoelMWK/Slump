using System;
using System.IO;

Random generator = new Random();


int Hit = generator.Next(100);
int Damage = generator.Next(20, 40);
int Hp = 100;
int Hp2 = 100;
string answer = "";
string name = "";
string enemy = "";

string lostpath = "lost.txt";
string lost = File.ReadAllText(lostpath);

string wonpath = "won.txt";
string won = File.ReadAllText(wonpath);

string tiepath = "tie.txt";
string tie = File.ReadAllText(tiepath);


while (name == "")
{
    Console.WriteLine("Player 1 enter your name: ");
    name = Console.ReadLine();
}

while (answer != "1" && answer != "2" && answer != "3")
{
    Console.WriteLine("Choose your opponent");
    Console.WriteLine("Choose 1, 2 or 3");

    answer = Console.ReadLine();
}

if (answer == "1")
{
    enemy = "Mikael";
}
else if (answer == "2")
{
    enemy = "Tu";
}
else if (answer == "3")
{
    enemy = "Joel";
}


while (Hp > 0 && Hp2 > 0)
{

    Hit = generator.Next(100);
    Damage = generator.Next(20, 40);

    Console.WriteLine("\n" + enemy + " tries to hit you\n");
    if (Hit < 70)
    {

        Hp -= Damage;

        Console.WriteLine("-----------------------------");
        Console.WriteLine(name + " got hit");
        Console.WriteLine(name + " took " + Damage + " damage");
        Console.WriteLine(name + " has " + Hp + " health remaining");
        Console.WriteLine("-----------------------------");

        Console.ReadLine();

    }
    else
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine(name + " managed to dodge the hit");
        Console.WriteLine("-----------------------------\n");
        Console.ReadLine();
    }


    Hit = generator.Next(100);
    Damage = generator.Next(20, 40);

    Console.WriteLine(name + " your turn\n");

    Console.WriteLine(name + " try to hit " + enemy + "\n");
    if (Hit < 70)
    {

        Hp2 -= Damage;

        Console.WriteLine("-----------------------------");
        Console.WriteLine(name + " hit " + enemy);
        Console.WriteLine(enemy + " took " + Damage + " damage");
        Console.WriteLine(enemy + " has " + Hp2 + " health remaining");
        Console.WriteLine("-----------------------------");


        Console.ReadLine();

    }
    else
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine(enemy + " managed to dodge");
        Console.WriteLine("-----------------------------\n");
        Console.ReadLine();
    }

}

if (Hp <= 0 && Hp2 <= 0)
{

    Console.Clear();
    Console.WriteLine("It's a" + "\n" + tie);

}

else if (Hp <= 0)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(name + "\n" + lost + "\n");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(enemy + "\n" + won);
}
else if (Hp2 <= 0)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(enemy + "\n" + lost + "\n");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(name + "\n" + won);
}


Console.ReadLine();