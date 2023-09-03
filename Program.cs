bool isCompOn = true;

while (isCompOn == true)
{
    Console.WriteLine("Type yes is computer is on, Type no is not");
    string userInput = Console.ReadLine();

    if (userInput == "yes")
    {
        Console.WriteLine("Correcto mundo!");
        isCompOn = false;
    }
    else
    {
        Console.WriteLine("Try again");
    }
}
