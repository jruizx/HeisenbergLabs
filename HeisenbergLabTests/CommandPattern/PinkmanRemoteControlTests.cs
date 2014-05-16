using HeisenbergLab.CommandPattern;
using Moq;
using NUnit.Framework;

namespace HeisenberLabTests.CommandPattern
{
    [TestFixture]
    public class PinkmanRemoteControlTests
    {
        [Test]
        public void PressButton_ThereIsACommandInSlot0_CommandShouldBeExecuted()
        {
            // Arrange
            var remoteControl = new PinkmanRemoteControl();
            var command = new Mock<ICommand>();
            remoteControl.SetCommand(0, command.Object);

            // Act
            remoteControl.PressButton(0);

            // Assert
            command.Verify(x=> x.Execute(), Times.Once);
        }
    }
}
