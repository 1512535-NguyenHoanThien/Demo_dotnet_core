using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Context;

namespace SPA_Application.Controllers
{
    [Route("api")]

    public class HomeController : Controller
    {
        private SPAContext _context { set; get; }
        private IServiceService _serviceService { set; get; }
        private IOutletService _outletService { set; get; }

        public HomeController(SPAContext context,IServiceService serviceService,IOutletService outletService )
        {
            _context = context;
            _serviceService = serviceService;
            _outletService = outletService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("AllService")]
        public IActionResult GetALlService()
        {
            IEnumerable<Service> services = _context.Set<Service>().Select(row => row).ToList();
            return Json(services);
        }

        [HttpPost]
        [Route("AddService")]
        public IActionResult AddService(ServiceViewModel service)
        {
            _serviceService.Add(service);
            return Json("Successfull");
        }

      
    }
}