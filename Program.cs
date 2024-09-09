// dataset
List<int> numbers = [17, 166, 288, 324, 531, 792, 946, 157, 276, 441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227, 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396, 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784, 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450, 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150];



//Basic Search Function
void BasicSearch ()
{
    // After selecting "Basic Search":
    Console.WriteLine("\n### Basic Search ###");

    bool isValid = false;
    int basicNum = 0;

    while (!isValid)
    {
        // The application should prompt the user for an integer
        Console.Write($"\nEnter an integer to search: ");
        string? basicInput = Console.ReadLine();

        // The application should check that the user provided an integer
        if (string.IsNullOrEmpty(basicInput) || !int.TryParse(basicInput, out basicNum))
        {
            Console.WriteLine("Not a valid integer. Try again.");
            continue;
        }

        isValid = true;
    }

    // The application should search the collection of numbers for the provided number and return the results of the search. 
    int basicIndex = numbers.FindIndex(num => num == basicNum);

    // If found, the index of the number should also be displayed. 
    if (basicIndex != -1)
    {
        Console.WriteLine($"\nThe integer is found at index {basicIndex}.");
    }
    else
    {
        Console.WriteLine("\nThe integer is not found.");
    }

    // The application should return to the operation prompt.  
}

void RangeSearch ()
{
    // After selecting "Range Search":
    Console.WriteLine("\n### Range Search ###");

    bool isValid = false;
    int lowerBound = 0;
    int upperBound = int.MaxValue;

    // The application should prompt the user for the lower bound of the range.
    while (!isValid)
    {
        Console.Write($"\nEnter the lower bound of the range: ");
        string? lowerInput = Console.ReadLine();
        

        // If the user enters nothing, the application should set the lower bound to 0.
        if (string.IsNullOrEmpty(lowerInput))
        {
            lowerBound = 0;
            isValid = true;
        }
        // If the user provides an input, the application should also check that the input is an integer.
        else if (!int.TryParse(lowerInput, out lowerBound))
        {
            Console.WriteLine("Not a valid integer. Try again.");
            continue;
        }

        isValid = true;
    }

    isValid = false;

    // The application should prompt the user for the upper bound of the range. 
    while (!isValid)
    {
        Console.Write($"\nEnter the upper bound of the range to search: ");
        string? upperInput = Console.ReadLine();
        

        // If the user enters nothing, the application should set the upper bound to the highest possible value.
        if (string.IsNullOrEmpty(upperInput))
        {
            upperBound = int.MaxValue;
            isValid = true;
        }
        // If the user provides an input, the application should also check that the input is an integer.
        else if (!int.TryParse(upperInput, out upperBound))
        {
            Console.WriteLine("Not a valid integer. Try again.");
            continue;
        }

        isValid = true;

        // The application should search the collection for any numbers that fall within the range of provided numbers 
        // and return the number of results found and a list of available numbers that meet the condition in ascending order. 

        var results = numbers.FindAll (num => num >= lowerBound && num <= upperBound);
        results.Sort();

        if (results.Count > 0)
        {
            Console.WriteLine($"\nThe search found {results.Count} integers in the range. They are [{string.Join(", ", results)}].");
        }
        else
        {
            Console.WriteLine($"\nNo numbers found in the range.");
        }

    }

}



// prompt the user to choose between three operations:  "Basic Search",  "Range Search", or "Exit". 
bool isActive = true;

while (isActive)
{
    bool isValid = false;

    while (!isValid)
    {
        Console.Write($"\nEnter the number to choose an operation (1 = Basic Search, 2 = Range Search, 3 = Exit): ");
        string? operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
            isValid = true;
            BasicSearch();
            break;

            case "2":
            isValid = true;
            RangeSearch ();
            break;

            case "3":
            isValid = true;
            isActive = false; // After selecting "Exit", the application should terminate. 
            Console.WriteLine("\n### Exited ###\n");
            break;
            
            default:
            Console.WriteLine("\nNot a valid action. Try again.");
            break;
        }
    }

}


