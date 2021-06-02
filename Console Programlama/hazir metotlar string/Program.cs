using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz";
            string degisken2 = "CSharp";

            //Lenght;
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat

            Console.WriteLine(String.Concat(degisken, " Merhaba"));

            //Comparte, CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));// true dersem büyük küçük harf duyarsız hale gelir.
            Console.WriteLine(String.Compare(degisken, degisken2, false));// 

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));//degisken içinde degisken2 var mı?
            Console.Write(degisken.EndsWith("Hosgeldiniz"));//degisken hosgeldiniz ile bitiyor mu ?
            Console.Write(degisken.StartsWith("Merhaba"));//degisken hosgeldiniz ile bitiyor mu ?

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));// index'i döndürüyor,bulamazsa -1 döner.
            Console.WriteLine(degisken.LastIndexOf("i"));


            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) +degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); 
            Console.WriteLine(degisken.Remove(5,3)); 
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));//4.indexten başlayarak sonuna kadar getirir
            Console.WriteLine(degisken.Substring(4,6));//4.indexten başlayarak 6 karakter getirir


        }
    }
}
