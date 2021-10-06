using System;

int points = 0;

Console.WriteLine("Hej jag ska ge dig en frågesport men först behöver jag ditt namn");
string name = Console.ReadLine();
Console.WriteLine($"Hej {name} nu ska jag ge dig den första frågan");
Console.WriteLine("Fråga 1. Om jag har 5 äpplen och tar bort två hur många har jag kvar?");
Console.WriteLine("a) 3");
Console.WriteLine("b) 2");
Console.WriteLine("c) 4");
string a1 = Console.ReadLine().ToLower();
if (a1 == "a")
{
    // input = Console.ReadLine().ToLower();
    points += 1;
}
Console.WriteLine("Bra nästa fråga");
Console.WriteLine("Fråga 2. När blev Donald Trump president");
Console.WriteLine("a) 2014");
Console.WriteLine("b) 2016");
Console.WriteLine("c) 2018");
a1 = Console.ReadLine().ToLower();

if (a1 == "b")
{
    //input = Console.ReadLine().ToLower();
    points = points + 1;
}
Console.WriteLine("väldigt bra nästa fråga");
Console.WriteLine("Fråga 3. Vem skapade låten Never gonna give you up");
Console.WriteLine("a) James Corden");
Console.WriteLine("b) Rick Astley");
Console.WriteLine("c) Benjamin Ingrosso");
a1 = Console.ReadLine().ToLower();

if (a1 == "b")
{
    //input = Console.ReadLine().ToLower();
    points += 1;
}
Console.WriteLine($"Hej {name} Grattis du har svarat på alla mina frågor");
Console.WriteLine($"Du har fått {points} Tack att du har gjort min frågesport");
Console.ReadLine();