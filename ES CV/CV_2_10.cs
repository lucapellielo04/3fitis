// Alessio Modonesi 3F 04/11/2020
using System;
class MainClass 
{
    static void Main(string[] args) 
    {
        string binario;
        int dec = 0;
        int pos = 0;
        // input numero binario (di tipo stringa)
        Console.WriteLine("Inserisci un numero binario");
        binario = Console.ReadLine();
        // ciclo di calcolo dell'equivalente decimale
        // come accumulo dei valori derivanti da potenze di 2^x
        dec = 0;
        for (pos = binario.Length - 1; pos >= 0; pos--)
        {
            // se la cifra è 1 "pesa", altrimenti vale 0
            if (binario[pos] == '1')
            {
              dec = dec + (int) Math.Pow(2, binario.Length - 1 - pos);
            }
        }
        // stampa il numero in forma binaria
        Console.WriteLine("Numero decimale equivalente:  " + dec); 
      }
}
