using CountriesApi.Models;

namespace CountriesApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Country_Code()
        {
            Country country = new Country();
            country.CountryCode = "FR";

            Assert.AreEqual("FR", country.CountryCode);
        }
    }
}