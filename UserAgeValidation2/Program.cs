// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"you are too young to use instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("enter your age:");
//int userAge = Int32. Parse (Console.ReadLine()); // kui see oleks sõne ehk "13" -heap, 13- stack

string userAge = Console.ReadLine();
int userAgeNum = 0;

//boolean- true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old");

if (isAgeNumber ==true)
{
    if (userAgeNum >= 13)

    {
        Console.WriteLine("Welcome to instagram!");
    }

    else {
        Console.WriteLine("you are too young to use instagram");
    }
} 
else
{
    Console.WriteLine("Could not read your age.");
}