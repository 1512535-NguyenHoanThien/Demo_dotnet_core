using SPA_Application.Domains.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Infrastructure.Repository.IRepository
{
    public interface INoteRepository
    {
        void Add(Note room);
        void Update(Note room);
        void InActive(long id);
        void Active(long id);

        IEnumerable<Note> GetNotes();
        IEnumerable<Note> GetNotesByStatus(Status status);
        Note GetNotesById(long id);
    }
}
