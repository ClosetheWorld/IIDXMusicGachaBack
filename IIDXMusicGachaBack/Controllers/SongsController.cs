using System.Threading.Tasks;
using IIDXMusicGachaBack.Usecases;
using Microsoft.AspNetCore.Mvc;

namespace IIDXMusicGachaBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly IGetSongUsecase _getSong;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="getSong"></param>
        public SongsController(IGetSongUsecase getSong)
        {
            _getSong = getSong;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int count)
        {
            var response = await _getSong.GetAsync(count);

            return new OkObjectResult(response);
        }
    }
}