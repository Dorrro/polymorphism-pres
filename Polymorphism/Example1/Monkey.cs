namespace Polymorphism.Example1
{
    using System;

    public class Monkey : Mammal
    {
        public override void Say()
        {
            base.Say();
            Console.WriteLine("ugha ugahw woohaa bowoo!");
        }
    }
}
