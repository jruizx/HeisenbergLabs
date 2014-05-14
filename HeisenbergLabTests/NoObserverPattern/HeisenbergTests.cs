using HeisenbergLab.NoObserverPattern;
using NUnit.Framework;

namespace HeisenberLabTests.NoObserverPattern
{
    [TestFixture]
    public class HeisenbergTests
    {
        [Test]
        public void Cook_BuyerIsNotNull_TheBuyerShouldBeUpdated()
        {
            // Arrange
            var theBuyer = new TucoSalamanca();
            var theCook = new Heisenberg(theBuyer);

            // Act
            theCook.Cook();

            // Assert
            Assert.IsTrue(theBuyer.OfferReceived);
        }

        [Test]
        public void Cook_BuyerNull_NoException()
        {
            // Arrange
            var theCook = new Heisenberg(null);

            Assert.DoesNotThrow(theCook.Cook);
        }
    }
}
