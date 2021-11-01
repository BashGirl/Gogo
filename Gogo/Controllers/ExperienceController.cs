using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gogo.ModelData;
using Gogo.Service;

namespace Gogo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienceController : ControllerBase
    {
        private IExperienceService _experienceService; // queste tre righe sono la DI(dependency Injection)

        public ExperienceController(IExperienceService experienceService)
        {
          _experienceService = experienceService;
        }

        [HttpGet]
        public IEnumerable<ExperienceDTO> Get()
        {
            return _experienceService.GetAllDTO();
        }
    }
}
