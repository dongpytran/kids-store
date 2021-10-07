using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KL.MeVaBe.BO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using KL.MeVaBe.BLL;
using Microsoft.AspNetCore.Cors;

namespace KL.MeVaBe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        public ChucVuController(ILogger<ChucVuController> logger, IWebHostEnvironment environment)
        {

        }
        [HttpGet]
        public NVCHUCVUBO GetById([FromQuery] string machucvu)
        {
            NVCHUCVUBLL nVCHUCVUBLL = new NVCHUCVUBLL();
            return nVCHUCVUBLL.LoadInfo(machucvu);
        }
    }
}
