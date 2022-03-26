using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using System.IO;

namespace VehicleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDataController : ControllerBase
    {  
        [HttpPost]
        public ActionResult Post(object value)
        {               
            string strJSON = JsonSerializer.Serialize(value);
            //the json file is saved to C drive - in folder called JsonFile but however depending on where ever we would like to save it we can always cahnge the location
            string path = "C:\\JsonFile\\";
            System.IO.File.WriteAllText(path + "CarDetails.json", strJSON);  
            return Ok(new { Result = "Saved" });
        }
    }
}
