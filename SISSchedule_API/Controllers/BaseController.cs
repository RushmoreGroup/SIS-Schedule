using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISSchedule_Utilities;
namespace SISSchedule_API.Controllers
{
    public class BaseController : ControllerBase
    {
       
        protected ServiceResponse<T> BuildServiceResponse<T>(T value, string message, ServiceCode code, int id = 0, string token = "")
        {
            return new ServiceResponse<T>
            {
                Code = code,
                Message = message,
                Result = value,
                Token = token,
                Id = id
            };
        }

      
       

    }
}
