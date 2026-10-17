
// 0. Avvio & Librerie 
using System;



// 1. Variables
 string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
 string SpecialChars = "!#-_().";
 string Numbers = "0123456789";



// 2. FrontEnd 
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(" // Password Generator // V.1.0 //");
Console.ResetColor();

Console.WriteLine("What's your name?");
  string PlayerName = Console.ReadLine() ?? "_"; // legge l'input dell'utente
Console.WriteLine($"Hello {PlayerName}, How long you want ur password to be? (min 8, max 32)");



// 3. Password Options
// --------------------------------------------------
// 3.1 Password Lenght
int lenght;
while(!int.TryParse(Console.ReadLine(), out lenght) || lenght < 8 || lenght > 32) // controlla se l'input è un numero fra 8 e 32 e se è un numero, se non lo è lo richiede.
{
    Console.WriteLine("Please enter a valid number between 8 and 32.");
}

// 3.2 Special Characters
Console.WriteLine("Do you want to include special characters? (y/n)");
string includeSpecialChars = Console.ReadLine()?.ToLower() ?? "n";

while (includeSpecialChars != "y" && includeSpecialChars != "n")
{
    Console.WriteLine("Please enter 'y' or 'n'.");
    includeSpecialChars = Console.ReadLine()?.ToLower() ?? "n";
}

// 3.3 Numbers
Console.WriteLine("Do you want to include numbers? (y/n)");
string includeNumbers = Console.ReadLine()?.ToLower() ?? "n";   

while (includeNumbers != "y" && includeNumbers != "n")
{
    Console.WriteLine("Please enter 'y' or 'n'.");
    includeNumbers = Console.ReadLine()?.ToLower() ?? "n";
}

// 4. Password Generation

// --------------------------------------------------

// 4.1 Password Generation Logic
string GeneratedPassword = "";

if (includeSpecialChars == "y")
{
    Letters += SpecialChars;
}

if (includeNumbers == "y")
{
    Letters += Numbers;
}

// 4.2 Random Password Generation
Random random = new Random();

for (int i = 0; i < lenght; i++)
{
    int index = random.Next(Letters.Length);
    GeneratedPassword += Letters[index];
}

// 5. Output Password
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"{PlayerName}, your generated password is: {GeneratedPassword}");
Console.ResetColor();


// 6. Save Password to File
Console.WriteLine("Do you want to save the password to a file? (y/n)");
string saveToFile = Console.ReadLine()?.ToLower() ?? "n";

while (saveToFile != "y" && saveToFile != "n")
{
    Console.WriteLine("Please enter 'y' or 'n'.");
    saveToFile = Console.ReadLine()?.ToLower() ?? "n";
}

if (saveToFile == "y")
{
   string filePath = "GeneratedPassword.txt";
    System.IO.File.WriteAllText(filePath, GeneratedPassword);
    Console.WriteLine($"Password saved to {filePath}");
}
