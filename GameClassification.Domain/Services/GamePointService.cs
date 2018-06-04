using System.Collections.Generic;
using GameClassification.Domain.Interfaces;
using GameClassification.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Entities;

namespace GameClassification.Domain.Services
{
    public class GamePointService : ServiceBase<GamePoint>, IGamePointService
    {
        public readonly IGamePointRepository _gamePointRepository;

        public GamePointService(IGamePointRepository gamePointRepository)
            : base(gamePointRepository)
        {
            _gamePointRepository = gamePointRepository;
        }

        public IList<GamePoint> GetAllPlayers(int gameId)
        {
            var t = _gamePointRepository.GetAllPlayers(gameId);
            return null;/*_gamePointRepository.GetAllPlayers(gameId);*/
        }
    }
}
