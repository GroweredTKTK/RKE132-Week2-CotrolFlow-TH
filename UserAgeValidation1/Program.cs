using System.Reflection.Metadata;

Console.WriteLine("Enter your age: ");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = int.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");   
    }
}
else
{
    Console.WriteLine("Could not read you age.");
}

