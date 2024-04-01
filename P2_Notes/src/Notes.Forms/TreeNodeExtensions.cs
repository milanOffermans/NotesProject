using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Notes.Forms
{
    public static class TreeNodeExtensions
    {
        public static Guid GetNoteId(this TreeNode treeNode)
        {
            if (treeNode is null)
            {
                throw new ArgumentNullException(nameof(treeNode));
            }

            var noteId = Guid.Parse(treeNode.Tag.ToString());
            return noteId;
        }
    }
}