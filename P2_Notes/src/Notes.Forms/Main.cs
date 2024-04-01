using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Notes.Core;

namespace Notes.Forms
{
    /// <summary>
    /// TODO:
    /// ✔ 1. UpdateById splitsen naar 2 methodes. Een voor het updaten van de titel, andere voor het updaten van de content;
    /// ✔ 2. Het data bestand pad via AppSettings opvoeren/geven.
    /// ✔ 3. Controleren of alles werkt, alle functies van de app.
    /// ✔ 4. Cleanup van de app: leesbaarheid, verwijderen van de ongebruikte code, benamingen.// vragen naar aanpak van jos en George
    /// ✔ 5. Mooi icoon toevoegen aan de app.
    /// ✔ 6. Publish op de Desktop bvb.
    /// </summary>
    ///
    public partial class Main : Form
    {
        private readonly INoteRepository _repository = new NoteRepository(ConfigurationManager.AppSettings["dataFilePath"]);
        private readonly Selection _selection = new Selection();

        public Main()
        {
            InitializeComponent();
            SubscribeEventListeners();
            RefreshData();
            TrySelectFirstNode();
        }

        #region Core Logic

        private static void ConvertNotesToTreeNodes(IEnumerable<Note> notesInput, ICollection<TreeNode> outputTreeNodes)
        {
            foreach (var note in notesInput)
            {
                var treeNode = new TreeNode
                {
                    Text = note.Title,
                    Tag = note.Id.ToString(),
                    Name = note.Id.ToString()
                };

                outputTreeNodes.Add(treeNode);

                if (note.Children.Count != 0)
                {
                    var nodes = new List<TreeNode>();
                    ConvertNotesToTreeNodes(note.Children, nodes);

                    treeNode.Nodes.AddRange(nodes.ToArray());
                }
            }
        }

        private TreeNode GetClickedNode()
        {
            var point = treeView.PointToClient(Cursor.Position);
            var hitTest = treeView.HitTest(point);

            return hitTest.Node;
        }

        private void ProcessSelectionChange(TreeNode node)
        {
            if (node is null)
            {
                return;
            }

            treeView.SelectedNode = node;
            _selection.Update(node);

            UpdateSelectedNoteDetails(node);
        }

        private void RefreshData()
        {
            var notes = _repository.GetNotes();
            var treeNodes = new List<TreeNode>();

            ConvertNotesToTreeNodes(notes, treeNodes);

            treeView.Nodes.Clear();
            treeView.Nodes.AddRange(treeNodes.ToArray());
            treeView.ExpandAll();
        }

        private void SubscribeEventListeners()
        {
            noteDetails.OnFieldLeft += NoteDetails_OnNoteDetailsFieldChanged;
        }

        private void TrySelectFirstNode()
        {
            if (treeView.Nodes.Count > 0)
            {
                ProcessSelectionChange(treeView.Nodes[0]);
            }
        }

        private void UpdateSelectedNoteDetails(TreeNode node)
        {
            var noteId = Guid.Parse(node.Tag.ToString());
            var note = _repository.GetNote(noteId);

            noteDetails.Title = note.Title;
            noteDetails.Content = note.Content;
        }

        #endregion Core Logic

        #region Top Bar Menu Events

        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var note = new Note("*");
            _repository.AddNote(note);
            RefreshData();
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Top Bar Menu Events

        #region Node Menu Events

        private void AddNestedNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parentId = _selection.CurrenTreeNode.GetNoteId();
            var note = new Note("*", parentId);
            _repository.AddNestedNote(note, parentId);

            RefreshData();
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noteId = _selection.CurrenTreeNode.GetNoteId();
            var note = _repository.GetNote(noteId);

            _repository.RemoveNote(note);
            noteDetails.Clear();
            _selection.Clear();

            RefreshData();
        }

        #endregion Node Menu Events

        #region Node Details Events

        private void NoteDetails_OnNoteDetailsFieldChanged()
        {
            if (!_selection.IsSelected())
            {
                return;
            }

            var newTitle = noteDetails.Title;
            var newContent = noteDetails.Content;

            var noteId = _selection.CurrenTreeNode.GetNoteId();
            var node = treeView.Nodes.Find(noteId.ToString(), true).Single();

            if (newTitle == noteDetails.Title)
            {
                _repository.UpdateTitleById(noteId, newTitle);
                node.Text = newTitle;
            }

            if (newContent == noteDetails.Content)
            {
                _repository.UpdateContentById(noteId, newContent);
                node.Text = newTitle;
            }
        }

        #endregion Node Details Events

        #region Tree View Events

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = GetClickedNode();
            ProcessSelectionChange(node);
        }

        #endregion Tree View Events
    }
}
