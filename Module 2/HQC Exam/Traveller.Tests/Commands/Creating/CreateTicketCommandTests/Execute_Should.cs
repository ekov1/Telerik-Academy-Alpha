using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Commands.Creating;
using Traveller.Core.Contracts;
using Traveller.Core.Repository;

namespace Traveller.Tests.Commands.Creating.CreateTicketCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void ShouldReturnArgumentException_WhenParametersAreInvalid()
        {
            // Arrange
            var factoryMock = new Mock<ITravellerFactory>();
            var databaseMock = new Mock<IDatabase>();

            var parameters = new List<string> {null, null};

            var createTicketCommand = new CreateTicketCommand(factoryMock.Object, databaseMock.Object);

            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => createTicketCommand.Execute(parameters));
        }

        //we can add more tests like if it adds stuff to database and the exact message it returns when parameters are correct, but I am running low on time
    }
}
