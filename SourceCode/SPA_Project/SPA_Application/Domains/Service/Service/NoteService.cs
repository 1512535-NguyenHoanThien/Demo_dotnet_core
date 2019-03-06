using SPA_Application.Common;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Service.Service
{
    public class NoteService : INoteService
    {
        private INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void Add(Note note)
        {
            _noteRepository.Add(note);
        }

        public void Close(long id)
        {
            _noteRepository.InActive(id);
        }

        public IEnumerable<Note> GetNotes()
        {
            return _noteRepository.GetNotes();
        }

        public Note GetNotesById(long id)
        {
            return _noteRepository.GetNotesById(id);
        }

        public IEnumerable<Note> GetNotesByStatus(Status status)
        {
            return _noteRepository.GetNotesByStatus(status);
        }

        public void ReOpen(long id)
        {
            _noteRepository.Active(id);
        }

        public void Update(Note note)
        {
            _noteRepository.Update(note);
        }
    }
}
