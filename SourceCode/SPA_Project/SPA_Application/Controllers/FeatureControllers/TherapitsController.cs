//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using SPA_Application.Domains.Service.IService;
//using SPA_Application.Domains.ViewModel;
//using static SPA_Application.Common.EntityHelper;

//namespace SPA_Application.Controllers.FeatureControllers
//{
//    [Route("api/[controller]")]
//    public class TherapitsController : Controller
//    {

//        private ITherapitService _therapitService;
//        public TherapitsController(ITherapitService therapitService)
//        {
//            _therapitService = therapitService;
//        }

//        [Route("add")]
//        [HttpPost]
//        public IActionResult Add(TherapitViewModel therapitViewModel)
//        {
//            try
//            {
//                _therapitService.Add(therapitViewModel);
//                return Ok("Successfull");
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("therapits")]
//        [HttpGet]
//        public IActionResult GetTherapit()
//        {
//            try
//            {
                
//                return Ok(_therapitService.GetTherapits());
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [Route("email")]
//        [HttpGet]
//        public IActionResult GetTherapitByEmail(string email)
//        {
//            try
//            {

//                return Ok(_therapitService.GetTherapitByEmail(email ));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [Route("firstName")]
//        [HttpGet]
//        public IActionResult GetTherapitByFirstName(string firstName)
//        {
//            try
//            {

//                return Ok(_therapitService.GetTherapitByFirstName(firstName));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [Route("gender")]
//        [HttpGet]
//        public IActionResult GetTherapitByGender(Gender gender)
//        {
//            try
//            {

//                return Ok(_therapitService.GetTherapitByGender(gender));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [Route("therapit")]
//        [HttpGet]
//        public IActionResult GetTherapitById(long id)
//        {
//            try
//            {

//                return Ok(_therapitService.GetTherapitById(id));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("lastName")]
//        [HttpGet]
//        public IActionResult GetTherapitByLastName(string lastName)
//        {
//            try
//            {

//                return Ok(_therapitService.GetTherapitByLastName(lastName));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("phone")]
//        [HttpGet]
//        public IActionResult GetTherapitByPhone(string phone)
//        {
//            try
//            {

//                return Ok(_therapitService.GetTherapitByPhone(phone));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }


//        [Route("outjob")]
//        [HttpPut]
//        public IActionResult OutJob(long id)
//        {
//            try
//            {
//                _therapitService.OutJob(id);
//                return Ok("Successfull");
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("rework")]
//        [HttpPut]
//        public IActionResult ReWork(long id)
//        {
//            try
//            {
//                _therapitService.ReWork(id);
//                return Ok("Successfull");
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [Route("update")]
//        [HttpPut]
//        public IActionResult Update(TherapitViewModel therapit)
//        {
//            try
//            {
//                _therapitService.Update(therapit);
//                return Ok("Successfull");
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//    }
//}