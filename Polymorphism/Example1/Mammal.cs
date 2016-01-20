namespace Polymorphism.Example1
{
    using System;

    public class Mammal
    {
        public int IntField;

        public int Legs { get; set; }

        public virtual int Age { get; set; }

        public virtual void Say()
        {
            Console.WriteLine("This is what it says.");
        }
    }
}
