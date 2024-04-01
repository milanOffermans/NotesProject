using System;
using System.Collections.Generic;

namespace Notes.Core
{
    public interface INoteRepository
    {
        void AddNestedNote(Note note, Guid parentId);

        void AddNote(Note note);

        Note GetNote(Guid noteId);

        IEnumerable<Note> GetNotes();

        void RemoveNote(Note note);

        void UpdateContentById(Guid noteId, string content);

        void UpdateTitleById(Guid noteId, string title);
    }
}
