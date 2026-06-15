/* ==================  Challenge             Arrow Factories                      100 XP ====================
Vin Fletcher sometimes makes custom-ordered arrows, but these are rare.
Most of the time, he sells one of the following standard arrows:

   • The Elite Arrow, made from a steel arrowhead, plastic fletching, and a 95 cm shaft.
   • The Beginner Arrow, made from a wood arrowhead, goose feathers, and a 75 cm shaft.
   • The Marksman Arrow, made from a steel arrowhead, goose feathers, and a 65 cm shaft.

   You can make static methods to make these specific variations of arrows easy.

Objectives:
   • Modify your Arrow class one final time to include static methods of the form public static
     Arrow CreateEliteArrow() { ... } for each of the three above arrow types.

   • Modify the program to allow users to choose one of these pre-defined types or a custom arrow. If
     they select one of the predefined styles, produce an Arrow instance using one of the new static
     methods. If they choose to make a custom arrow, use your earlier code to get their custom data
     about the desired arrow.

 */

Console.Title = "Level 21 - 028.Arrow Factories";


DisplayMenu();
Arrow first = CreateArrowType();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"That arrow costs {first.GetCost()} gold.");
Console.ResetColor();

//================================== Methods and Other ==============================================
void DisplayMenu()
{
    Console.WriteLine("""
                      ==================================================
                                    VIN FLETCHER'S ARROWS
                      ==================================================
                      "A tiny fragment of my soul goes into each arrow.
                       I care not for the money; I just need to recoup
                       my costs and get food on the table."
                      ==================================================
                      """);
}

//------------------------------------------------------------------------------------------------

Arrow CreateArrowType()
{
    Console.WriteLine("""
                      Would you like to buy: 
                      1.The Beginner Arrow - (wood arrowhead, goose feathers, and a 75 cm shaft)
                      2.The Marksman Arrow - (steel arrowhead, goose feathers, and a 65 cm shaft)
                      3.The Elite Arrow - (steel arrowhead, plastic fletching, and a 95 cm shaft)
                      ----------- OR ------------
                      4.The Custom Arrow."

                      """ + "\nChoice: ");
    int choice;

    while (true)
    {
        choice = Convert.ToInt32(Console.ReadLine());
        Arrow response = choice switch
        {
            1 => Arrow.CreateBeginnerArrow(),
            2 => Arrow.CreateMarksmanArrow(),
            3 => Arrow.CreateEliteArrow(),
            4 => CreateCustomArrow(),
            _ => null
        };
        if (response != null)
        {
            return response;
        }

        Console.WriteLine("Invalid choice. Please try again!\n");
    }
}

Arrow CreateCustomArrow()
{
    Console.WriteLine("------------- CUSTOM ARROW BUILDER ---------------");
    Arrowhead chosenArrowhead = GetArrowhead();
    Fletching chosenFletching = GetFletching();
    int chosenArrowLength = GetArrowLength();

    return new Arrow(chosenArrowhead, chosenFletching, chosenArrowLength);

    //==================== Local Functions/Methods ============================
    //-------------------------------------------------------------------------
    // Method to get the user's choice of arrowhead and return the corresponding Arrowhead enum value.
    Arrowhead GetArrowhead()
    {
        Arrowhead arrowhead;
        int choice;
        while (true)
        {
            Console.WriteLine("""
                              --- Choose your Arrowhead ---
                              1. Steel (10 gold)
                              2. Wood (3 gold)
                              3. Obsidian (5 gold)
                              """ + "\n");
            choice = Convert.ToInt32(Console.ReadLine());
            arrowhead = choice switch
            {
                1 => Arrowhead.Steel,
                2 => Arrowhead.Wood,
                3 => Arrowhead.Obsidian,
                _ => Arrowhead.Unknown,
            };

            if (arrowhead != Arrowhead.Unknown)
            {
                Console.Clear();
                DisplayMenu();
                break;
            }
            else
            {
                Console.WriteLine("Wrong choice, try again!\r");
            }
        }

        return arrowhead;
    }

    //-------------------------------------------------------------------------
    // Method to get the user's choice of fletching and return the corresponding Fletching enum value.
    Fletching GetFletching()
    {
        Fletching fletching;
        int choice;
        while (true)
        {
            Console.Write("""
                          --- Choose your Fletching ---
                          1. Plastic (10 gold)
                          2. Turkey Feathers (5 gold)
                          3. Goose Feathers (3 gold)
                          """ + "\n");

            choice = Convert.ToInt32(Console.ReadLine());
            fletching = choice switch
            {
                1 => Fletching.Plastic,
                2 => Fletching.TurkeyFeathers,
                3 => Fletching.GooseFeathers,
                _ => Fletching.Unknown,
            };

            if (fletching != Fletching.Unknown)
            {
                Console.Clear();
                DisplayMenu();
                break;
            }
            else
            {
                Console.WriteLine("Wrong choice, try again!\r");
            }
        }

        return fletching;
    }

    //-------------------------------------------------------------------------
    // Method to get the user's desired shaft length for the arrow,
    // ensuring it is within the valid range of 60 to 100 cm.
    int GetArrowLength()
    {
        int arrowLength;
        int choice;
        while (true)
        {
            Console.Write("""
                          --- Choose your Shaft Length ---
                          Length must be between 60cm and 100cm.
                          (Cost: 0.05 gold per cm)
                          """ + "\n");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice <= 100 && choice >= 60)
            {
                arrowLength = choice;
                Console.Clear();
                DisplayMenu();
                break;
            }
            else
            {
                Console.WriteLine("Out of range, try again!\r");
            }
        }

        return arrowLength;
    }
}

//---------------------------------Arrow Class File with essentials-----------------
//-------------------------- Enums --------------------------
// Enums to represent the different types of arrowheads and fletchings available for an arrow.
internal enum Arrowhead
{
    Unknown,
    Steel,
    Wood,
    Obsidian
};

internal enum Fletching
{
    Unknown,
    Plastic,
    TurkeyFeathers,
    GooseFeathers
};
//-------------------------- End Enums --------------------------

//-------------------------- Class Arrow --------------------------
// Class representing an arrow with properties for its arrowhead, fletching, and shaft length.
// The cost of the arrow can be calculated based on these properties.

// The class provides constructors to create an arrow with default values or specified values.
// Only at the time of creation with initializers or constructors can the properties be set,
// ensuring that the arrow's characteristics remain consistent after creation.
internal class Arrow
{
    private Arrowhead Arrowhead { get; init; }
    private Fletching Fletching { get; init; }
    private int ShaftLength { get; init; }

    //Constructors
    public Arrow() : this(Arrowhead.Steel, Fletching.Plastic, 60)
    {
    }

    public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        if (length <= 100 && length >= 60)
        {
            ShaftLength = length;
        }
        else
        {
            ShaftLength = 60;
        }
    }

    //--------------------------------------------------
    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
    }

    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
    }

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
    }

    // Method to calculate the cost of the arrow based on its components.
    public float GetCost()
    {
        float cost;
        cost = Arrowhead switch
        {
            Arrowhead.Steel => 10f,
            Arrowhead.Wood => 3f,
            Arrowhead.Obsidian => 5f,
            _ => 0f
        };

        cost += Fletching switch
        {
            Fletching.Plastic => 10f,
            Fletching.TurkeyFeathers => 5f,
            Fletching.GooseFeathers => 3f,
            _ => 0f
        };

        cost += (0.05f * ShaftLength);

        return cost;
    }
}