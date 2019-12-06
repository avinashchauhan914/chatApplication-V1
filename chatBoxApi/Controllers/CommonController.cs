using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatBoxApi.Bussiness_Model;
using chatBoxApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chatBoxApi.Controllers
{
    [Route("api/CommonController")]
    [ApiController]
    public class CommonController : ControllerBase
    {
      private readonly commonBusiness common;

      public CommonController(commonBusiness common)
      {
        this.common = common;
      }
    [HttpGet]
    [Route("getStudentData")]
    public IActionResult GetStudentData()
    {
      return Ok();
    }

    [HttpPost]
        [Route("saveRegistration")]
        public void SaveRegistration([FromBody]RegistrationModel registrationModel)
        {
          this.common.SaveRegistration(registrationModel);
        }
    }
}