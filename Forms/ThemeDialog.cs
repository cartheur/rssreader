// Designed and constructed by Christopher A Tucker, February 2007.
using System;
using System.Windows.Forms;

namespace RSSReader.Forms
{
    public partial class ThemeDialog : Form
    {
        private int folderID = 0;
        private string folderName = "";

        public int FolderID
        {
            get { return folderID; }
            set { folderID = value; }
        }
        public string FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        public ThemeDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            folderName = themeNameTextBox.Text;
            Close();
        }
        private void themeDialog_Load(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            themeIDTextBox.Text = folderID.ToString();
            themeNameTextBox.Text = folderName;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
