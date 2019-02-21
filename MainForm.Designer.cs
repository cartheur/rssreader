namespace RSSReader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.NewsItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssDataSet = new RSSReader.rssDataSet();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.newsItemsLabel = new System.Windows.Forms.Label();
            this.newsItemsListBox = new System.Windows.Forms.ListBox();
            this.datePosted = new System.Windows.Forms.TextBox();
            this.datePostedLabel = new System.Windows.Forms.Label();
            this.expandLabel = new System.Windows.Forms.Label();
            this.channelsLabel = new System.Windows.Forms.Label();
            this.channelsListBox = new System.Windows.Forms.ListBox();
            this.ChannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.FolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addThemeToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.editThemeToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteThemeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.editChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteChannelToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshRSSFeed = new System.Windows.Forms.ToolStripButton();
            this.folderTableAdapter = new RSSReader.rssDataSetTableAdapters.FolderTableAdapter();
            this.channelTableAdapter = new RSSReader.rssDataSetTableAdapters.ChannelTableAdapter();
            this.newsItemTableAdapter = new RSSReader.rssDataSetTableAdapters.NewsItemTableAdapter();
            this.newsItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.webBrowser);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.descriptionTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.descriptionLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.newsItemsLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.newsItemsListBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.datePosted);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.datePostedLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.expandLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.channelsLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.channelsListBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.titleTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.titleLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.themeLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.folderComboBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(500, 318);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(500, 389);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(500, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Step = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // webBrowser
            // 
            this.webBrowser.DataBindings.Add(new System.Windows.Forms.Binding("Url", this.NewsItemBindingSource, "Link", true));
            this.webBrowser.Location = new System.Drawing.Point(186, 160);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(310, 158);
            this.webBrowser.TabIndex = 0;
            // 
            // NewsItemBindingSource
            // 
            this.NewsItemBindingSource.DataMember = "NewsItem";
            this.NewsItemBindingSource.DataSource = this.rssDataSet;
            // 
            // rssDataSet
            // 
            this.rssDataSet.DataSetName = "rssDataSet";
            this.rssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NewsItemBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(186, 74);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(310, 53);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(185, 56);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description:";
            // 
            // newsItemsLabel
            // 
            this.newsItemsLabel.AutoSize = true;
            this.newsItemsLabel.Location = new System.Drawing.Point(15, 167);
            this.newsItemsLabel.Name = "newsItemsLabel";
            this.newsItemsLabel.Size = new System.Drawing.Size(65, 13);
            this.newsItemsLabel.TabIndex = 11;
            this.newsItemsLabel.Text = "News Items:";
            // 
            // newsItemsListBox
            // 
            this.newsItemsListBox.DataSource = this.NewsItemBindingSource;
            this.newsItemsListBox.DisplayMember = "Title";
            this.newsItemsListBox.FormattingEnabled = true;
            this.newsItemsListBox.Location = new System.Drawing.Point(15, 184);
            this.newsItemsListBox.Name = "newsItemsListBox";
            this.newsItemsListBox.Size = new System.Drawing.Size(150, 134);
            this.newsItemsListBox.TabIndex = 10;
            this.newsItemsListBox.ValueMember = "NewsItemID";
            this.newsItemsListBox.SelectedIndexChanged += new System.EventHandler(this.newsItemsListBox_SelectedIndexChanged);
            // 
            // datePosted
            // 
            this.datePosted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NewsItemBindingSource, "DateAcquired", true));
            this.datePosted.Location = new System.Drawing.Point(268, 133);
            this.datePosted.Name = "datePosted";
            this.datePosted.Size = new System.Drawing.Size(143, 20);
            this.datePosted.TabIndex = 9;
            // 
            // datePostedLabel
            // 
            this.datePostedLabel.AutoSize = true;
            this.datePostedLabel.Location = new System.Drawing.Point(185, 139);
            this.datePostedLabel.Name = "datePostedLabel";
            this.datePostedLabel.Size = new System.Drawing.Size(77, 13);
            this.datePostedLabel.TabIndex = 8;
            this.datePostedLabel.Text = "Date Updated:";
            // 
            // expandLabel
            // 
            this.expandLabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.NewsItemBindingSource, "Link", true));
            this.expandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandLabel.ForeColor = System.Drawing.Color.Blue;
            this.expandLabel.Location = new System.Drawing.Point(451, 139);
            this.expandLabel.Name = "expandLabel";
            this.expandLabel.Size = new System.Drawing.Size(45, 14);
            this.expandLabel.TabIndex = 7;
            this.expandLabel.Text = "Expand";
            this.expandLabel.Click += new System.EventHandler(this.expandLabel_Click);
            // 
            // channelsLabel
            // 
            this.channelsLabel.AutoSize = true;
            this.channelsLabel.Location = new System.Drawing.Point(12, 51);
            this.channelsLabel.Name = "channelsLabel";
            this.channelsLabel.Size = new System.Drawing.Size(54, 13);
            this.channelsLabel.TabIndex = 6;
            this.channelsLabel.Text = "Channels:";
            // 
            // channelsListBox
            // 
            this.channelsListBox.DataSource = this.ChannelBindingSource;
            this.channelsListBox.DisplayMember = "Title";
            this.channelsListBox.FormattingEnabled = true;
            this.channelsListBox.Location = new System.Drawing.Point(12, 68);
            this.channelsListBox.Name = "channelsListBox";
            this.channelsListBox.Size = new System.Drawing.Size(153, 95);
            this.channelsListBox.TabIndex = 5;
            this.channelsListBox.ValueMember = "ChannelID";
            this.channelsListBox.SelectedIndexChanged += new System.EventHandler(this.channelsListBox_SelectedIndexChanged);
            // 
            // ChannelBindingSource
            // 
            this.ChannelBindingSource.DataMember = "Channel";
            this.ChannelBindingSource.DataSource = this.rssDataSet;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NewsItemBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(186, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(310, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(189, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.themeLabel.Location = new System.Drawing.Point(13, 11);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(43, 13);
            this.themeLabel.TabIndex = 2;
            this.themeLabel.Text = "Theme:";
            // 
            // folderComboBox
            // 
            this.folderComboBox.DataSource = this.FolderBindingSource;
            this.folderComboBox.DisplayMember = "FolderName";
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(12, 28);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(153, 21);
            this.folderComboBox.TabIndex = 1;
            this.folderComboBox.ValueMember = "FolderID";
            this.folderComboBox.SelectedIndexChanged += new System.EventHandler(this.folderComboBox_SelectedIndexChanged);
            // 
            // FolderBindingSource
            // 
            this.FolderBindingSource.DataMember = "Folder";
            this.FolderBindingSource.DataSource = this.rssDataSet;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(500, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newThemeToolStripMenuItem,
            this.newChannelToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newThemeToolStripMenuItem
            // 
            this.newThemeToolStripMenuItem.Name = "newThemeToolStripMenuItem";
            this.newThemeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newThemeToolStripMenuItem.Text = "New Theme";
            this.newThemeToolStripMenuItem.Click += new System.EventHandler(this.newThemeToolStripMenuItem_Click);
            // 
            // newChannelToolStripMenuItem
            // 
            this.newChannelToolStripMenuItem.Name = "newChannelToolStripMenuItem";
            this.newChannelToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newChannelToolStripMenuItem.Text = "New Channel";
            this.newChannelToolStripMenuItem.Click += new System.EventHandler(this.newChannelToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addThemeToolstripButton,
            this.editThemeToolstripButton,
            this.deleteThemeToolStripButton,
            this.toolStripSeparator1,
            this.addChannelToolstripButton,
            this.editChannelToolstripButton,
            this.deleteChannelToolstripButton,
            this.toolStripSeparator2,
            this.refreshRSSFeed});
            this.toolStrip.Location = new System.Drawing.Point(3, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(185, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStip";
            // 
            // addThemeToolstripButton
            // 
            this.addThemeToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addThemeToolstripButton.Image = global::RSSReader.Properties.Resources.folder_add;
            this.addThemeToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addThemeToolstripButton.Name = "addThemeToolstripButton";
            this.addThemeToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.addThemeToolstripButton.Text = "New Theme";
            this.addThemeToolstripButton.Click += new System.EventHandler(this.addThemeToolstripButton_Click);
            // 
            // editThemeToolstripButton
            // 
            this.editThemeToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editThemeToolstripButton.Image = global::RSSReader.Properties.Resources.folder_edit;
            this.editThemeToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editThemeToolstripButton.Name = "editThemeToolstripButton";
            this.editThemeToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.editThemeToolstripButton.Text = "toolStripButton1";
            this.editThemeToolstripButton.ToolTipText = "Edit Theme";
            this.editThemeToolstripButton.Click += new System.EventHandler(this.editThemeToolstripButton_Click);
            // 
            // deleteThemeToolStripButton
            // 
            this.deleteThemeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteThemeToolStripButton.Image = global::RSSReader.Properties.Resources.folder_delete;
            this.deleteThemeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteThemeToolStripButton.Name = "deleteThemeToolStripButton";
            this.deleteThemeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteThemeToolStripButton.Text = "toolStripButton3";
            this.deleteThemeToolStripButton.ToolTipText = "Delete Theme";
            this.deleteThemeToolStripButton.Click += new System.EventHandler(this.deleteThemeToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addChannelToolstripButton
            // 
            this.addChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addChannelToolstripButton.Image = global::RSSReader.Properties.Resources.channel_new;
            this.addChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addChannelToolstripButton.Name = "addChannelToolstripButton";
            this.addChannelToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.addChannelToolstripButton.Text = "toolStripButton4";
            this.addChannelToolstripButton.ToolTipText = "Add Channel";
            this.addChannelToolstripButton.Click += new System.EventHandler(this.addChannelToolstripButton_Click);
            // 
            // editChannelToolstripButton
            // 
            this.editChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editChannelToolstripButton.Image = global::RSSReader.Properties.Resources.channel_edit;
            this.editChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editChannelToolstripButton.Name = "editChannelToolstripButton";
            this.editChannelToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.editChannelToolstripButton.Text = "toolStripButton5";
            this.editChannelToolstripButton.ToolTipText = "Edit Channel";
            this.editChannelToolstripButton.Click += new System.EventHandler(this.editChannelToolstripButton_Click);
            // 
            // deleteChannelToolstripButton
            // 
            this.deleteChannelToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteChannelToolstripButton.Image = global::RSSReader.Properties.Resources.channel_delete;
            this.deleteChannelToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteChannelToolstripButton.Name = "deleteChannelToolstripButton";
            this.deleteChannelToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteChannelToolstripButton.Text = "toolStripButton6";
            this.deleteChannelToolstripButton.ToolTipText = "Delete Channel";
            this.deleteChannelToolstripButton.Click += new System.EventHandler(this.deleteChannelToolstripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshRSSFeed
            // 
            this.refreshRSSFeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshRSSFeed.Image = global::RSSReader.Properties.Resources.rss;
            this.refreshRSSFeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshRSSFeed.Name = "refreshRSSFeed";
            this.refreshRSSFeed.Size = new System.Drawing.Size(23, 22);
            this.refreshRSSFeed.Text = "toolStripButton7";
            this.refreshRSSFeed.ToolTipText = "Refresh feed";
            this.refreshRSSFeed.Click += new System.EventHandler(this.refreshRSSFeed_Click);
            // 
            // folderTableAdapter
            // 
            this.folderTableAdapter.ClearBeforeFill = true;
            // 
            // channelTableAdapter
            // 
            this.channelTableAdapter.ClearBeforeFill = true;
            // 
            // newsItemTableAdapter
            // 
            this.newsItemTableAdapter.ClearBeforeFill = true;
            // 
            // newsItemBindingSource1
            // 
            this.newsItemBindingSource1.DataMember = "NewsItem";
            this.newsItemBindingSource1.DataSource = this.rssDataSet;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 389);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 428);
            this.Name = "MainForm";
            this.Text = "Intelligent Data Aggregator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsItemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.ToolStripButton addThemeToolstripButton;
        private System.Windows.Forms.ToolStripButton editThemeToolstripButton;
        private System.Windows.Forms.ToolStripButton deleteThemeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addChannelToolstripButton;
        private System.Windows.Forms.ToolStripButton editChannelToolstripButton;
        private System.Windows.Forms.ToolStripButton deleteChannelToolstripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton refreshRSSFeed;
        private System.Windows.Forms.Label expandLabel;
        private System.Windows.Forms.Label channelsLabel;
        private System.Windows.Forms.ListBox channelsListBox;
        private System.Windows.Forms.Label newsItemsLabel;
        private System.Windows.Forms.ListBox newsItemsListBox;
        private System.Windows.Forms.TextBox datePosted;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label datePostedLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.WebBrowser webBrowser;
        private rssDataSet rssDataSet;
        private System.Windows.Forms.BindingSource FolderBindingSource;
        private rssDataSetTableAdapters.FolderTableAdapter folderTableAdapter;
        private System.Windows.Forms.BindingSource ChannelBindingSource;
        private rssDataSetTableAdapters.ChannelTableAdapter channelTableAdapter;
        private System.Windows.Forms.BindingSource NewsItemBindingSource;
        private rssDataSetTableAdapters.NewsItemTableAdapter newsItemTableAdapter;
        private System.Windows.Forms.BindingSource newsItemBindingSource1;
    }
}

