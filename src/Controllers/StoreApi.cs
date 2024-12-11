/*
 * Petstore Demo API
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class StoreApiController : ControllerBase
    { 
        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with positive integer value.\\ \\ Negative or non-integer values will generate API errors</remarks>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <response code="200">Everything went well!</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpDelete]
        [Route("/your_company_domain/Demo_API/1.0.0/store/order/{orderId}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteOrder")]
        [SwaggerResponse(statusCode: 200, type: typeof(SuccessModel), description: "Everything went well!")]
        public virtual IActionResult DeleteOrder([FromRoute][Required]long? orderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SuccessModel));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"message\" : \"message\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SuccessModel>(exampleJson)
                        : default(SuccessModel);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>Returns a map of status codes to quantities</remarks>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("/your_company_domain/Demo_API/1.0.0/store/inventory")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInventory")]
        [SwaggerResponse(statusCode: 200, type: typeof(Dictionary<string, int?>), description: "successful operation")]
        public virtual IActionResult GetInventory()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Dictionary<string, int?>));
            string exampleJson = null;
            exampleJson = "{\n  \"key\" : 0\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Dictionary<string, int?>>(exampleJson)
                        : default(Dictionary<string, int?>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.\\ \\ Other values will generated exceptions</remarks>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpGet]
        [Route("/your_company_domain/Demo_API/1.0.0/store/order/{orderId}")]
        [ValidateModelState]
        [SwaggerOperation("GetOrderById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        public virtual IActionResult GetOrderById([FromRoute][Required][Range(1, 10)]long? orderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Order));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Order>(exampleJson)
                        : default(Order);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid Order</response>
        [HttpPost]
        [Route("/your_company_domain/Demo_API/1.0.0/store/order")]
        [ValidateModelState]
        [SwaggerOperation("PlaceOrder")]
        [Consumes("application/json")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        public virtual IActionResult PlaceOrder([FromBody]Order body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Order));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Order>(exampleJson)
                        : default(Order);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
