using HeisenbergLab.ObserverPattern;
using NUnit.Framework;

namespace HeisenberLabTests.ObserverPatternTests
{
    [TestFixture]
    public class HeisenbergTests
    {
        [Test]
        public void Cook_TucoSalamanca_TucoSalamancaShouldBeNotified()
        {
            // Arrange
            var heisenberg = new Heisenberg();
            var tucoSalamnca = new TucoSalamanca();
            heisenberg.Attach(tucoSalamnca);

            // Act
            heisenberg.Cook();

            // Assert
            Assert.That(tucoSalamnca.OfferReceived, Is.True);
        }

        [Test]
        public void Cook_NoObserver_NoException()
        {
            // Arrange
            var theCook = new Heisenberg();

            Assert.DoesNotThrow(theCook.Cook);
        }

        [Test]
        public void Cook_TucoSalamancaAndGustavoFring_TucoSalamancaAndGustavoFringShouldBeNotified()
        {
            // Arrange
            var heisenberg = new Heisenberg();
            
            var tucoSalamanca = new TucoSalamanca();
            var gustavoFring = new GustavoFring();
            
            heisenberg.Attach(tucoSalamanca);
            heisenberg.Attach(gustavoFring);

            // Act
            heisenberg.Cook();

            // Assert
            Assert.That(tucoSalamanca.OfferReceived, Is.True);
            Assert.That(gustavoFring.OfferReceived, Is.True);
        }
    }
}
