using SPA_Application.Domains.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Service.IService
{
    public interface INoteService
    {
        void Add(Note note);
        void Update(Note note);
        void Close(long id);
        void ReOpen(long id);

        IEnumerable<Note> GetNotes();
        IEnumerable<Note> GetNotesByStatus(Status status);
        Note GetNotesById(long id);
    }
}
