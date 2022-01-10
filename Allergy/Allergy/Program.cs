using System;
using Person;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("cosmin", 31);
            person.GetAllergensScore(34);
        }
    }
}
