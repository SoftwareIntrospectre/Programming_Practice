using System;

namespace Polymorphism_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person Tony = new Tony();
            Person Katie = new Katie();

            Tony.Speak();
            Katie.Speak();
        }
    }

    class Person
    {
        protected string name;
        public virtual void Speak()
        {
            Console.WriteLine($"Hi! My name is {name}!");
        }
    }

    class Tony : Person
    {
        public override void Speak()
        {
            name = "Tony";
            Console.WriteLine($"I'm cool guy {name}!");
        }
    }

    class Katie: Person
    {
        public override void Speak()
        {
            name = "Katie";
            Console.WriteLine($"I'm badass {name}!");
        }
    }
}
