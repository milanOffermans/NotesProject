using System;
using System.Collections.Generic;

namespace Notes.Core
{
    public class Note
    {
        public Note()
        {
        }

        public Note(string title, Guid? parentId = null)
        {
            Id = Guid.NewGuid();
            Title = title;
            ParentId = parentId;
        }

        public Note(string title, string content, Guid? parentId = null)
        {
            Id = Guid.NewGuid();
            Title = title;
            Content = content;
            ParentId = parentId;
        }

        public List<Note> Children { get; set; } = new List<Note>();

        public string Content { get; set; }

        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        public string Title { get; set; }
    }
}
