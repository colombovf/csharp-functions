// See https://aka.ms/new-console-template for more information
/*void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto
dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.*/

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