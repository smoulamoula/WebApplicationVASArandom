using Microsoft.AspNetCore.Mvc;

namespace MyWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyApiController : ControllerBase
    {
        
        [HttpGet("echo/{text}")]
        public ActionResult<string>  Echo(string text)
        {
            return Ok(text);
        }

        
        [HttpGet("length/{text}")]
       
       public ActionResult<int> GetLength(string text)
        {
         
            
            return Ok(text.Length);
        }

       
        [HttpGet("celsius-to-fahrenheit/{celsius}")]
        public ActionResult<double> CelsiusToFahrenheit(double celsius)
       
        {
           
            double fahrenheit = (celsius * 9 / 5) + 32;

            return Ok(fahrenheit);
        }
    }
}
