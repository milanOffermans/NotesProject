using System;
using System.Windows.Forms;

namespace Notes.Forms
{
    public delegate void OnFieldLeft();

    public partial class NoteDetails : UserControl
    {
        public event OnFieldLeft OnFieldLeft;

        public NoteDetails()
        {
            InitializeComponent();
        }

        public string Content
        {
            get => textBoxContent.Text;
            set => textBoxContent.Text = value;
        }

        public string Title
        {
            get => textBoxTitle.Text;
            set => textBoxTitle.Text = value;
        }

        private void textBoxContent_Leave(object sender, EventArgs e)
        {
            if (OnFieldLeft != null)
            {
                OnFieldLeft.Invoke();
            }
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (OnFieldLeft != null)
            {
                OnFieldLeft.Invoke();
            }
        }

        public void Clear()
        {
            Title = string.Empty;
            Content = string.Empty;
        }
    }
}
