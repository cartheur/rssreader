// ***********************************************************************
// Assembly         : RSSReader
// Author           : cartheur
// Created          : 18-02-2007
//
// Last Modified By : cartheur
// Last Modified On : 21-02-2019
// ***********************************************************************
// <copyright file="MainForm.cs" company="cartheur">
//   2007 - 2019. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using RSSReader.Forms;

namespace RSSReader
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Creates a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            folderTableAdapter.Fill(rssDataSet.Folder);
            RefreshChannels();
            RefreshNewsItems();
        }
        /// <summary>
        /// Display the theme dialog. With an ID property of 0, the dialog goes into "new theme" mode. Setting the ID > 0 the dialog goes into "theme edit" mode.
        /// </summary>
        public void AddTheme()
        {
            statusLabel.Text = "Creating new theme...";
            ThemeDialog myThemeDialog = new ThemeDialog();
            DialogResult result = myThemeDialog.ShowDialog();
            // Dialog, go into "new theme" mode.
            myThemeDialog.FolderID = 0;

            if (result == DialogResult.OK)
            {
                try
                {
                    rssDataSet.FolderRow theme = rssDataSet.Folder.NewFolderRow();
                    theme.FolderName = myThemeDialog.FolderName;
                    int rowsAffected = folderTableAdapter.Update(theme);
                    rssDataSet.Folder.AddFolderRow(theme);

                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "New theme created - '" + myThemeDialog.FolderName + "'";
                    }
                    else
                    {
                        statusLabel.Text = "Problem creating new theme. Could not save into database.";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem creating new theme: " + ex.Message);
                }

            }
            else
            {
                statusLabel.Text = "New folder operation cancelled.";
            }

            myThemeDialog = null;

        }
        /// <summary>
        /// Edit the chosen theme.
        /// </summary>
        public void EditTheme()
        {
            statusLabel.Text = "Editing theme...";
            int themeID = (int)folderComboBox.SelectedValue;
            ThemeDialog myThemeDialog = new ThemeDialog();
            DialogResult result = myThemeDialog.ShowDialog();
            rssDataSet.FolderRow folder = rssDataSet.Folder.FindByFolderID(themeID);
            myThemeDialog.FolderID = themeID;
            myThemeDialog.FolderName = folder.FolderName;

            if (result == DialogResult.OK)
            {
                int rowsAffected = folderTableAdapter.Update(folder);

                try
                {
                    folder.BeginEdit();
                    folder.FolderName = myThemeDialog.FolderName;
                    folder.EndEdit();

                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "Folder edited successfully: '" + folder.FolderName + "'";
                    }
                    else
                    {
                        statusLabel.Text = "Problem updating folder.  Could not save into the database.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem editing folder: " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "Edit folder operation cancelled.";
            }
            myThemeDialog = null;
        }
        /// <summary>
        /// Delete the chosen theme.
        /// </summary>
        public void DeleteTheme()
        {
            statusLabel.Text = "Deleting theme...";

            DialogResult result = MessageBox.Show("Are you sure you want to delete the current theme? Doing so will also delete all the channels and messages contained in that folder.",
                "Delete theme?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly,
                false);

            if (result == DialogResult.Yes)
            {
                int rowsAffected = folderTableAdapter.Update(rssDataSet);
                try
                {
                    // Delete all the Channels for the current theme.
                    int folderID = (int)folderComboBox.SelectedValue;
                    DeleteChannels(folderID);
                    // Delete the folder itself, containing the theme.
                    rssDataSet.FolderRow folder = rssDataSet.Folder.FindByFolderID(folderID);
                    folder.Delete();

                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "Theme successfully deleted.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem deleting theme:" + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "Delete theme operation cancelled.";
            }
        }
        /// <summary>
        /// Add a new channel.
        /// </summary>
        public void AddChannel()
        {
            statusLabel.Text = "Creating new channel...";
            int rowsAffected = channelTableAdapter.Update(rssDataSet);
            ChannelDialog myChannelDialog = new ChannelDialog();
            DialogResult result = myChannelDialog.ShowDialog();
            myChannelDialog.DataSource = rssDataSet;
            myChannelDialog.ChannelID = 0;
            myChannelDialog.FolderID = (int)folderComboBox.SelectedValue;

            if (result == DialogResult.OK)
            {
                try
                {
                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "New channel successfully created.";
                    }
                    else
                    {
                        statusLabel.Text = "Problem creating new channel.";
                    }
                    QueryChannels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem creating channel: " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "New channel operation cancelled.";
            }
            myChannelDialog = null;
        }
        /// <summary>
        /// Edit a chosen channel.
        /// </summary>
        public void EditChannel()
        {
            statusLabel.Text = "Editing channel...";
            int rowsAffected = channelTableAdapter.Update(rssDataSet);
            ChannelDialog myChannelDialog = new ChannelDialog();
            DialogResult result = myChannelDialog.ShowDialog();
            myChannelDialog.DataSource = rssDataSet;
            myChannelDialog.ChannelID = (int)channelsListBox.SelectedValue;
            myChannelDialog.FolderID = (int)folderComboBox.SelectedValue;

            if (result == DialogResult.OK)
            {
                try
                {
                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "Channel updated successfully.";
                    }
                    else
                    {
                        statusLabel.Text = "Problem updating channel.";
                    }
                    QueryChannels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem updating channel: " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "Edit channel operation cancelled.";
            }
            myChannelDialog = null;
        }
        /// <summary>
        /// Delete a chosen channel.
        /// </summary>
        public void DeleteChannel()
        {
            statusLabel.Text = "Deleting channel...";

            DialogResult result = MessageBox.Show("Are you sure you want to delete the current Channel? Doing so will also delete all the News Items for that Channel.",
                "Delete Folder?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly,
                false);

            if (result == DialogResult.Yes)
            {
                int rowsAffected = channelTableAdapter.Update(rssDataSet);
                try
                {
                    // Delete NewsItems associated with this Channel.
                    int channelID = (int)channelsListBox.SelectedValue;
                    DeleteNewsItems(channelID);
                    // Delete the Channel.
                    rssDataSet.ChannelRow channel = rssDataSet.Channel.FindByChannelID(channelID);
                    channel.Delete();

                    if (rowsAffected > 0)
                    {
                        statusLabel.Text = "Channel deleted successfully.";
                    }
                    else
                    {
                        statusLabel.Text = "Problem deleting channel.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem deleting channel: " + ex.Message);
                }
            }
            else
            {
                statusLabel.Text = "Delete channel operation cancelled.";
            }
        }
        /// <summary>
        /// Given a FolderID, delete all associated Channels and NewsItems from the database.
        /// </summary>
        /// <param name="folderID"></param>
        public void DeleteChannels(int folderID)
        {
            int rowsAffected = channelTableAdapter.Update(rssDataSet)
            try
            {
                rssDataSet.ChannelRow[] channels = (rssDataSet.ChannelRow[])rssDataSet.Channel.Select("FolderID = " + folderID.ToString());
                
                foreach (rssDataSet.ChannelRow channel in channels)
                {
                    int channelID = channel.ChannelID;
                    DeleteNewsItems(channelID);
                    channel.Delete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// For the given Channel, delete all associated NewsItems.
        /// </summary>
        /// <param name="channelID"></param>
        public void DeleteNewsItems(int channelID)
        {
            try
            {
                rssDataSet.NewsItemRow[] newsItems = (rssDataSet.NewsItemRow[])rssDataSet.NewsItem.Select("ChannelID = " + channelID.ToString());

                if (newsItems.Length == 0)
                    return;

                foreach (rssDataSet.NewsItemRow newsItem in newsItems)
                    newsItem.Delete();

                int rowsAffected = newsItemTableAdapter.Update(rssDataSet);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Loop through all Channels. For each Channel, delegate the work of obtaining the RSS Feed to the processNewsFeed method.
        /// </summary>
        public void QueryChannels()
        {
            statusLabel.Text = "RSS feeds updated.";

            int rowsAffected = newsItemTableAdapter.Update(rssDataSet);
            progressBar.Maximum = rssDataSet.Channel.Rows.Count;
            progressBar.Value = 0;

            try
            {
                foreach (rssDataSet.ChannelRow currentChannel in rssDataSet.Channel.Rows)
                {
                    System.Collections.ArrayList result;
                    result = RssManager.ProcessNewsFeed(currentChannel.URL);

                    foreach (NewsItem currentNewsItem in result)
                    {
                        // During testing, I realized the single quote was causing problems, so I needed to remove completely or escape it. I chose to remove them ... may rethink this later.
                        string title = currentNewsItem.Title;

                        //if (title.Length >= 50)
                        //    title = title.Substring(0, 49);

                        title = title.Replace("'", "");

                        string filterExpression = "Title = '" + title + "'";

                        System.Data.DataRow[] filteredNewsItems = rssDataSet.NewsItem.Select(filterExpression);

                        if (filteredNewsItems.Length == 0)
                        {
                            // Did not find it ... Need to add a new NewsItem datarow.
                            rssDataSet.NewsItemRow newRow = rssDataSet.NewsItem.NewNewsItemRow();
                            newRow.Title = title;
                            newRow.Description = currentNewsItem.Description;
                            newRow.Link = currentNewsItem.Link;
                            newRow.ChannelID = currentChannel.ChannelID;
                            newRow.DateAcquired = DateTime.Now;

                            rssDataSet.NewsItem.AddNewsItemRow(newRow);

                        }
                    }
                    progressBar.Value++;
                }

                


                if (rowsAffected > 0)
                {
                    statusLabel.Text = "RSS Feeds updated successfully.  " + rowsAffected.ToString() + " NewsItems were added.";
                }
                else
                {
                    statusLabel.Text = "RSS Feeds updated successfully.  No NewsItems were added.";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                progressBar.Value = 0;
            }
        }
        /// <summary>
        /// Refresh all the channels.
        /// </summary>
        public void RefreshChannels()
        {
            if (rssDataSet.Channel.Rows.Count == 0)
                channelTableAdapter.Fill(rssDataSet.Channel);

            if (folderComboBox.SelectedValue != null)
                ChannelBindingSource.Filter = "FolderID = " + folderComboBox.SelectedValue;
        }
        /// <summary>
        /// Refresh the list of NewsItems based on the current Channel selection.
        /// </summary>
        public void RefreshNewsItems()
        {
            if (rssDataSet.NewsItem.Rows.Count == 0)
                newsItemTableAdapter.Fill(rssDataSet.NewsItem);

            if (channelsListBox.SelectedValue != null)
                NewsItemBindingSource.Filter = "ChannelID = " + channelsListBox.SelectedValue.ToString();
        }

        #region Events
        private void editThemeToolstripButton_Click(object sender, EventArgs e)
        {
            EditTheme();
        }
        private void addThemeToolstripButton_Click(object sender, EventArgs e)
        {
            AddTheme();
        }
        private void deleteThemeToolStripButton_Click(object sender, EventArgs e)
        {
            DeleteTheme();
        }
        private void addChannelToolstripButton_Click(object sender, EventArgs e)
        {
            AddChannel();
        }
        private void editChannelToolstripButton_Click(object sender, EventArgs e)
        {
            EditChannel();
        }
        private void deleteChannelToolstripButton_Click(object sender, EventArgs e)
        {
            DeleteChannel();
        }
        private void refreshRSSFeed_Click(object sender, EventArgs e)
        {
            try
            {
                QueryChannels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem updating RSS feeds: " + ex.Message);
            }
        }
        private void newThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTheme();
        }
        private void newChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChannel();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The financial advantage aggregator. Copyright 2007 - 2019 Paradox Technologies", "About this program", MessageBoxButtons.OK);
        }
        private void expandLabel_Click(object sender, EventArgs e)
        {
            if (expandLabel.Tag.ToString().Length == 0)
                return;
            try
            {
                System.Diagnostics.Process.Start("IExplore", expandLabel.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not launch the link in an external browser.",
                    "An error has occurred: " + ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }>
        private void folderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshChannels();
            RefreshNewsItems();
        }
        private void channelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshNewsItems();
        }
        private void newsItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newsItemsListBox.SelectedIndex != -1)
                NewsItemBindingSource.Position = newsItemsListBox.SelectedIndex;
        }
        #endregion
    }
}
