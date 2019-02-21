// Designed and constructed by Christopher A Tucker, February 2007.
using System;
using System.Windows.Forms;

namespace RSSReader.Forms
{
    public partial class ChannelDialog : Form
    {
        public rssDataSet DataSource
        {
            get { return rssDataSet; }
            set { rssDataSet = value; }
        }
        public int ChannelID { get; set; }
        public int FolderID { get; set; }

        public ChannelDialog()
        {
            InitializeComponent();
        }

        private void ChannelDialog_Load(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            // if the channelID is greater than 0, then set the current record = to the channelID.
            // I shouldn't have to do this ... its already set in the properties. Any ideas as to why this didn't "take" the first time?
            folderBindingSource.DataSource = rssDataSet;
            folderBindingSource.DataMember = "Folder";
            folderBindingSource.ResetBindings(true);

            folderComboBox.SelectedValue = FolderID;

            if (ChannelID > 0)
            {
                // I shouldn't have to do this ... its already set in the properties. Any ideas as to why this didn't "take" the first time?
                channelBindingSource.DataSource = rssDataSet;
                channelBindingSource.DataMember = "Channel";
                channelBindingSource.Filter = "ChannelID = " + ChannelID.ToString();
                channelBindingSource.ResetBindings(true);
            }

        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (ChannelID == 0)
            {
                rssDataSet.ChannelRow channel = rssDataSet.Channel.NewChannelRow();

                channel.FolderID = int.Parse(folderComboBox.SelectedValue.ToString());
                channel.Title = titleTextBox.Text;
                channel.URL = urlTextBox.Text;
                channel.LastUpdated = DateTime.Now;

                rssDataSet.Channel.AddChannelRow(channel);
            }
            else
            {
                // Find the existing channel
                rssDataSet.ChannelRow channel = rssDataSet.Channel.FindByChannelID(ChannelID);

                channel.BeginEdit();
                channel.FolderID = int.Parse(folderComboBox.SelectedValue.ToString());
                channel.Title = titleTextBox.Text;
                channel.URL = urlTextBox.Text;
                channel.LastUpdated = DateTime.Parse(lastUpdatedTextBox.Text);
                channel.EndEdit();
            }
            Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
