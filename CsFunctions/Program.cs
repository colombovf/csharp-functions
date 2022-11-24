// See https://aka.ms/new-console-template for more information
/*void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto
dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.*/

using System;

int[] arrayInteri = {1,2,3,4,5,6,7,8,9,10};
StampaArrayInteri(arrayInteri);
void StampaArrayInteri(int[] arrayInteri)
{
    Console.Write("[");
    for (int i = 0; i < arrayInteri.Length; i++)
    {
        if (i == arrayInteri.Length - 1)
        {
            Console.Write('"' + arrayInteri[i]);
        }
        else
        {
            Console.Write('"' + arrayInteri[i] + " , ");
        }
    }
    Console.WriteLine("]");
}

/*int Quadrato(int numero): che vi restituisca il 
 * quadrato del numero passato come parametro.*/
int number = 4;
QuadratoDelNumero(number);
void QuadratoDelNumero (int number)
{
    number*= number;
    Console.WriteLine(number);
}

/*Preso un array di numeri interi, restituisca un nuovo array 
 * con tutti gli elementi elevati quadrato.Attenzione: è importante
 * restituire un nuovo array, e non modificare l’array come parametro della funzione! */

int[] integerArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copiaArray = (int[])integerArray.Clone();
ElevaArratAlQuadrato(copiaArray);

for (int i = 0; i< integerArray.Length; i++)
{
    Console.Write(integerArray[i]);
}
void ElevaArratAlQuadrato(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] *= array[i];
        Console.WriteLine(array[i]);
    }
}
