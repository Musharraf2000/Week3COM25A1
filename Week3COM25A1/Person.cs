using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3COM25A1
{
    internal class Person
    {
        private string name;
        private int age;
        private Cat petCat;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, Cat petCat)
        {
            this.name = name;
            this.age = age;
            this.petCat = petCat;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal Cat PetCat { get => petCat; set => petCat = value; }

        public void PrintInfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            if (petCat != null)
            {

                Console.WriteLine("Pet Cat's Name :" + petCat.Name);
                Console.WriteLine("Pet Cat's Age :" + petCat.Age);

            }
            else
            {
                Console.WriteLine(name + " doesn't own a pet");
            }
        }
    }
}
