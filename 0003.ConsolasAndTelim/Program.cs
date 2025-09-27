// See https://aka.ms/new-console-template for more information


/* Making a small program to ask user to who bread is creating for. */

// Prompt the user for the name of the person the bread is being created for
Console.WriteLine("Who is this bread for?");

// Read the user's input and store it in a variable
string name = Console.ReadLine() ?? string.Empty;

// Display a message confirming the name entered
Console.WriteLine($"Bread is being created for {name}.");

