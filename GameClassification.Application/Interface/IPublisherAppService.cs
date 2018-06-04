using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IPublisherAppService
    {
        void PublishGamePoint(GamePoint gamePoint);
    }
}
