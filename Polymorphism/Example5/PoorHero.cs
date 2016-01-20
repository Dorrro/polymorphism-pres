namespace Polymorphism.Example5
{
    using System;

    public class PoorHero : IHero
    {
        public void Fly()
        {
            Console.WriteLine("I wish I could fly");
        }
    }
}