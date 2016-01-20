namespace Polymorphism.Example1
{
    using System;

    public class Human : Mammal
    {
        public override int Age { get { return 3; } }

        public override void Say()
        {
            base.Say();

            Console.WriteLine("To be, or not to be?");
        }
    }
}
