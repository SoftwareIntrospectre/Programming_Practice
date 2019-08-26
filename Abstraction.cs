//Abstraction is the concept of classes using functionality from other classes, without needing to know how they work. Handy for re-use.

using System;

namespace Abstraction
{

    abstract class Dragon{
        public abstract string magic();
    }

    class RedDragon : Dragon
    {
        private string breath;

        public RedDragon(string redDragonMagic = "fire breath")
        {
           breath = redDragonMagic;
        }

        public override string magic()
        {
            return("magic ability is: " + breath);
        }
    }

       class PoisonDragon : Dragon
    {
        private string curse;

        public PoisonDragon(string psnDragonMagic = "putrid curse")
        {
           curse = psnDragonMagic;
        }

        public override string magic()
        {
            return("magic ability is: " + curse);
        }
    }

    class MagicalEffect
    {

        static void Main(string[] args)
        {
            Dragon redDragon = new RedDragon();
            Dragon psnDragon = new PoisonDragon();

           string redEffect = redDragon.magic();
           string poisonEffect = psnDragon.magic();

            Console.Write("Red Dragon's " + redDragon.magic() + "\n");
            Console.Write("Poison Dragon's " + psnDragon.magic());
        }
    }
}
