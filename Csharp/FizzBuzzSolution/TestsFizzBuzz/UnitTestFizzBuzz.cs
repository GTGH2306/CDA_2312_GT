using ClassLibraryFizzBuzz;

namespace TestsFizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzz
    {
        [TestMethod]
        public void ShouldReturn1IfNumber1()
        {
            Assert.AreEqual("1", FizzBuzzTDD.Roll(1));
        }

        [TestMethod]
        public void ShouldReturn1IfNumber2()
        {
            Assert.AreEqual("2", FizzBuzzTDD.Roll(2));
        }

        [TestMethod]
        public void ShouldReturnFizzIfNumber3()
        {
            Assert.AreEqual("Fizz", FizzBuzzTDD.Roll(3));
        }

        [TestMethod]
        public void ShouldReturnFizzIfNumber6()
        {
            Assert.AreEqual("Fizz", FizzBuzzTDD.Roll(6));
        }

        [TestMethod]
        public void ShouldReturnBuzzIfNumber5()
        {
            Assert.AreEqual("Buzz", FizzBuzzTDD.Roll(5));
        }

        [TestMethod]
        public void ShouldReturnBuzzIfNumber10()
        {
            Assert.AreEqual("Buzz", FizzBuzzTDD.Roll(10));
        }

        [TestMethod]
        public void ShouldReturnFizzBuzzIfNumber15()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzTDD.Roll(15));
        }

        [TestMethod]
        public void ShouldReturnFizzBuzzIfNumber30()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzTDD.Roll(30));
        }

    }
}