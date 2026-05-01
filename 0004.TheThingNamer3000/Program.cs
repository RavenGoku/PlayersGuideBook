// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // store Thing variable 

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // store type of thing 

string c = "of Doom"; /* store string literal */
string d = "3000"; /* store string literal number */

Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
