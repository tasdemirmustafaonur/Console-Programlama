using System;

namespace Console_Programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsmini Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);

        }
    }
}
