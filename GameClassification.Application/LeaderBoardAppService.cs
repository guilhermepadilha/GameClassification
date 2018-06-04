using EasyNetQ;
using GameClassification.Domain.Interfaces.Services;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace GameClassification.Application
{
    public class LeaderBoardAppService : AppServiceBase<GamePoint>, ILeaderBoardAppService
    {
        private readonly IGamePointService _gamePointService;

        public LeaderBoardAppService(IGamePointService gamePointService)
            :base(gamePointService)
        {
            _gamePointService = gamePointService;
        }

        public IList<GamePoint> Classification(int gameId)
        {
            return _gamePointService.GetAllPlayers(gameId);
        }
    }
}

