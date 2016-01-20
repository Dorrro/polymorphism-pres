namespace Polymorphism.Example3
{
    using System;

    public class B2 : A
    {
        public sealed override void DoSomething()
        {
            Console.WriteLine("I'm in B2!!");
        }
    }
}