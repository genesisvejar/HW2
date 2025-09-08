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
            ourAnimals [i, 4] = "friendly";
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