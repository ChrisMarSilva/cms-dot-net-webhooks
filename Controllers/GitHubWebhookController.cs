using Microsoft.AspNetCore.Mvc;

namespace CMS_DotNet_Teste_WebAPI_WebHooks.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GitHubWebhookController : ControllerBase
{
    //[GitHubWebHook]
    //public IActionResult GitHubHandler(JObject data)
    //{
    //    var result = JsonConvert.SerializeObject(data);

    //    return Ok();
    //}

    [HttpPost]
    public IActionResult Pushed(dynamic payload)
    {
        return Ok();
    }
}
