using GameClassification.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface ISubscriberAppService : IAppServiceBase<GamePoint>
    {
        void SubcribeGamePoint();
    }
}
