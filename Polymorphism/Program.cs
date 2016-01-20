// *******************************************************************************
// INTEL CONFIDENTIAL
// Copyright 2013 - 2016
// Intel Corporation All Rights Reserved.
// 
// The source code contained or described herein and all documents related 
// to the source code ("Material") are owned by Intel Corporation or its 
// suppliers or licensors. Title to the Material remains with Intel Corporation 
// or its suppliers and licensors. The Material contains trade secrets and 
// proprietary and confidential information of Intel or its suppliers and 
// licensors. The Material is protected by worldwide copyright and trade 
// secret laws and treaty provisions. No part of the Material may be used, 
// copied, reproduced, modified, published, uploaded, posted, transmitted, 
// distributed, or disclosed in any way without Intel’s prior express written 
// permission.
// 
// No license under any patent, copyright, trade secret or other intellectual 
// property right is granted to or conferred upon you by disclosure or 
// delivery of the Materials, either expressly, by implication, inducement, 
// estoppel or otherwise. Any license under such intellectual property rights 
// must be express and approved by Intel in writing.
// *******************************************************************************

namespace Polymorphism
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using Example1;
    using Example2;
    using Example3;
    using Example5;
    using Example6;
    using Example8;
    using IHero = Example5.IHero;

    #endregion

    internal class Program
    {
        private static void Main()
        {
            var actions = new List<Action>
                          {
                              Example1,
                              Example2,
                              Example3,
                              Example4,
                              Example5,
                              Example6,
                              Example7,
                              Example8
                          };

            foreach (var action in actions)
            {
                Console.Clear();
                action();
            }
        }

        private static void Example8()
        {
            var baseScope = new BaseScope();
            baseScope.ICanBeTaken = 4;
            baseScope.GetAllOfThem();

            var assemblyScope = new AssemblyScope();
            assemblyScope.GetWhatYouCan();

            var inheritanceScope = new InheritanceScope();
            inheritanceScope.GetSomeOfThem();
        }

        private static void Example7()
        {
            var derived = new Example7.Derived();

            derived.DoSth();
            derived.DoSthElse();
            derived.DoEvenMore();

            //var @base = new Example7.Base();
        }

        private static void Example6()
        {
            var superHero = new SuperHero();
            superHero.Fly();
            superHero.GodMode();
            superHero.Stab();

            IHero hero = superHero;
            hero.Fly();

            IAssassin assassin = superHero;
            assassin.Stab();

            IMarvelFeatures marvelFeatures = superHero;
            marvelFeatures.GodMode();
        }

        private static void Example5()
        {
            IHero hero = new PoorHero();
            hero.Fly();

            hero = new RegularHero();
            hero.Fly();
        }

        private static void Example1()
        {
            var mammals = new List<Mammal>
                          {
                              new Human {Age = 28, Legs = 2},
                              new Monkey {Age = 4, Legs = 2},
                              new Mammal {Age = 23, Legs = 3}
                          };

            foreach (var mammal in mammals)
            {
                mammal.Say();
            }
//                
        }

        private static void Example2()
        {
            var derived = new Derived();
            derived.DoSomething();

            var @base = (Base)derived;
            @base.DoSomething();
        }

        private static void Example3()
        {
            new D().DoSomething();
            new C2().DoSomething();
            new C1().DoSomething();
        }

        private static void Example4()
        {
            var @as = new List<A>
                      {
                          new B1(),
                          new B2(),
                          new C1(),
                          new C2(),
                          new D()
                      };

            foreach (var a in @as)
                a.DoSomething();
        }
    }
}