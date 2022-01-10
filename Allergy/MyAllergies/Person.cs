using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Person
{

    public enum Allergens
    {
        eggs = 1,

        peanuts = 2,

        shellfish = 4,

        strawberries = 8,

        tomatoes = 16,

        chocolate = 32,

        pollen = 64,

        cats = 128,
    };
    public class Person
    {
        private string name;
        private int age;




        public string Name { get { return this.name; } }
        public int Age { get { return this.age; } }



        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;


        }

        public void GetAllergensScore(int score)
        {
            int indice = score;
            if (score >= 256)
            {
                Console.WriteLine(" {0} is alergic to: {1}", this.name, Enum.GetName(typeof(Allergens), 1));
            }

            else
            {
                Console.Write(this.name + " is alergic to: ");
                while (indice >= 1)
                {
                    int min = 0;
                    int wanted = 0;
                    foreach (int num in Enum.GetValues(typeof(Allergens)))
                    {
                        if (num > min && num <= indice)
                        {
                            wanted = num;
                            min = num;
                        }
                    }
                    Console.Write(Enum.GetName(typeof(Allergens), wanted) + " ");
                    indice -= wanted;

                }
            }
        }
    }
}