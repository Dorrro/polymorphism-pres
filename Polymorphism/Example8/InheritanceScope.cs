namespace Polymorphism.Example8
{
    using System;

    public class InheritanceScope : BaseScope
    {
        public void GetSomeOfThem()
        {
            this.GetThatInt = 1;

            // YouCantGetMe = 2;

            this.GetMeIfYouCan = 3;

            this.ICanBeTaken = 4;

            Console.WriteLine(this.GetThatInt /*+ YouCantGetMe*/ + this.GetMeIfYouCan + this.ICanBeTaken);
        }
    }
}