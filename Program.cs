// 0. Avvio 
using System;
using System.Collections.Generic;

// 1. Variabili
string nomeGiocatore = "Player";
int monete = 9999;
double altezza = 1.90;
bool haFinitoLivello = false;


// 2. Printing
Console.WriteLine("Benvenuto, " + nomeGiocatore + "!");
Console.WriteLine("Hai " + monete + " monete.");
Console.WriteLine("Sei alto: " + altezza + "m");


// 3. Condizioni (if)
if (monete >= 100)
{
    Console.WriteLine("YOYOYO MA SEI RICOOO");
}
else
{
    Console.WriteLine("C'è strada da fare, " + monete + " monete, basteranno per l'inizio!");
}

if (haFinitoLivello)
{
    Console.WriteLine("Hai finito il livello!");
}
else
{
    Console.WriteLine("Non hai finito il livello, continua a giocare!");
}

// 4. Cicli (while, for)

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Livello " + i + " completato!");
}

for (int i = 5; i >= 0; i--)
{
    Console.WriteLine("Autodistruzione in " + i + " secondi...");
}

// 5. Liste (Array, Librerie)

List<string> inventario = new List<string>() { "Mano", "Spada", "Scudo" };

for (int i = 0; i < inventario.Count; i++)
{
    Console.WriteLine("Hai nell'inventario: " + inventario[i]);
}

List<int> numeri = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = numeri.Count - 1; i >= 1; i--)  // i >= 1 dice al indice "i" di continuare fino ad arrivare al valore pre-stabilito (1)
{
    Console.WriteLine("Posizione: " + numeri[i]);
}