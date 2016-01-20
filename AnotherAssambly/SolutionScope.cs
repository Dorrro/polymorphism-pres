namespace AnotherAssambly
{
    using System;
    using Polymorphism.Example8;

    public class SolutionScope
    {
        public void GetCozImSad()
        {
            var baseScope = new BaseScope();

            baseScope.GetThatInt = 1;

            //baseScope.YouCantGetMe = 2;

            //baseScope.GetMeIfYouCan = 3;

            //baseScope.ICanBeTaken = 4;

            Console.WriteLine(baseScope.GetThatInt /*+ baseScope.YouCantGetMe + baseScope.GetMeIfYouCan + baseScope.ICanBeTaken*/);
        }
    }
}
