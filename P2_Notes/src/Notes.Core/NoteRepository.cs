using System;
using System.Collections.Generic;

namespace Notes.Core
{
    public class NoteRepository : INoteRepository
    {
        private readonly List<Note> _notes;
        private readonly IDataStore<List<Note>> _store;

        public NoteRepository(string dataFilePath)
        {
            _store = new FileStore<List<Note>>(dataFilePath);
            _notes = _store.Read();
        }

        public void AddNestedNote(Note note, Guid parentId)
        {
            var parentNote = GetNote(parentId);
            parentNote.Children.Add(note);

            Save();
        }

        public void AddNote(Note note)
        {
            if (note is null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            _notes.Add(note);
            Save();
        }

        public Note GetNote(Guid noteId)
        {
            var note = GetNoteIntern(noteId, _notes);
            return note;
        }

        public IEnumerable<Note> GetNotes()
        {
            return _notes;
        }

        public void RemoveNote(Note note)
        {
            if (note.ParentId != null)
            {
                var parentNote = GetNote(note.ParentId.Value);
                parentNote.Children.Remove(note);
            }
            else
            {
                _notes.Remove(note);
            }

            Save();
        }

        public void UpdateContentById(Guid noteId, string content)
        {
            var note = GetNote(noteId);
            if (note != null)
            {
                note.Content = content;
            }
            Save();
        }

        public void UpdateTitleById(Guid noteId, string title)
        {
            var note = GetNote(noteId);
            if (note != null)
            {
                note.Title = title;
            }
            Save();
        }

        private static Note GetNoteIntern(Guid noteId, IEnumerable<Note> notes)
        {
            Note result = null;

            foreach (var note in notes)
            {
                if (note.Id == noteId)
                {
                    result = note;
                    break;
                }

                if (note.Children.Count != 0)
                {
                    result = GetNoteIntern(noteId, note.Children);
                    if (result != null)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        private void Save()
        {
            _store.Write(_notes);
        }
    }
}