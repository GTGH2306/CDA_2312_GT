using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PalindromeSimplePair()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("AA");
            Assert.AreEqual(Palindrome.Program.Result.Vrai, retour);
        }

        [TestMethod]
        public void PalindromeSimpleImpair()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("ABA");
            Assert.AreEqual(Palindrome.Program.Result.Vrai, retour);
        }

        [TestMethod]
        public void PalindromeNombre()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("85658");
            Assert.AreEqual(Palindrome.Program.Result.Vrai, retour);
        }

        [TestMethod]
        public void PalindromeComplexe()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("Et LA MaRINE VA VEnIR A mALTE");
            Assert.AreEqual(Palindrome.Program.Result.Vrai, retour);
        }

        [TestMethod]
        public void PalindromeVide()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("");
            Assert.AreEqual(Palindrome.Program.Result.Vide, retour);
        }

        [TestMethod]
        public void PalindromeNon()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("ABCA");
            Assert.AreEqual(Palindrome.Program.Result.Faux, retour);
        }

        [TestMethod]
        public void PalindromeInsuf()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("8");
            Assert.AreEqual(Palindrome.Program.Result.Insuf, retour);
        }

        [TestMethod]
        public void PalindromeQutter()
        {
            Palindrome.Program.Result retour = Palindrome.Program.IsPalindrome("Q");
            Assert.AreEqual(Palindrome.Program.Result.Quit, retour);
        }
    }
}