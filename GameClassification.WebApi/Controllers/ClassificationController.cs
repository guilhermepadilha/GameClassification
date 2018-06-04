using GameClassification.Application;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameClassification.WebApi.Controllers
{
    [RoutePrefix("api/classification")]
    public class ClassificationController : ApiController
    {

        
        [HttpGet]
        [Route("gamepoint/{gameId:int}")]
        public HttpResponseMessage LeaderBoard([FromUri]int gameId)
        {
            try
            {
                var _gamePointRepository = new GamePointRepository();


                return Request.CreateResponse(HttpStatusCode.OK , _gamePointRepository.GetAllPlayers(gameId));
                
            }
            catch (System.Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
