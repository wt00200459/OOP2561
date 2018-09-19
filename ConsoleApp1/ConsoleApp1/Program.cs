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

      /**  midterm guideline 5 ตอน 
            1 keyword 25 ข้อ 100  keyword ให้หา 1 key word ที่ ผิด 
            2 26-35 จำนวน byte 
            3 36-45  value Type ref Type
            4 46-50 Code blank in codeing in word 
            5 51-65 เลือก  key word มาเติม 15 key word
            6 15 การพัฒนา แนวคิด 3 อย่าง 
        inherit  โคล่อน
        encapsulation  คลาส
        polymorphism อินเตอเฟส
            
            **/
    }
}

