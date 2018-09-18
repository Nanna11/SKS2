using System;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Headhack.SKS.Package.Services.Attributes;
using Headhack.SKS.Package.Services.DTOs;


namespace Headhack.SKS.Package.Services.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ParcelApiController : Controller
    { 
        /// <summary>
        /// Report that a Parcel has been delivered at it&#39;s final destination address. 
        /// </summary>
        
        /// <param name="trackingId">The tracking ID of the parcel. E.g. PYJRB4HZ6 </param>
        /// <response code="200">Successfully reported hop.</response>
        /// <response code="400">The operation failed due to an error.</response>
        /// <response code="404">Parcel does not exist with this tracking ID. </response>
        [HttpPost]
        [Route("/api/parcel/{trackingId}/reportDelivery/")]
        [ValidateModelState]
        [SwaggerOperation("ReportParcelDelivery")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "The operation failed due to an error.")]
        public virtual IActionResult ReportParcelDelivery([FromRoute][Required][RegularExpression("^[A-Z0-9]{9}$")]string trackingId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Report that a Parcel has arrived at a certain hop either Warehouse or Truck.
        /// </summary>
        
        /// <param name="trackingId">The tracking ID of the parcel. E.g. PYJRB4HZ6 </param>
        /// <param name="code">The Code of the hop (warehouse or Truck). </param>
        /// <response code="200">Successfully reported hop.</response>
        /// <response code="500">An error occured.</response>
        [HttpPost]
        [Route("/api/parcel/{trackingId}/reportHop/{code}")]
        [ValidateModelState]
        [SwaggerOperation("ReportParcelHop")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "An error occured.")]
        public virtual IActionResult ReportParcelHop([FromRoute][Required][RegularExpression("^[A-Z0-9]{9}$")]string trackingId, [FromRoute][Required]string code)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));


            throw new NotImplementedException();
        }

        /// <summary>
        /// Submit a new parcel to the logistics service. 
        /// </summary>
        
        /// <param name="newParcel"></param>
        /// <response code="200">Successfully submitted the new parcel</response>
        /// <response code="400">The operation failed due to an error.</response>
        [HttpPost]
        [Route("/api/parcel")]
        [ValidateModelState]
        [SwaggerOperation("SubmitParcel")]
        [SwaggerResponse(statusCode: 200, type: typeof(NewParcelInfo), description: "Successfully submitted the new parcel")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "The operation failed due to an error.")]
        public virtual IActionResult SubmitParcel([FromBody]Parcel newParcel)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(NewParcelInfo));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"trackingId\" : \"PYJRB4HZ6\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<NewParcelInfo>(exampleJson)
            : default(NewParcelInfo);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find the latest tracking state of a parcel by its tracking ID. 
        /// </summary>
        
        /// <param name="trackingId">The tracking ID of the parcel. E.g. PYJRB4HZ6 </param>
        /// <response code="200">Parcel exists, here&#39;s the tracking information.</response>
        /// <response code="400">The operation failed due to an error.</response>
        /// <response code="404">Parcel does not exist with this tracking ID.</response>
        [HttpGet]
        [Route("/api/parcel/{trackingId}")]
        [ValidateModelState]
        [SwaggerOperation("TrackParcel")]
        [SwaggerResponse(statusCode: 200, type: typeof(TrackingInformation), description: "Parcel exists, here&#39;s the tracking information.")]
        [SwaggerResponse(statusCode: 400, type: typeof(Error), description: "The operation failed due to an error.")]
        public virtual IActionResult TrackParcel([FromRoute][Required][RegularExpression("^[A-Z0-9]{9}$")]string trackingId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TrackingInformation));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\n  \"state\" : \"InTransport\",\n  \"visitedHops\" : [ {\n    \"code\" : \"VIE01\",\n    \"dateTime\" : \"2016-10-25T07:44:00.00Z\"\n  }, {\n    \"code\" : \"FRA02\",\n    \"dateTime\" : \"2016-10-25T09:20:00.00Z\"\n  } ],\n  \"futureHops\" : [ {\n    \"code\" : \"BER01\",\n    \"dateTime\" : \"2016-10-25T16:00:00.00Z\"\n  }, {\n    \"code\" : \"BER-T12345\",\n    \"dateTime\" : \"2016-10-25T18:00:00.00Z\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TrackingInformation>(exampleJson)
            : default(TrackingInformation);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
