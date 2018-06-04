using EasyNetQ;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using System;

namespace GameClassification.Application
{
    public class PublisherAppService : IPublisherAppService
    {
        public IBus Bus { get; set; }
        public PublisherAppService()
        {
            Bus = RabbitHutch.CreateBus("host=localhost");
        }
        public void PublishGamePoint(GamePoint gamePoint)
        {

            Bus.Publish<GamePoint>(new GamePoint
            {
                PlayerId = gamePoint.PlayerId,
                GameId = gamePoint.GameId,
                Win = gamePoint.Win,
                TimeStamp = DateTime.Now
            });
        }
    }
}

