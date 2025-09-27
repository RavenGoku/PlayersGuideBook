// See https://aka.ms/new-console-template for more information


//int playerNumbers = -1;

//Console.WriteLine("================ while Loop ================");
//// while loop:
////  Condition is checked BEFORE each run.
////  This loop keeps asking until user gives a number between 0 and 10.
//while (playerNumbers < 0 || playerNumbers > 10)
//{
//    Console.WriteLine("Enter a number between 0 and 10: ");
//    string playerResponse = Console.ReadLine();
//    playerNumbers = Convert.ToInt32(playerResponse);
//};

//Console.WriteLine("================ do - while Loop ================");
//// do-while loop:
////  Condition is checked AFTER the body runs.
////  This guarantees the loop runs at least once.
//do
//{
//    Console.WriteLine("Enter a number between 0 and 10: ");
//    string playerResponse = Console.ReadLine();
//    playerNumbers = Convert.ToInt32(playerResponse);
//}
//while (playerNumbers < 0 || playerNumbers > 10);

//Console.WriteLine("================ for Loop ================");
//// for loop:
////  Best for counting or repeating something a known number of times.
////  Here it prints numbers 1 through 5.
//for (int x = 1; x <= 5; x++)
//{
//    Console.WriteLine(x);
//};

//Console.WriteLine("================ 'break' and 'continue'  ================");
//// while(true) with break/continue:
////  Creates an "infinite" loop.
////  break = exit loop completely
////  continue = skip current iteration and go back to top
//while (true)
//{
//    Console.Write("Think of a number and type it here: ");
//    string input = Console.ReadLine();

//    // if user types "quit" or "exit", stop the loop entirely
//    if (input == "quit" || input == "exit")
//    {
//        break;
//    }

//    int number = Convert.ToInt32(input);

//    // if number is 12, skip rest of the code and restart loop
//    if (number == 12)
//    {
//        Console.WriteLine("I don't like that number. Pick another one.");
//        continue;
//    }

//    // normal case: show message about the number
//    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
//};

Console.WriteLine("================ Nesting Loops  ================");
int totalRows = 5;
int totalColumns = 10;

for (int currentRow = 1; currentRow <= totalRows; currentRow++)
{
    for(int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
