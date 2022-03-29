using System.Globalization;
using NUnit.Framework;

namespace FactorialSpec {
    public class FactorialSpecs {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void return_1_when_number_is_0() {
            var expected = 1;

            var facRun = Factorial.Run(0);

            Assert.AreEqual(expected, facRun);
        }

        [Test]
        public void return_1_when_number_is_1() {
            var expected = 1;

            var facRun = Factorial.Run(1);

            Assert.AreEqual(expected, facRun);
        }

        [Test]
        public void return_2_when_number_is_2() {
            var expected = 2;

            var facRun = Factorial.Run(2);

            Assert.AreEqual(expected, facRun);
        }

        [Test]
        public void return_6_when_number_is_3() {
            var expected = 6;

            var facRun = Factorial.Run(3);

            Assert.AreEqual(expected, facRun);
        }

        [Test]
        public void return_24_when_number_is_4() {
            var expected = 6;

            var facRun = Factorial.Run(3);

            Assert.AreEqual(expected, facRun);
        }

        [TestCase(5, 120)]
        [TestCase(6, 720)]
        [TestCase(7, 5040)]
        [TestCase(8, 40320)]
        public void return_factorial_when_number_is_given(int number, double factorial) {

            var facRun = Factorial.Run(number);

            Assert.AreEqual(factorial, facRun);
        }

    }

    public abstract class Factorial {
        public static double Run(int number) {
            var result = 1;
            for (var i = 1; i <= number; i++) {
                result *= i;
            }

            return result;
        }
    }
}