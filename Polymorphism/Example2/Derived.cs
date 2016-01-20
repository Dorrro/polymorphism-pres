namespace Polymorphism.Example2
{
    using System;

    public class Derived : Base
    {
        public override void DoSomething()
        {
            Console.WriteLine("I'm not!!");
        }
    }
}