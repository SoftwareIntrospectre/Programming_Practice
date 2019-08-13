using System;

namespace Polymorphism_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ElderDragon dragon = new ElderDragon();
            Goblin goblin = new Goblin();

            dragon.Attack();
            goblin.Attack();
            Console.ReadKey();
        }
    }

    public class Enemy
    {
        protected string Name;
        protected int Damage;
        public void Attack()
        {
            Console.WriteLine($"{Name} attacks, dealing {Damage} damage!");
        }
    }

    public class ElderDragon : Enemy
    {
        public ElderDragon()
        {
            Name = "Elder Dragon";
            Damage = 25;
        }
    }

    public class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Goblin";
            Damage = 2;
        }
    }
}
