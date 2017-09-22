using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Core.Contracts.FactoryContracts;
using Traveller.Core.Providers;

namespace Traveller.Tests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class ParseParameters_Should
    {
        [TestMethod]
        public void ReturnEmptyList_WhenParametersCountIsOne()
        {
            // Arrange
            var emptyList = new List<string>();

            var factoryMock = new Mock<ICommandFactory>();
            var commandParser = new CommandParser(factoryMock.Object);
            var commandMock = "listvehicles";

            // Act
            var expectedResult = commandParser.ParseParameters(commandMock);

            // Assert
            Assert.AreEqual(expectedResult.Count, 0);
            Assert.AreEqual(expectedResult.GetType(), emptyList.GetType());
        }

        [TestMethod]
        public void ReturnListWithStrings_WhenParametersCountIsMoreThanOne()
        {
            // Arrange
            var emptyList = new List<string>();

            var factoryMock = new Mock<ICommandFactory>();
            var commandParser = new CommandParser(factoryMock.Object);
            var commandMock = "oogeti boogeti stuff";

            // Act
            var expectedResult = commandParser.ParseParameters(commandMock);

            // Assert
            Assert.AreEqual(expectedResult.Count, 2);
            Assert.AreEqual(expectedResult.GetType(), emptyList.GetType());
        }
    }
}
