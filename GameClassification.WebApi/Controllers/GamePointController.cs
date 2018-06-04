using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameClassification.WebApi.Controllers
{
    [RoutePrefix("api/gameClassification")]
    public class GamePointController : ApiController
    {

        private readonly IPublisherAppService _gamePointApp;
        private readonly ILeaderBoardAppService _leaderBoardApp;

        public GamePointController(ILeaderBoardAppService leaderBoardApp)
        {
            _leaderBoardApp = leaderBoardApp;
        }

        public GamePointController(IPublisherAppService gamePointApp)
        {
            _gamePointApp = gamePointApp;
        }

        [HttpPost]
        [Route("gamepoint")]
        public HttpResponseMessage PublishGamePoint([FromBody]GamePoint gamePoint)
        {
            try
            {
                gamePoint = new GamePoint
                {
                    PlayerId = 1,
                    GameId = 1,
                    Win = 10,
                    TimeStamp = DateTime.Now
                };
                _gamePointApp.PublishGamePoint(gamePoint);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (System.Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("gamepoint/classification/{id:int}")]
        public HttpResponseMessage LeaderBoard([FromUri]int gameId)
        {
            try
            {
              
                _leaderBoardApp.Classification(gameId);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (System.Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
