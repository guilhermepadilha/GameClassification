using System.Collections.Generic;
using System.Linq;
using GameClassification.Domain.Interfaces;
using GameClassification.Infra.Data.Repositories;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.ValueObjects;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{

    public class GamePointRepository : RepositoryBase<GamePoint>, IGamePointRepository
    {
        public IList<Score> GetAllPlayers(int gameId)
        {

            IList<Score> result = new List<Score>();

             var classif = (from p in GetAll()
                           where p.GameId == gameId
                           group p by new { p.PlayerId } into g
                           select new
                           {   
                               PlayerId = g.Key.PlayerId,
                               Balance = g.Sum(x => x.Win),
                               LastUpdateDate = g.OrderByDescending(x => x.TimeStamp).First().TimeStamp
                           }).ToList().OrderByDescending(p => p.Balance).Take(100);

            foreach (var item in classif)
            {
                result.Add(new Score { PlayerId = item.PlayerId, Balance = item.Balance, LastUpdateDate = item.LastUpdateDate});
            }

            return result;
        }
    }

}
