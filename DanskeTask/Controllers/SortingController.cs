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
    public class SortingController : ControllerBase
    {
        private readonly SortingHandler sortingHandler;
        private IFileOperationsHandler fileOperationsHandler;

        public SortingController(IFileOperationsHandler fileOperationsHandlers) 
        {
            this.fileOperationsHandler = fileOperationsHandlers;    

            sortingHandler = new SortingHandler(fileOperationsHandlers);
        }

        [HttpPost]
        public IActionResult Post([FromBody] int[] unsortedNumbers)
        {
            if (unsortedNumbers.Length == 1 || unsortedNumbers.Length == 0)
            {
                return BadRequest("Not enough data to attempt sorting.");
            }

            if(unsortedNumbers.Length >= 10000)
            {
                return Accepted("Request was accepted but might take a while.");
            }

            fileOperationsHandler.ClearFileContents();

            sortingHandler.BubbleSort(unsortedNumbers);
            sortingHandler.InsertionSort(unsortedNumbers);

            return Ok("Sorting is finished, to view results call /FileData endpoint.");
        }

        [HttpGet]
        public IActionResult Get()
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
