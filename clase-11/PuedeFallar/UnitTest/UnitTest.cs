using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuedeFallar;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        private const string FIZZBUZZ = "FizzBuzz";

        [TestMethod]
        public void Test_FizzBuzz_Divisible_Por_3()
        {
            Int32 nueve = 9;

            string nueveFizz = FizzBuzzExtension.FizzBuzz(nueve);

            Assert.AreEqual(FIZZ, nueveFizz);
            Assert.AreNotEqual(BUZZ, nueveFizz);
            Assert.AreNotEqual(FIZZBUZZ, nueveFizz);
            Assert.AreNotEqual("9", nueveFizz);
        }

        [TestMethod]
        public void Test_FizzBuzz_Divisible_Por_5()
        {
            Int32 diez = 10;

            string diezBuzz = FizzBuzzExtension.FizzBuzz(diez);

            Assert.AreEqual(BUZZ, diezBuzz);
            Assert.AreNotEqual(FIZZ, diezBuzz);
            Assert.AreNotEqual(FIZZBUZZ, diezBuzz);
            Assert.AreNotEqual("10", diezBuzz);
        }

        [TestMethod]
        public void Test_FizzBuzz_Divisible_Por_3_Y_Por_5()
        {
            Int32 quince = 15;

            string quinceFizzBuzz = FizzBuzzExtension.FizzBuzz(quince);

            Assert.AreEqual(FIZZBUZZ, quinceFizzBuzz);
            Assert.AreNotEqual(FIZZ, quinceFizzBuzz);
            Assert.AreNotEqual(BUZZ, quinceFizzBuzz);
            Assert.AreNotEqual("15", quinceFizzBuzz);
        }

        [TestMethod]
        public void Test_FizzBuzz_No_Divisible_Por_3_Ni_Por_5()
        {
            Int32 ocho = 8;

            string ochoNoFizzBuzz = FizzBuzzExtension.FizzBuzz(ocho);

            Assert.AreEqual("8", ochoNoFizzBuzz);
            Assert.AreNotEqual(FIZZ, ochoNoFizzBuzz);
            Assert.AreNotEqual(BUZZ, ochoNoFizzBuzz);
            Assert.AreNotEqual(FIZZBUZZ, ochoNoFizzBuzz);
        }
    }
}
