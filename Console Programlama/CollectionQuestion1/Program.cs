using System;
using System.Collections;

namespace CollectionQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonprimeNumbers = new ArrayList();
            while (counter < 5)
            {
                Console.Write("{0}.Pozitif Sayi giriniz: ",counter+1);
                int value = int.Parse(Console.ReadLine());
                if (value < 0)
                {
                    Console.WriteLine("{0}. sayıyı tekrar giriniz:", counter + 1);
                }
                else
                {
                    if (IsPrime(value))
                    {
                        primeNumbers.Add(value);
                    }
                    else
                    {
                        nonprimeNumbers.Add(value);
                    }
                }
                counter++;
            }
            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
            }
        }
        static bool IsPrime(int number)
        {
            bool result = true;

            if(number == 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

    }
   
}

//Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
