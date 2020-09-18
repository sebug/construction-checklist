using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using construction_checklist.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace construction_checklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmConstructionController : ControllerBase
    {
        public bool Post([FromForm] ConstructionChecklist checklist)
        {
            return true;
        }
    }
}