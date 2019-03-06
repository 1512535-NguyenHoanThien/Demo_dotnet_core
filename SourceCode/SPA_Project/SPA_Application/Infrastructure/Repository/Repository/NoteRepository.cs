using SPA_Application.Common;
using SPA_Application.Domains.Entity;
using SPA_Application.Infrastructure.Context;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Infrastructure.Repository.Repository
{
    public class NoteRepository : INoteRepository
    {

        private SPAContext _context;
        public NoteRepository(SPAContext context)
        {
            _context = context;
        }

        public void Active(long id)
        {
            var room = _context.Notes.FirstOrDefault(p => p.Id == id);
            room.UpdatedEntity();

            _context.Notes.Update(room);
            _context.SaveChanges();
        }

        public void Add(Note note)
        {
            note.AddEntity();

            _context.Add(note);
            _context.SaveChanges();
        }

        public void InActive(long id)
        {
            var room = _context.Notes.FirstOrDefault(p => p.Id == id);
            room.DeleteEntity();

            _context.Notes.Update(room);
            _context.SaveChanges();
        }

        public void Update(Note note)
        {
            var _note = _context.Notes.FirstOrDefault(p => p.Id == note.Id);

            _note.UpdatedEntity();

            _context.Notes.Update(_note);
            _context.SaveChanges();
        }

        public IEnumerable<Note> GetNotesByStatus(Status status)
        {
            //return _context.Notes.Where(t => t.Status == status).ToList();
            return _context.Notes.ToList();
        }

        public Note GetNotesById(long id)
        {
            return _context.Notes.Where(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }

    }
}
