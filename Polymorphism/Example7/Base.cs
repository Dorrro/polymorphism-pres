namespace Polymorphism.Example7
{
    using System;

    public abstract class Base
    {
        public abstract void DoSth();

        public virtual void DoSthElse()
        {
            Console.WriteLine("I'm doin' it!");
        }

        public void DoEvenMore()
        {
            Console.WriteLine("Pass");
        }
    }
}
