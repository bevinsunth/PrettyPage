using Microsoft.AspNetCore.Mvc;
using PrettyPage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrettyPageController : ControllerBase
    {
        private readonly IHomePageService _homePageService;

        public PrettyPageController(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        // GET: api/<PrettyPageController>
        [HttpGet]
        [Route("/homepage")]
        public HomePage Get()
        {
            return _homePageService.GetContent() ;
        }
    }
}
