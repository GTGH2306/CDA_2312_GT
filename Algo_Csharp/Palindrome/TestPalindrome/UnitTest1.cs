using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PalindromeSimplePair()
        {
            bool retour = Palindrome.Program.IsPalindrome("AA");
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void PalindromeSimpleImpair()
        {
            bool retour = Palindrome.Program.IsPalindrome("ABA");
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void PalindromeNombre()
        {
            bool retour = Palindrome.Program.IsPalindrome("85658");
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void PalindromeComplexe()
        {
            bool retour = Palindrome.Program.IsPalindrome("Et LA MaRINE VA VEnIR A mALTE");
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void PalindromeVide()
        {
            Palindrome.Program.Result retour = Palindrome.Program.CtrlSaisie("");
            Assert.AreEqual(Palindrome.Program.Result.Vide, retour);
        }

        [TestMethod]
        public void PalindromeNon()
        {
            bool retour = Palindrome.Program.IsPalindrome("ABCA");
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void PalindromeInsuf()
        {
            Palindrome.Program.Result retour = Palindrome.Program.CtrlSaisie("8");
            Assert.AreEqual(Palindrome.Program.Result.Insuf, retour);
        }

        [TestMethod]
        public void PalindromeQuitter()
        {
            Palindrome.Program.Result retour = Palindrome.Program.CtrlSaisie("Q");
            Assert.AreEqual(Palindrome.Program.Result.Quit, retour);
        }
    }
}