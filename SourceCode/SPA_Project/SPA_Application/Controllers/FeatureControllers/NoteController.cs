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
    public class NoteController : Controller
    {
        private INoteService _NoteService;

        public NoteController(INoteService NoteService)
        {
            _NoteService = NoteService;
        }

        [Route("add")]
        [HttpPost]
        public IActionResult OpenNewNote(Note Note)
        {
            try
            {
                _NoteService.Add(Note);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("close")]
        [HttpPut]
        public IActionResult CloseNote(long id)
        {
            try
            {
                _NoteService.Close(id);
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
                _NoteService.ReOpen(id);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateNote(Note Note)
        {
            try
            {
                _NoteService.Update(Note);
                return Ok("Successfull");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("list")]
        [HttpGet]
        public IActionResult GetNotes()
        {
            try
            {
                return Ok(_NoteService.GetNotes());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("status")]
        [HttpGet]
        public IActionResult GetNotesByStatus(Status status)
        {
            try
            {

                return Ok(_NoteService.GetNotesByStatus(status));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("Note")]
        [HttpGet]
        public IActionResult GetNotesById(long id)
        {
            try
            {
                return Ok(_NoteService.GetNotesById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}