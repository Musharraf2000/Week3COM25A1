using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3COM25A1
{
    internal class Cat
    {
        private string name;
        private int age;
        private string furColor;

        public string Name{ get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string FurColor { get => furColor; set => furColor = value; }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

   

        public void printInfo()
        {
            Console.WriteLine("Cat's name : " + name);
        }
    }
}
