using System;
using System.Collections.Generic;
using IteratorRefactor;
using NUnit.Framework;

namespace IteratorTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void DestroyTheInternals()
        {
            // Just an illustration...
            var iBox = new IntegerBox(new[] { 3, 4, 5, 6 });
            int[] data = iBox.GetData();
            PrintArrayInOrder(data);
            for (int i = 0; i < data.Length; i++)
            {
                if (i == 1)
                {
                    SomeComplicatedMethodOrProcess(data); // :(
                }
            }
            PrintArrayInOrder(data);
        }
        private void SomeComplicatedMethodOrProcess(int[] items)
        {
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = -1;
            }
        }
        private void PrintArrayInOrder(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
                Console.Write(items[i] + " ");
            Console.WriteLine();
        }

        [Test]
        public void ConcurrentIterationImpossible()
        {
            // Since my iteration logic is tightly-coupled to IntegerBox...
            // ...I can't access the list in multiple places at the same time...
            // ...yet

            // how could multiple threads iterate over this object at the same time?
            // see answer below
        }

        [Test]
        public void IterateOverIntegerBox()
        {
            var iBox = new IntegerBox(new [] { 3, 4, 5, 6 });
            // storing results just for demo
            var result = iBox.IterateOverData(); 
            Assert.That(result, Is.EqualTo("3456"));
            new GlobalPrinter().PrintData(iBox.GetData());
        }

        [Test]
        public void IterateOverCharList()
        {
            var list = new SomeList(new List<int> {9, 3, 6});
            // storing results just for demo
            var result = list.IterateOverData();
            Assert.That(result, Is.EqualTo("936"));
            new GlobalPrinter().PrintData(list.GetData());
        }

        //[Test]
        //public void DecoupleIteratorFromCollection()
        //{
        //    var iBox = new IntegerBox(new[] { 3, 4, 5, 6 });
        //    IIterator iter1 = iBox.GetIterator();
        //    new GlobalPrinter().PrintData(iter1); // ...use the same PrintData method

        //    var list = new SomeList(new List<int> { 7, 8, 9 });
        //    IIterator iter2 = list.GetIterator(); // ...for anything that implements IIterator
        //    new GlobalPrinter().PrintData(iter2);
        //}

        [Test]
        public void HowForEachWorksUnderTheHood()
        {
            // DEMO...
            // .NET implementation...
            // an Enumerable is something that has an enumerator
            // an Iterator   is something that has an iterator

            var list = new List<int> {1, 2, 3, 4, 5};
            IEnumerator<int> listEnumerator = list.GetEnumerator();

            // btw... this is how foreach works under the hood...
            try
            {
                while (listEnumerator.MoveNext())
                {
                    Console.WriteLine(listEnumerator.Current);
                }
            }
            finally
            {
                listEnumerator.Dispose();
            }

            // why do I care about disposing the enumerator?
            // this was a design choice by the c# compiler folks.
            // they figured you'd be connecting to a database and iterating
            // over a bunch of rows and wanted to make disposing the connecction
            // a compile-time check
        }

        [Test]
        public void ConcurrentAccess()
        {
            var hash = new Dictionary<int, string>
            {
                { 1, "tree" },
                { 2, "hedge" },
                { 3, "shrub" },
                { 5, "cactus" }
            };
            IEnumerator<string> valueEnumerator1 = hash.Values.GetEnumerator();
            IEnumerator<string> valueEnumerator2 = hash.Values.GetEnumerator();
            IEnumerator<string> valueEnumerator3 = hash.Values.GetEnumerator();

            // for normally looks like this...
            // for(var i = 0; i < something.length; i++)
            for (;valueEnumerator1.MoveNext() && valueEnumerator2.MoveNext() && valueEnumerator3.MoveNext();)
            {
                Console.WriteLine(valueEnumerator1.Current + " " + valueEnumerator1.Current.GetHashCode());
                Console.WriteLine(valueEnumerator2.Current + " " + valueEnumerator1.Current.GetHashCode());
                Console.WriteLine(valueEnumerator3.Current + " " + valueEnumerator1.Current.GetHashCode());
            }
            // hash code included to show that enumerator does NOT make a copy
            // enumerator refers to the original data
        }

        [Test]
        public void WhatAboutLazyLoading()
        {
            Console.WriteLine("not enough time");
        }

        [Test]
        public void WhatAboutYield()
        {
            Console.WriteLine("not enough time");
        }

        [Test]
        public void WhatAboutLinq()
        {
            Console.WriteLine("not enough time");
        }
    }
}
