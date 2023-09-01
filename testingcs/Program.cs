using System;
using System.Security.Cryptography;

using System;
using System;
using static System.Net.Mime.MediaTypeNames;

using System;
using System.Reflection;

namespace bubblesortOptimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tall = { 1, 2, 10, 55, 5, 6 };

            BubbleSort(tall);
            foreach (int num in tall)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }

        static void BubbleSort(int[] tall)
        {
            bool check = false; //deklarerer en check for å sjekke om det har skjedd en swap senere
            int n = tall.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)//inner loop for å sammenligning og swap
                {
                    check = false; //restarter check for en til runde
                    if (tall[j] > tall[j + 1])
                    {
                        int temp = tall[j];
                        tall[j] = tall[j + 1];
                        tall[j + 1] = temp;
                        check = true; //setter til true for å ikke stoppe og gå en til runde
                    }
                }//en runde kjørt 
                if (check == false)//vi stopper programmet om metoden over ikke trengte å kjøres,
                //så vi slipper å vente på at den går flere ganger selv om den er riktig formulert.
                {
                    break;//exit loop for den er sortert riktig
                }
            }
        }
    }
}
