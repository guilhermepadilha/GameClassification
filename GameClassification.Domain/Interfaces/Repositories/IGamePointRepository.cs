using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.ValueObjects;

namespace GameClassification.Domain.Interfaces
{
    public interface IGamePointRepository : IRepositoryBase<GamePoint>
    {
        IList<Score> GetAllPlayers(int gameId);
    }
}
