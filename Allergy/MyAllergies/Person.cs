using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Person
{

    public enum Allergens
    {
        eggs = 0,

        peanuts = 1,

        shellfish = 2,

        strawberries = 3,

        tomatoes = 4,

        chocolate = 5,

        pollen = 6,

        cats = 7,
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

        public bool ComputeAllergyScore(int score,int pos)
        {
                return (score & (1<< pos)) != 0;//if true
        }
        public void IsAlergicTo()
        {
            Console.Write("Please insert your allergy score: ");
            int score = int.Parse(Console.ReadLine());
            for (int i = 0; i < 8; i++)
            {
                if (ComputeAllergyScore(score, i))
                {
                    Console.WriteLine($"{this.name} is alergic to: {Enum.GetName(typeof(Allergens), i)}");
                }
            }
        }
    }
}