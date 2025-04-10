using Moq;
using ClassLibraryJeu421;

namespace _421Tests
{
    [TestClass]
    public class Tests421
    {
        private readonly Mock<INextable> mockAlea = new Mock<INextable>();

        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            int[] expected = { 2, 4, 1 };
            mockAlea.SetupSequence(alea => alea.Nouveau(1, 6))
                .Returns(2)
                .Returns(4)
                .Returns(1);
            int[] actual = new int[expected.Length];

            //Act
            actual[0] = mockAlea.Object.Nouveau(1, 6);
            actual[1] = mockAlea.Object.Nouveau(1, 6);
            actual[2] = mockAlea.Object.Nouveau(1, 6);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDice()
        {
            //Arrange
            De die = new De();
            int[] expected = { 2, 4, 1 };
            mockAlea.SetupSequence(alea => alea.Nouveau(1, 6))
                .Returns(2)
                .Returns(4)
                .Returns(1);
            int[] actual = new int[expected.Length];

            //Act
            die.Jeter(mockAlea.Object);
            actual[0] = die.Valeur;
            die.Jeter(mockAlea.Object);
            actual[1] = die.Valeur;
            die.Jeter(mockAlea.Object);
            actual[2] = die.Valeur;

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}