using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System;
using DanskeTask.Sorting;
using System.Diagnostics;
using DanskeTask.Interfaces;

namespace DanskeTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileDataController: ControllerBase
    {
        private IFileOperationsHandler fileWriteHandler;

        public FileDataController(IFileOperationsHandler fileOperationsHandlers)
        {
            this.fileWriteHandler = fileOperationsHandlers;

        }

        [HttpGet]
        public IActionResult Get()
        {
            string result = fileWriteHandler.ReadFromFile();

            if(result == null)
            {
                return NotFound("Couldn't load data."); 
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return StatusCode(405, "This endpoint is not allowed.");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return StatusCode(405, "This endpoint is not allowed.");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return StatusCode(405, "This endpoint is not allowed.");
        }

        [HttpPatch]
        public IActionResult Patch()
        {
            return StatusCode(405, "This endpoint is not allowed.");
        }

        [HttpOptions]
        public IActionResult Options()
        {
            return StatusCode(405, "This endpoint is not allowed.");
        }
    }
}
