using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Core.Contracts.FactoryContracts;
using Traveller.Core.Providers;

namespace Traveller.Tests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ReturnInstance_WhenArgumentsAreValid()
        {
            // Arrange
            var factoryMock = new Mock<ICommandFactory>();

            // Act
            var instance = new CommandParser(factoryMock.Object);

            // Asseret
            Assert.IsNotNull(instance);
        }
    }
}
