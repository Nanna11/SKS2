using System;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Headhack.SKS.Package.Services.Attributes;
using Headhack.SKS.Package.Services.DTOs;

namespace Headhack.SKS.Package.Services.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class WarehouseApiController : Controller
    { 
        /// <summary>
        /// Exports the hierarchy of Warehouse and Truck objects. 
        /// </summary>
        
        /// <response code="200">Successful response</response>
        /// <response code="400">An error occurred loading.</response>
        /// <response code="404">No hierarchy loaded yet.</response>
        [HttpGet]
        [Route("/api/warehouse")]
        [ValidateModelState]
        [SwaggerOperation("ExportWarehouses")]
        [SwaggerResponse(statusCode: 200, type: typeof(Warehouse), description: "Successful response")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "An error occurred loading.")]
        public virtual IActionResult ExportWarehouses()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Warehouse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"code\" : \"FRA01\",\n  \"description\" : \"Main Warehouse Germany\",\n  \"duration\" : 10,\n  \"nextHops\" : [ {\n    \"code\" : \"FRA02\",\n    \"description\" : \"Regional Warehouse Frankfurt\",\n    \"duration\" : 5,\n    \"nextHops\" : [ {\n      \"code\" : \"BER01\",\n      \"description\" : \"Warehouse Berlin\",\n      \"duration\" : 22,\n      \"nextHops\" : [ {\n        \"code\" : \"VIE01\",\n        \"description\" : \"Warehouse Wien\",\n        \"duration\" : 25,\n        \"nextHops\" : [ ],\n        \"trucks\" : [ {\n          \"code\" : \"VIE-T12345\",\n          \"numberPlate\" : \"W-123123\",\n          \"latitude\" : 12,\n          \"longitude\" : 12,\n          \"radius\" : 12,\n          \"duration\" : 5\n        } ]\n      } ],\n      \"trucks\" : [ {\n        \"code\" : \"BER-T12345\",\n        \"numberPlate\" : \"M-123123\",\n        \"latitude\" : 12,\n        \"longitude\" : 12,\n        \"radius\" : 12,\n        \"duration\" : 5\n      }, {\n        \"code\" : \"BER-T11111\",\n        \"numberPlate\" : \"M-456456\",\n        \"latitude\" : 13,\n        \"longitude\" : 13,\n        \"radius\" : 5,\n        \"duration\" : 10\n      } ]\n    } ],\n    \"trucks\" : [ ]\n  } ],\n  \"trucks\" : [ ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Warehouse>(exampleJson)
            : default(Warehouse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Imports a hierarchy of Warehouse and Truck objects. 
        /// </summary>
        
        /// <param name="rootWarehouse"></param>
        /// <response code="200">Successfully loaded.</response>
        /// <response code="400">The operation failed due to an error.</response>
        [HttpPost]
        [Route("/api/warehouse")]
        [ValidateModelState]
        [SwaggerOperation("ImportWarehouses")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "The operation failed due to an error.")]
        public virtual IActionResult ImportWarehouses([FromBody]Warehouse rootWarehouse)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));


            throw new NotImplementedException();
        }
    }
}
