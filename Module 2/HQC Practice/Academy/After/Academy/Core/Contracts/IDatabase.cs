using System.Collections.Generic;
using Academy.Models.Contracts;

namespace Academy.Core.Contracts
{
    public interface IDatabase
    {
        IList<ISeason> Seasons { get; }

        IList<IStudent> Students { get; }

        IList<ITrainer> Trainers { get; }
    }
}
