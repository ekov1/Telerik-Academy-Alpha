using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Commands.Creating;
using Traveller.Core.Contracts;
using Traveller.Core.Repository;

namespace Traveller.Tests.Commands.Creating
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ReturnInstance_WhenArgumentsAreValid()
        {
            // Arrange
            var databaseMock = new Mock<IDatabase>();
            var factoryMock = new Mock<ITravellerFactory>();

            // Act
            var createTicketCommand = new CreateTicketCommand(factoryMock.Object, databaseMock.Object);

            // Assert
            Assert.IsNotNull(createTicketCommand);
        }

       [TestMethod]
       public void ThrowArgumentNullException_WhenFactoryIsNull()
       {
           // Arrange
           var databaseMock = new Mock<IDatabase>();
      
           // Act & Assert
           Assert.ThrowsException<ArgumentNullException>(() => new CreateTicketCommand(null, databaseMock.Object));
       }

        [TestMethod]
        public void ThrowsArgumentNullException_WhenDatabaseIsNull()
        {
           // Arrange
           var factoryMock = new Mock<ITravellerFactory>();

           // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new CreateTicketCommand(factoryMock.Object, null));
        }
    }
}
