using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenAIClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using webapi.Models.Request;
using webapi.Models.Response;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class OpenAIController : Controller
    {
        readonly string API_KEY;
        readonly IOpenAIClient _client;

        public OpenAIController(IConfiguration configuration, IOpenAIClient client )
        {
            API_KEY = configuration.GetSection("OPENAI_API_KEY")?.Value??string.Empty;
            _client = client;
        }
          

        [HttpPost]
        public async Task<IActionResult> GenerateImage([FromBody] ImageGenRequest input)
        {
            var resp = await _client.GetImagesGenerations("Bearer " + API_KEY, input);
             
            return Json(resp);
        }
    }
}
