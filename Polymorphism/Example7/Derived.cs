namespace Polymorphism.Example7
{
    using System;

    public class Derived : Base
    {
        public override void DoSth()
        {
            Console.WriteLine("Let's do this!");
        }

        public override void DoSthElse()
        {
            base.DoSthElse();

            Console.WriteLine("Or not :(");
        }
    }
}