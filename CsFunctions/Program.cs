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
ElevaArrayAlQuadrato(copiaArray);

//Ciclo l'array per mostrare che effettivamente modifico la copa dell'array e non l'array stessa.
    Console.Write("L'array è: ");
    StampaArrayInteri(integerArray);


//Funzione per elevare gli elementi dell'array al quadrato
void ElevaArrayAlQuadrato(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] *= array[i];
    }
    Console.Write("Il quadrato degli elementi dell'array è: ");
    StampaArrayInteri(array);
}








Console.WriteLine();
/*preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.*/
Console.WriteLine("Parte 4:");
int[] integerArray2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copiaArray2 = (int[])integerArray2.Clone();
Console.Write("L'array è: ");
StampaArrayInteri(copiaArray2);
ArraysElementsSum(copiaArray2);

void ArraysElementsSum(int[] array)
{
    int totalSum = array.Sum();
   
    Console.Write("La somma degli elementi dell'array è: ");
    Console.WriteLine(totalSum);
}






Console.WriteLine();
/*dato il seguente array di numeri [2, 6, 7, 5, 3, 9], stampare la somma di tutti i numeri elevati al quadrati*/
Console.WriteLine("Parte 5:");
int[] integerArray3 = {2, 6, 7, 5, 3, 9};
int[] copiaArray3 = (int[])integerArray3.Clone();
Console.WriteLine();
ArraysElementsSum(copiaArray3);
Console.WriteLine();
ArraysElementsSumQuadrato(copiaArray3);

//Funzione che stampa gli elementi dell'array al quadrato e sommati:

void ArraysElementsSumQuadrato(int[] array)
{
    ElevaArrayAlQuadrato(array);
    ArraysElementsSum(array);
}



















/*BONUS:
Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono 
lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare 
sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto 
modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e 
dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma
con l’input preso esternamente dall’utente.*/











