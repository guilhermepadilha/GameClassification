using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace GameClassification.Domain.Interfaces.Services
{
    public interface IGamePointService : IServiceBase<GamePoint>
    {
        IList<GamePoint> GetAllPlayers(int gameId);
    }
}
