using GameClassification.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface ILeaderBoardAppService : IAppServiceBase<GamePoint>
    {
        IList<GamePoint> Classification(int gameId);
    }
}
