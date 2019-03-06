using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;

namespace SPA_Application.Controllers.FeatureControllers
{
    [Route("api/[controller]")]
    public class OutletsController : Controller
    {
        private IOutletService _outletService;

        public OutletsController(IOutletService outletService)
        {
            _outletService = outletService;
        }

        [Route("open")]
        [HttpPost]
        public IActionResult OpenNewOutlet([FromBody] OutletViewModel outlet)
        {
            try
            {
                _outletService.Open(outlet);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("close")]
        [HttpPut]
        public IActionResult CloseOutlet(long id)
        {
            try
            {
                _outletService.Close(id);
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
                _outletService.ReOpen(id);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateOutlet([FromBody] OutletViewModel outlet)
        {
            try
            {
                _outletService.Update(outlet);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("list")]
        [HttpGet]
        public IActionResult GetOutlets()
        {
            try
            {
                return Ok(_outletService.GetOutlets());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("status")]
        [HttpGet]
        public IActionResult GetOutletsByStatus(bool status)
        {
            try
            {

                return Ok(_outletService.GetOutletsByStatus(status));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("name")]
        [HttpGet]
        public IActionResult GetOutletsByName(string name)
        {
            try
            {
                return Ok(_outletService.GetOutletsByName(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("picked")]
        [HttpGet]
        public IActionResult GetOutletsById(long id)
        {
            try
            {
                return Ok(_outletService.GetOutletsById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("select")]
        [HttpGet]
        public IActionResult GetOutletSelected(long id)
        {
            IEnumerable<OutletSelectViewModel> outletSelect = _outletService.GetOutletsSelect();
            if (outletSelect == null)
            {
                return NotFound();
            }
            else return Ok(outletSelect);
        }
    }
}