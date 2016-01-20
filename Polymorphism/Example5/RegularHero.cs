namespace Polymorphism.Example5
{
    using System;

    public class RegularHero : IHero
    {
        public void Fly()
        {
            Console.WriteLine("I wish I could fly like a superhero");
        }
    }
}