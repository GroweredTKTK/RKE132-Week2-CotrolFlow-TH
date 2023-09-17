// See https://aka.ms/new-console-template for more information

//rakendus kusib kasutajal valida tema sugu (m/f)
//rakendus kusib kasutajalt sisestada tema perekonnanime
//lahtudes kasutaja valikust, rakendus tervitab kasutajat jargmiselt:
//"Welcome, Mr. [kas. perekonnanimi]" / "welcome, Ms. [kas. perekonnanimi]"

Console.WriteLine("Please select your gender (m/f)");
char UserGender = char.Parse(Console.ReadLine());

Console.WriteLine("Please enter your name: ");
string UserLastName = Console.ReadLine();

if (UserGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserLastName}!");
}
else if (UserGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {UserLastName}!");
}