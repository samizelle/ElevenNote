using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;

namespace ElevenNote.WebApi.Controllers
{
    [Authorize]
    public class NoteController : ApiController
    {
        public IHttpActionResult Get()
        {
            NoteService noteService = CreateNoteService();
            var notes = NoteService.GetNotes();
            return Ok(notes);
        }

        private NoteService CreateNoteService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new NoteService(userId);
            return noteService;
        }
    }
}
