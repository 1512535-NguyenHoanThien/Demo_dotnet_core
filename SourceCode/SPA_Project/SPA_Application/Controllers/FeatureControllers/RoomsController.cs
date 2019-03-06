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
    public class RoomsController : Controller
    {
        private IRoomService _roomService;

        public RoomsController(IRoomService RoomService)
        {
            _roomService = RoomService;
        }

        [Route("add")]
        [HttpPost]
        public IActionResult OpenNewRoom(Room Room)
        {
            try
            {
                _roomService.Add(Room);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("close")]
        [HttpPut]
        public IActionResult CloseRoom(long id)
        {
            try
            {
                _roomService.Close(id);
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
                _roomService.ReOpen(id);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            try
            {
                _roomService.Update(room);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("list")]
        [HttpGet]
        public IActionResult GetRooms()
        {
            try
            {
                return Ok(_roomService.GetRooms());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("status")]
        [HttpGet]
        public IActionResult GetRoomsByStatus(Status status)
        {
            try
            {

                return Ok(_roomService.GetRoomsByStatus(status));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        [Route("Room")]
        [HttpGet]
        public IActionResult GetRoomsById(long id)
        {
            try
            {
                return Ok(_roomService.GetRoomsById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}