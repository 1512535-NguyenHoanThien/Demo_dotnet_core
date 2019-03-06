using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;

namespace SPA_Application.Controllers.FeatureControllers
{
    [Route("api/[controller]")]
    public class ServicesController : Controller
    {
        private IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }


        [Route("open")]
        [HttpPost]
        public IActionResult AddService([FromBody] ServiceViewModel serviceViewModel)
        {
            try
            {
                _serviceService.Add(serviceViewModel);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetAllServices()
        {
            IEnumerable<ServiceViewModel> serviceViewModels = _serviceService.GetServices();
            if (serviceViewModels == null)
            {
                return NotFound();
            }
            else return Ok(serviceViewModels);
        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateService([FromBody] ServiceViewModel serviceViewModel)
        {
            try
            {
                _serviceService.Update(serviceViewModel);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("picked")]
        public IActionResult GetServicesPicked(long id)
        {
           ServicePickedViewModel servicePicked= _serviceService.GetServicePicked(id);
            if (servicePicked == null)
            {
                return NotFound();
            }
            else return Ok(servicePicked);
        }


    }
}