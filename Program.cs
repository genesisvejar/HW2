// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            ourAnimals[i, 0] = "dog";
            ourAnimals[i, 1] = "d1";
            ourAnimals[i, 2] = "2";
            ourAnimals[i, 3] = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            ourAnimals[i, 4] = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            ourAnimals[i, 5] = "lola";
            break;

        case 1:
            ourAnimals[i, 0] = "dog";
            ourAnimals[i, 1] = "d2";
            ourAnimals[i, 2] = "9";
            ourAnimals[i, 3] = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            ourAnimals[i, 4] = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            ourAnimals[i, 5] = "loki";
            break;

        case 2:
            ourAnimals[i, 0] = "cat";
            ourAnimals[i, 1] = "c3";
            ourAnimals[i, 2] = "1";
            ourAnimals[i, 3] = "small whiteemale weighing about 8 pounds. litter box trained.";
            ourAnimals[i, 4] = "friendly";
            ourAnimals[i, 5] = "Puss";
            break;

        case 3:
            ourAnimals[i, 0] = "cat";
            ourAnimals[i, 1] = "c4";
            ourAnimals[i, 2] = "?";
            ourAnimals[i, 3] = "";
            ourAnimals[i, 4] = "";
            ourAnimals[i, 5] = "";
            break;

        default:
            ourAnimals[i, 0] = "";
            ourAnimals[i, 1] = "";
            ourAnimals[i, 2] = "";
            ourAnimals[i, 3] = "";
            ourAnimals[i, 4] = "";
            ourAnimals[i, 5] = "";
            break;

    }

}
// display the top-level menu options

do
{

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine("1. List all of our current pet information");
    Console.WriteLine("2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine("3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine("5. Edit an animal's age");
    Console.WriteLine("6. Edit an animal's personality description");
    Console.WriteLine("7. Display all cats with a specified characteristic");
    Console.WriteLine("8. Display all dogs with a specified characteristic");
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    menuSelection = Console.ReadLine();

    Console.WriteLine($"You have selected menu option {menuSelection}");
    Console.WriteLine("Press Enter to continue");
    
    // pause code execution
    Console.ReadLine();
}
while (menuSelection != "exit" && menuSelection != "Exit" && menuSelection != "EXIT"){ 
switch (menuSelection)
{   case "1":
       // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "2":
        // Add a new animal friend to the ourAnimals array
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "3":
        // Ensure animal ages and physical descriptions are complete
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "4":
        // Ensure animal nicknames and personality descriptions are complete
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "5":
        // Edit an animal's age
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "6":
        // Edit an animal's personality description
       Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "7":
        // Display all cats with a specified characteristic
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "8":
        // Display all dogs with a specified characteristic
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    default:
        //Exit the program
        break;
}

}
;
