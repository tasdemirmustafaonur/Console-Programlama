using System.Collections.Generic;

namespace TelefonRehberUygulaması
{
    public static class PersonList
    {
        public static List<Person> persons;


        static PersonList()
        {
            persons = SetPersons();
        }


        public static List<Person> SetPersons()
        {
            return new List<Person>()
            {
                new Person("Yağız","Ünal","5456301745"),
                new Person("Özgür","Taşdemir","5357051520"),
                new Person("Fatih","Taşdemir","5354781514"),
                new Person("Mustafa","Taşdemir","5468532021"),
                new Person("Oktay","Ağca","5473302527")
            };
        }
    }
}