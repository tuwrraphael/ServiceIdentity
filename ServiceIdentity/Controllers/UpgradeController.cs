using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceIdentity.Controllers
{
    [Route("api/[controller]")]
    public class UpgradeController : Controller
    {
        private readonly IServiceScopeFactory serviceScopeFactory;

        public UpgradeController(IServiceScopeFactory serviceScopeFactory)
        {
            this.serviceScopeFactory = serviceScopeFactory;
        }

        [HttpPost]
        public IActionResult Upgrade()
        {
            DatabaseSetup.InitializeDatabase(serviceScopeFactory, false);
            return Ok();
        }
    }
}
