using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core.Contracts.FactoryContracts;
using Traveller.Core.Providers;
using Traveller.Core.Repository;

namespace Traveller.Tests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class ParseCommand_Should
    {
        [TestMethod]
        public void ReturnsCorrectCommand_WhenParametersAreCorrect()
        {
            // Arrange
            var factoryMock = new Mock<ICommandFactory>();

            var paremeters = "listvehicles ooga booga";

            var commandParser = new CommandParser(factoryMock.Object);

            // Act
            var command = commandParser.ParseCommand(paremeters);

            // Assert
            Assert.IsInstanceOfType(command, typeof(ListVehiclesCommand));
        }
    }
}
