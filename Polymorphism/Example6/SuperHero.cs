namespace Polymorphism.Example6
{
    using System;

    public class SuperHero : IAssassin, IMarvelFeatures, Example5.IHero
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }

        public void Stab()
        {
            Console.WriteLine("Die, bee... tsh");
        }

        public void GodMode()
        {
            Console.WriteLine("Like I give a duck");
        }
    }
}