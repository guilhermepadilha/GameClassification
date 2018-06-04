using EasyNetQ;
using GameClassification.Domain.Interfaces.Services;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace GameClassification.Application
{
    public static class SubscriberAppService 
    {
        public static IBus Bus { get; set; }

        public static void SubcribeGamePoint()
        {
            Bus = RabbitHutch.CreateBus("host=localhost");

            var _gamPointRepository = new GamePointRepository();

            Bus.SubscribeAsync<GamePoint>("GamePoint", async point =>
            {
                _gamPointRepository.Add(point);
            });

        }
    }
}

