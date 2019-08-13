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

        //allows this function to be overridden. If it isn't uses the default functionality
        public virtual void Attack()
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

        //Within the ElderDragon class' scope: override base Attack() with Elder Dragon's Attack().
        public override void Attack()
        {
            //uses parent class' default behavior
            base.Attack();

            //overridden behavior
            Console.WriteLine("Elder Dragon is neat I guess.");
        }
    }

    public class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Goblin";
            Damage = 2;

        }
        
        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("Goblin is a punk.");
        }
    }
}
