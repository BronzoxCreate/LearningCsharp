
// 0. Avvio & Librerie 
using System;
using System.Collections.Generic;

// 1. Variabili 
 string caratteriDisponibili = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#-_()!@";


// 2. FrontEnd 
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(" // Password Generator // V.1.0 //");
Console.ResetColor();


Console.WriteLine("What's your name?");
  string NomePlayer = Console.ReadLine() ?? "_"; // legge l'input dell'utente
Console.WriteLine($"Hello {NomePlayer}, How long you want ur password to be? (min 8, max 32)");
    

// 3. Lunghezza Password
int lunghezza;

while(!int.TryParse(Console.ReadLine(), out lunghezza) || lunghezza < 8 || lunghezza > 32) // controlla se l'input è un numero fra 8 e 32 e se è un numero, se non lo è lo richiede.
{
    Console.WriteLine("Please enter a valid number between 8 and 32.");
}

// 4. Generazione Password

Random rnd = new Random();

string password = "";

for (int i = 0; i < lunghezza; i++)
{
    int index = rnd.Next(caratteriDisponibili.Length);
    password += caratteriDisponibili[index];
}

// 5. Output Password 
Console.ForegroundColor = ConsoleColor.DarkMagenta; 
Console.WriteLine($"{NomePlayer}, your password is: {password}");
Console.ResetColor();