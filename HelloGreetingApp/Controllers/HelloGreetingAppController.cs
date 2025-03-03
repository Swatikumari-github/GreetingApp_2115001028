using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using ModelLayer;
using ModelLayer.Model;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Logging;
using HelloGreetingApp.Services;

namespace HelloGreetingApp.Controllers
{
   /// <summary>
   /// class providing api for helloGreetingApp
   /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HelloGreetingAppController : ControllerBase


    {
        private readonly ILogger<HelloGreetingAppController> _logger;
        private readonly IGreetingService _greetingService;
        public HelloGreetingAppController(ILogger<HelloGreetingAppController> logger, IGreetingService greetingService)
        {
            _logger = logger;
            _greetingService = greetingService;
        }
        /// <summary>
        /// get method to get the greeting message
        /// </summary>
        /// <returns>Hello,World!</returns>

        [HttpGet]
       public IActionResult Get()
        {
            var message = _greetingService.GetGreeting();

            _logger.LogInformation("GET method called.");
            ResponseModel<String> responseModel = new ResponseModel<string>();
         
            responseModel.Success = true;
            responseModel.Message = "Hello to greeting API EndPoint";
            responseModel.Data = message;
            return Ok(responseModel);
;       }

        [HttpPost]
        public IActionResult Post(RequestModel requestModel)
        {


            _logger.LogInformation("POST method called with Key: {Key} and Value: {Value}", requestModel.Key, requestModel.Value);
            ResponseModel<String> responseModel = new ResponseModel<string>();
            responseModel.Success = true;
            responseModel.Message = "Request Received Succesfully";
            responseModel.Data = $"Key:{requestModel.Key}, Value: {requestModel.Value}";
            return Ok(responseModel);



        }
        [HttpPut]
        public IActionResult Put(RequestModel requestModel)
        {
            _logger.LogInformation("PUT method called with Key: {Key} and Value: {Value}", requestModel.Key, requestModel.Value);
            ResponseModel<String> responseModel = new ResponseModel<string>();
       
            responseModel.Success = true;
            responseModel.Message = "Request Updated Successfully";
            responseModel.Data = $"Key: {requestModel.Key}, Value: {requestModel.Value}";

            return Ok(responseModel);

        }
        [HttpPatch]
        public IActionResult Patch(RequestModel requestModel)
        {
            _logger.LogInformation("PATCH method called with Key: {Key} and Value: {Value}", requestModel.Key, requestModel.Value);
            ResponseModel<String> responseModel = new ResponseModel<string>();
            responseModel.Success = true;
            responseModel.Message = "Request Updated Successfully";
            responseModel.Data = $"Key: {requestModel.Key}, Value: {requestModel.Value}";

            return Ok(responseModel);
        }
        [HttpDelete]
        public IActionResult Delete(RequestModel requestModel)
        {
            _logger.LogInformation("DELETE method called with Key: {Key}", requestModel.Key);
            ResponseModel<String> responseModel = new ResponseModel<string>();
            responseModel.Success = true;
            responseModel.Message = "Request Deleted Successfully";
            responseModel.Data = $"Deleted Key: {requestModel.Key}";

            return Ok(responseModel);
        }


    }
}
