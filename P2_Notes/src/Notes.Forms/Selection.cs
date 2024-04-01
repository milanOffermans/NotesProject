using System;
using System.Windows.Forms;

namespace Notes.Forms
{
    public class Selection
    {
        public TreeNode CurrenTreeNode { get; private set; }

        public void Clear()
        {
            CurrenTreeNode = null;
        }

        public void Update(TreeNode treeNode)
        {
            if (treeNode is null)
            {
                throw new ArgumentNullException(nameof(treeNode));
            }

            if (CurrenTreeNode != treeNode)
            {
                CurrenTreeNode = treeNode;
            }
        }

        public bool IsSelected()
        {
            return CurrenTreeNode != null;
        }
    }
}