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

        public ExperienceController(IExperienceService experienceService)
        {
          _experienceService = experienceService;
        }

        public object HttpServerUtility { get; private set; }

        [HttpGet]
        public ActionResult<IEnumerable<ExperienceDTO>> Get()
        {
            return _experienceService.GetAllDTO(); 
        }

        [HttpPost]
        public IEnumerable<ExperienceDTO> Post([FromBody] ExperienceDTO experienceDTO)
        {
            _experienceService.AddToList(experienceDTO);

            return _experienceService.GetAllDTO();
        }  

    }

}