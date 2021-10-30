using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gogo.ModelData;

namespace Gogo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienceController : ControllerBase
    {
        public ExperienceController()
        {
        }

        [HttpGet]
        public IEnumerable<Experience> Get()
        {
            NotFound();
            return (IEnumerable<Experience>)Array.Empty<object>();
        }
    }
}
