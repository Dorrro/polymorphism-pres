namespace Polymorphism.Example8
{
    using System;

    public class BaseScope
    {
        public int GetThatInt;

        private int YouCantGetMe;

        protected int GetMeIfYouCan;

        internal int ICanBeTaken;

        public void GetAllOfThem()
        {
            GetThatInt = 1;

            YouCantGetMe = 2;

            GetMeIfYouCan = 3;

            ICanBeTaken = 4;

            Console.WriteLine(GetThatInt + YouCantGetMe + GetMeIfYouCan + ICanBeTaken);
        }
    }
}
