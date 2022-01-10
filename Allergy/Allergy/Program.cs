using System;
using Person;

namespace Person
{


    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Cosmin", 31);
            person.IsAlergicTo();
        }

        
    }
}


