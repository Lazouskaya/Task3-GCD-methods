using System;
using GCDMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;


namespace TestGCDMethods
{
    [TestFixture]
    public class EvklidAlgorithmTest
    {
        private TimeSpan time=new TimeSpan();
        [TestCase(49, 28, Result = 7)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(0, 1, Result = 1)]
        [Test]
        public int GCDByEvclideanFor2numbers(int number1, int number2)
        {
            return Nod.Evclidean(number1, number2, out time);
        }

        [TestCase(25, 115, 65, 80, Result = 5)]
        [Test]
        public int GCDByEvclideanForamount( params int[] numbers)
        {
            return Nod.Evclidean(out time, numbers);
        }

        [TestCase(48, 30, Result = 6)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(0, 1, Result = 1)]
        [Test]
        public int GCDByStainFor2numbers(int number1, int number2)
        {
            return Nod.Stain(number1, number2, out time);
        }

        [TestCase(78, 294, 570, 36, Result = 6)]
        [Test]
        public int FindGCDByStaineAlgorithmTest(params int[] numbers)
        {
            return Nod.Stain(out time,numbers);
        }
    }
}
