// Nickname Generator Assignment by Jordan. A
#nullable disable
Console.Clear();

// Random Object
Random rnd = new Random();

// Loop
bool loop = true;

// Name strings
string firstName = "John";
string lastName = "Doe";
string nickName;

// Nickname Array
string[] nicknameArray = {
    "Crusher", 
    "the Scientist", 
    "Twinkle-toes", 
    "the Coder",
    "the Jester",
    "the Sloth",
    "Quick-Silver"
    };

// Nickname List
List<string> nicknameList = nicknameArray.ToList();

// Main loop
while (loop) 
{
    Console.WriteLine($"\nMAIN MENU ({firstName} {lastName})");
    Console.WriteLine("1. Change Name");
    Console.WriteLine("2. Display a Random Nickname");
    Console.WriteLine("3. Display All Nicknames");
    Console.WriteLine("4. Add a Nickname");
    Console.WriteLine("5. Remove a Nickname");
    Console.WriteLine("6. Exit");
    string option = Console.ReadLine();

    if (option == "1") 
    {
        Console.WriteLine("CHANGE NAME");
        Console.Write("Please enter first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine($"Current name is {firstName} {lastName}.");
    } 
    else if (option == "2") 
    {
        Console.WriteLine("RANDOM NICKNAME");
        int random = rnd.Next(0, nicknameList.Count);
        nickName =  nicknameList[random];
        Console.WriteLine($"{firstName} \"{nickName}\" {lastName}");
    } 
    else if (option == "3") 
    {
        Console.WriteLine("ALL NICKNAMES");
        for(int n = 0; n < nicknameList.Count; n++)
        {
            Console.WriteLine($"{firstName} \"{nicknameList[n]}\" {lastName}");
        }
    } 
    else if (option == "4") 
    {
        Console.WriteLine("ADD A NICKNAME");
        Console.Write("Please enter a nickname to add: ");
        string newNickname = Console.ReadLine();
        if (nicknameList.Contains(newNickname)) 
            {
                Console.WriteLine($"{newNickname} is already in the nickname list.");
            } 
        else
            {   
                nicknameList.Add(newNickname);
                Console.WriteLine($"{newNickname} added to the nickname list.");
            }
    }
     else if (option == "5") 
    {
        Console.WriteLine("REMOVE A NICKNAME");
        Console.Write("Please enter a nickname to remove: ");
        string delNickname = Console.ReadLine();
        if (nicknameList.Contains(delNickname)) 
            {
                nicknameList.Remove(delNickname);
                Console.WriteLine($"{delNickname} removed from the nickname list.");
            } 
        else
            {   
                Console.WriteLine($"{delNickname} was not found in the nickname list.");
            }
    }
     else if (option == "6") 
    {
        loop = false;
    } 
    else 
    {
        Console.WriteLine("INVALID ANSWER");
    }
}
