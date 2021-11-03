using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gogo.ModelData;
using Gogo.Service;
using Microsoft.AspNetCore.Http;

namespace Gogo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienceController : ControllerBase
    {
        private IExperienceService _experienceService; // queste tre righe sono la DI(dependency Injection)
        private HttpContext context;

        public ExperienceController(IExperienceService experienceService, HttpContext httpContext)
        {
          _experienceService = experienceService;
            context = httpContext;
        }

        public object HttpServerUtility { get; private set; }

        [HttpGet]
        public IEnumerable<ExperienceDTO> Get()
        {
            return _experienceService.GetAllDTO(); 
        }

        [HttpPost]
        public IEnumerable<ExperienceDTO> Post([FromBody] model)
        {

            return _experienceService.GetAllDTO();
        }

    }

}