using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Controllers.FeatureControllers
{
    [Route("api/[controller]")]
    public class BedsController : Controller
    {
        private IBedService _bedService;

        public BedsController(IBedService bedService)
        {
            _bedService = bedService;
        }

        [Route("add")]
        [HttpPost]
        public IActionResult OpenNewBed(Bed bed)
        {
            try
            {
                _bedService.Add(bed);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("close")]
        [HttpPut]
        public IActionResult CloseBed(long id)
        {
            try
            {
                _bedService.Close(id);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("reopen")]
        [HttpPut]
        public IActionResult ReOpen(long id)
        {
            try
            {
                _bedService.ReOpen(id);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateBed(Bed bed)
        {
            try
            {
                _bedService.Update(bed);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("list")]
        [HttpGet]
        public IActionResult GetBeds()
        {
            try
            {
                return Ok(_bedService.GetBeds());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("status")]
        [HttpGet]
        public IActionResult GetBedsByStatus(Status status)
        {
            try
            {

                return Ok(_bedService.GetBedsByStatus(status));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("Bed")]
        [HttpGet]
        public IActionResult GetBedsById(long id)
        {
            try
            {
                return Ok(_bedService.GetBedsById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}