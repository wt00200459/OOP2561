using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ISoundable { string MakeSound(); }
    interface ITellName { string TellName(); }
    class Animal
    {
        class Dog : Animal, ISoundable, ITellName
        {
            string ISoundable.MakeSound() { return " Bok Bok"; }
            string ITellName.TellName() { return " Dog "; }

        }
        class Cat : Animal, ISoundable, ITellName
        {
            string ISoundable.MakeSound() { return " Meaw Meaw"; }
            string ITellName.TellName() { return " Cat "; }

        }
        class Fish : Animal,  ITellName
        {
           
            string ITellName.TellName() { return " Fish "; }

        }

        static void Main()
        {
            Animal[] animal = new Animal[3];
            animal[0] = new Cat();
            animal[1] = new Dog();
            animal[2] = new Fish();
            foreach (Animal s in animal)
            {
                ITellName a = s as ITellName;
                ISoundable b = s as ISoundable;
                if (a != null)
                    Console.WriteLine(a.TellName());
                if (b != null)
                {
                    Console.WriteLine(b.MakeSound());
                    Console.WriteLine("==============");
                }
            }
        }


    }
}

