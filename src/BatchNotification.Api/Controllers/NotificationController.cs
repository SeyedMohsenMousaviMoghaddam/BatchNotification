using Microsoft.AspNetCore.Mvc;
using System.Threading;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BatchNotification.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ApiControllerBase
    {

        private readonly ILogger<NotificationController> _logger;

        public NotificationController(ILogger<NotificationController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "send-notification")]
        public async Task<ActionResult> SendNotification([FromBody] SendNotificationRequest command, CancellationToken cancellationToken)
        {
            return await Mediator.Send(command);
        }
    }
}