namespace Polymorphism.Example3
{
    using System;

    public class C1 : B1
    {
        public new void DoSomething()
        {
            Console.WriteLine("I'm in C1!!!");
        }
    }
}