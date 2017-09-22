using Ninject.Modules;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Commands.Process;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Contracts.FactoryContracts;
using Traveller.Core.Contracts.ProviderContracts;
using Traveller.Core.Factories;
using Traveller.Core.Providers;
using Traveller.Core.Repository;
using Traveller.Models;
using Traveller.Models.Abstractions;

namespace Traveller.Ninject
{
    public class TravellerModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEngine>().To<Engine>().InSingletonScope();

            this.Bind<IDatabase>().To<Database>().InSingletonScope();
            this.Bind<IParser>().To<CommandParser>().InSingletonScope();

            this.Bind<IReader>().To<ConsoleReader>().InSingletonScope();
            this.Bind<IWriter>().To<ConsoleWriter>().InSingletonScope();
            this.Bind<ICommandProcessor>().To<CommandProcessor>();

            this.Bind<ICommandFactory>().To<CommandFactory>().InSingletonScope();
            this.Bind<ITravellerFactory>().To<TravellerFactory>().InSingletonScope();

            // adding commands
            this.Bind<ICommand>().To<CreateAirplaneCommand>().Named("createairplane");
            this.Bind<ICommand>().To<CreateBusCommand>().Named("createbus");
            this.Bind<ICommand>().To<CreateTrainCommand>().Named("createtrain");
            this.Bind<ICommand>().To<CreateJourneyCommand>().Named("createjourney");
            this.Bind<ICommand>().To<CreateTicketCommand>().Named("createticket");

           // listing commands
            this.Bind<ICommand>().To<ListJourneysCommand>().Named("listjourneys");
            this.Bind<ICommand>().To<ListTicketsCommand>().Named("listtickets");
            this.Bind<ICommand>().To<ListVehiclesCommand>().Named("listvehicles");

            // Needed for unit testing
            this.Bind<IJourney>().To<Journey>();
        }
    }
}
