// See https://aka.ms/new-console-template for more information
using System;
/*void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto
dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.*/
Console.WriteLine("Parte 1:");
int[] arrayInteri = {1,2,3,4,5,6,7,8,9,10};
StampaArrayInteri(arrayInteri);
void StampaArrayInteri(int[] arrayInteri)
{
    Console.Write("[");
    for (int i = 0; i < arrayInteri.Length; i++)
    {
        if (i == arrayInteri.Length - 1)
        {
            Console.Write(arrayInteri[i]);
        }
        else
        {
            Console.Write(arrayInteri[i] + " , ");
        }
    }
    Console.WriteLine("]");
}





Console.WriteLine();
/*int Quadrato(int numero): che vi restituisca il 
 * quadrato del numero passato come parametro.*/
Console.WriteLine("Parte 2:");
int number = 4;
QuadratoDelNumero(number);
void QuadratoDelNumero (int number)
{
    number*= number;
    Console.WriteLine(number);
}





Console.WriteLine();
/*Preso un array di numeri interi, restituisca un nuovo array 
 * con tutti gli elementi elevati quadrato.Attenzione: è importante
 * restituire un nuovo array, e non modificare l’array come parametro della funzione! */
Console.WriteLine("Parte 3:");
int[] integerArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copiaArray = (int[])integerArray.Clone();
Console.Write("L'array elevata al quadrato è: ");
ElevaArratAlQuadrato(copiaArray);

//Ciclo l'array per mostrare che effettivamente modifico la copa dell'array e non l'array stessa.
    Console.Write("L'array è: ");
    StampaArrayInteri(integerArray);


//Funzione per elevare gli elementi dell'array al quadrato
void ElevaArratAlQuadrato(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] *= array[i];
    }
    StampaArrayInteri(array);
}








Console.WriteLine();
/*preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.*/
Console.WriteLine("Parte 4:");
int[] integerArray2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copiaArray2 = (int[])integerArray2.Clone();
ArraysElementsSum(copiaArray2);

void ArraysElementsSum(int[] array)
{
    int totalSum = array.Sum();
    Console.Write("L'array è: ");
    StampaArrayInteri(array);
    Console.Write("La somma degli elementi dell'array è: ");
    Console.WriteLine(totalSum);
}