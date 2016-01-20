namespace Polymorphism.Example8
{
    using System;

    public class AssemblyScope
    {
        public void GetWhatYouCan()
        {
            var baseScope = new BaseScope();

            baseScope.GetThatInt = 1;

            //baseScope.YouCantGetMe = 2;

            //baseScope.GetMeIfYouCan = 3;

            baseScope.ICanBeTaken = 4;

            Console.WriteLine(baseScope.GetThatInt /*+ baseScope.YouCantGetMe + baseScope.GetMeIfYouCan*/ + baseScope.ICanBeTaken);
        }
    }
}