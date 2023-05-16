using System;

/*/ int points = 100;
string name = "Micke";

string t = "20";
/*/
// Console.Writeline(t + 90);

System.Console.WriteLine(int.MaxValue);

System.Console.WriteLine("Skriv in ett tal:");

string tal = Console.ReadLine();
int resultat;

// resultat = int.Parse(tal);

bool success = int.TryParse(tal, out resultat);

if (success == true)
{
    System.Console.WriteLine(resultat * 2);
}
else
{
    System.Console.WriteLine("Är du dum i huvudet?");
}

// int talNum = tal;

Console.ReadLine();
