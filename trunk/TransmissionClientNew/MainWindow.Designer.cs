namespace TransmissionRemoteDotnet
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addTorrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTorrentFromUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reannounceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTorrentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNetworkShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.startAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showErrorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.projectSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForNewVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flagsImageList = new System.Windows.Forms.ImageList(this.components);
            this.refreshWorker = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.filesTimer = new System.Windows.Forms.Timer(this.components);
            this.filesWorker = new System.ComponentModel.BackgroundWorker();
            this.refreshElapsedTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.connectButton = new System.Windows.Forms.ToolStripSplitButton();
            this.disconnectButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addTorrentButton = new System.Windows.Forms.ToolStripButton();
            this.addWebTorrentButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startTorrentButton = new System.Windows.Forms.ToolStripSplitButton();
            this.startAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTorrentButton = new System.Windows.Forms.ToolStripSplitButton();
            this.pauseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recheckTorrentButton = new System.Windows.Forms.ToolStripButton();
            this.configureTorrentButton = new System.Windows.Forms.ToolStripButton();
            this.removeTorrentButton = new System.Windows.Forms.ToolStripButton();
            this.removeAndDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.reannounceButton = new System.Windows.Forms.ToolStripSplitButton();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentlyActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNetworkShareButton = new System.Windows.Forms.ToolStripButton();
            this.remoteCmdButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.localConfigureButton = new System.Windows.Forms.ToolStripButton();
            this.remoteConfigureButton = new System.Windows.Forms.ToolStripButton();
            this.sessionStatsButton = new System.Windows.Forms.ToolStripButton();
            this.torrentAndTabsSplitContainer = new TransmissionRemoteDotnet.SplitContainerFix();
            this.mainVerticalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.stateListBox = new TransmissionRemoteDotnet.GListBox();
            this.torrentListView = new TransmissionRemoteDotnet.ListViewNF();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader30 = new System.Windows.Forms.ColumnHeader();
            this.torrentTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.downloadProgressLabel = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.piecesGraph = new TransmissionRemoteDotnet.PiecesGraph();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.generalTorrentNameGroupBox = new System.Windows.Forms.GroupBox();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.labelForErrorLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ratioLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.leechersLabel = new System.Windows.Forms.Label();
            this.seedersLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uploadLimitLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uploadRateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uploadedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.downloadLimitLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.downloadSpeedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.downloadedLabel = new System.Windows.Forms.Label();
            this.startedAtLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeElapsedLabelLabel = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.trackersTabPage = new System.Windows.Forms.TabPage();
            this.trackersTorrentNameGroupBox = new System.Windows.Forms.GroupBox();
            this.trackersListView = new TransmissionRemoteDotnet.ListViewNF();
            this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
            this.filesTabPage = new System.Windows.Forms.TabPage();
            this.filesTorrentNameGroupBox = new System.Windows.Forms.GroupBox();
            this.filesListView = new TransmissionRemoteDotnet.ListViewNF();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader32 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.peersTabPage = new System.Windows.Forms.TabPage();
            this.peersTorrentNameGroupBox = new System.Windows.Forms.GroupBox();
            this.peersListView = new TransmissionRemoteDotnet.ListViewNF();
            this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader31 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader29 = new System.Windows.Forms.ColumnHeader();
            this.speedTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label18 = new System.Windows.Forms.Label();
            this.speedResComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.speedGraph = new CustomUIControls.Graphing.C2DPushGraph();
            this.menuStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.torrentAndTabsSplitContainer.Panel1.SuspendLayout();
            this.torrentAndTabsSplitContainer.Panel2.SuspendLayout();
            this.torrentAndTabsSplitContainer.SuspendLayout();
            this.mainVerticalSplitContainer.Panel1.SuspendLayout();
            this.mainVerticalSplitContainer.Panel2.SuspendLayout();
            this.mainVerticalSplitContainer.SuspendLayout();
            this.torrentTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.generalTorrentNameGroupBox.SuspendLayout();
            this.trackersTabPage.SuspendLayout();
            this.trackersTorrentNameGroupBox.SuspendLayout();
            this.filesTabPage.SuspendLayout();
            this.filesTorrentNameGroupBox.SuspendLayout();
            this.peersTabPage.SuspendLayout();
            this.peersTorrentNameGroupBox.SuspendLayout();
            this.speedTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlImageList
            // 
            this.tabControlImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.tabControlImageList, "tabControlImageList");
            this.tabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.torrentToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addTorrentToolStripMenuItem,
            this.addTorrentFromUrlToolStripMenuItem,
            this.fileMenuItemSeperator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            resources.ApplyResources(this.disconnectToolStripMenuItem, "disconnectToolStripMenuItem");
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // addTorrentToolStripMenuItem
            // 
            this.addTorrentToolStripMenuItem.Name = "addTorrentToolStripMenuItem";
            resources.ApplyResources(this.addTorrentToolStripMenuItem, "addTorrentToolStripMenuItem");
            this.addTorrentToolStripMenuItem.Click += new System.EventHandler(this.addTorrentButton_Click);
            // 
            // addTorrentFromUrlToolStripMenuItem
            // 
            this.addTorrentFromUrlToolStripMenuItem.Name = "addTorrentFromUrlToolStripMenuItem";
            resources.ApplyResources(this.addTorrentFromUrlToolStripMenuItem, "addTorrentFromUrlToolStripMenuItem");
            this.addTorrentFromUrlToolStripMenuItem.Click += new System.EventHandler(this.addWebTorrentButton_Click);
            // 
            // fileMenuItemSeperator1
            // 
            this.fileMenuItemSeperator1.Name = "fileMenuItemSeperator1";
            resources.ApplyResources(this.fileMenuItemSeperator1, "fileMenuItemSeperator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localSettingsToolStripMenuItem,
            this.remoteSettingsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // localSettingsToolStripMenuItem
            // 
            this.localSettingsToolStripMenuItem.Name = "localSettingsToolStripMenuItem";
            resources.ApplyResources(this.localSettingsToolStripMenuItem, "localSettingsToolStripMenuItem");
            this.localSettingsToolStripMenuItem.Click += new System.EventHandler(this.localConfigureButton_Click);
            // 
            // remoteSettingsToolStripMenuItem
            // 
            this.remoteSettingsToolStripMenuItem.Name = "remoteSettingsToolStripMenuItem";
            resources.ApplyResources(this.remoteSettingsToolStripMenuItem, "remoteSettingsToolStripMenuItem");
            this.remoteSettingsToolStripMenuItem.Click += new System.EventHandler(this.remoteConfigureButton_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // torrentToolStripMenuItem
            // 
            this.torrentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.recheckToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.removeDeleteToolStripMenuItem,
            this.reannounceToolStripMenuItem,
            this.moveTorrentDataToolStripMenuItem,
            this.openNetworkShareToolStripMenuItem,
            this.toolStripSeparator5,
            this.startAllToolStripMenuItem,
            this.stopAllToolStripMenuItem});
            this.torrentToolStripMenuItem.Name = "torrentToolStripMenuItem";
            resources.ApplyResources(this.torrentToolStripMenuItem, "torrentToolStripMenuItem");
            this.torrentToolStripMenuItem.Click += new System.EventHandler(this.reannounceButton_ButtonClick);
            // 
            // startToolStripMenuItem
            // 
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startTorrentButton_Click);
            // 
            // pauseToolStripMenuItem
            // 
            resources.ApplyResources(this.pauseToolStripMenuItem, "pauseToolStripMenuItem");
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseTorrentButton_Click);
            // 
            // recheckToolStripMenuItem
            // 
            resources.ApplyResources(this.recheckToolStripMenuItem, "recheckToolStripMenuItem");
            this.recheckToolStripMenuItem.Name = "recheckToolStripMenuItem";
            this.recheckToolStripMenuItem.Click += new System.EventHandler(this.recheckTorrentButton_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            resources.ApplyResources(this.propertiesToolStripMenuItem, "propertiesToolStripMenuItem");
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.ShowTorrentPropsHandler);
            // 
            // removeToolStripMenuItem
            // 
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeTorrentButton_Click);
            // 
            // removeDeleteToolStripMenuItem
            // 
            resources.ApplyResources(this.removeDeleteToolStripMenuItem, "removeDeleteToolStripMenuItem");
            this.removeDeleteToolStripMenuItem.Name = "removeDeleteToolStripMenuItem";
            this.removeDeleteToolStripMenuItem.Click += new System.EventHandler(this.removeAndDeleteButton_Click);
            // 
            // reannounceToolStripMenuItem
            // 
            resources.ApplyResources(this.reannounceToolStripMenuItem, "reannounceToolStripMenuItem");
            this.reannounceToolStripMenuItem.Name = "reannounceToolStripMenuItem";
            this.reannounceToolStripMenuItem.Click += new System.EventHandler(this.reannounceButton_ButtonClick);
            // 
            // moveTorrentDataToolStripMenuItem
            // 
            resources.ApplyResources(this.moveTorrentDataToolStripMenuItem, "moveTorrentDataToolStripMenuItem");
            this.moveTorrentDataToolStripMenuItem.Name = "moveTorrentDataToolStripMenuItem";
            this.moveTorrentDataToolStripMenuItem.Click += new System.EventHandler(this.moveTorrentDataToolStripMenuItem_Click);
            // 
            // openNetworkShareToolStripMenuItem
            // 
            resources.ApplyResources(this.openNetworkShareToolStripMenuItem, "openNetworkShareToolStripMenuItem");
            this.openNetworkShareToolStripMenuItem.Name = "openNetworkShareToolStripMenuItem";
            this.openNetworkShareToolStripMenuItem.Click += new System.EventHandler(this.openNetworkShareButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // startAllToolStripMenuItem
            // 
            this.startAllToolStripMenuItem.Name = "startAllToolStripMenuItem";
            resources.ApplyResources(this.startAllToolStripMenuItem, "startAllToolStripMenuItem");
            this.startAllToolStripMenuItem.Click += new System.EventHandler(this.startAllMenuItem_Click);
            // 
            // stopAllToolStripMenuItem
            // 
            this.stopAllToolStripMenuItem.Name = "stopAllToolStripMenuItem";
            resources.ApplyResources(this.stopAllToolStripMenuItem, "stopAllToolStripMenuItem");
            this.stopAllToolStripMenuItem.Click += new System.EventHandler(this.stopAllMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsPanelToolStripMenuItem,
            this.categoriesPanelToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // showDetailsPanelToolStripMenuItem
            // 
            this.showDetailsPanelToolStripMenuItem.Checked = true;
            this.showDetailsPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDetailsPanelToolStripMenuItem.Name = "showDetailsPanelToolStripMenuItem";
            resources.ApplyResources(this.showDetailsPanelToolStripMenuItem, "showDetailsPanelToolStripMenuItem");
            this.showDetailsPanelToolStripMenuItem.Click += new System.EventHandler(this.showDetailsPanelToolStripMenuItem_Click);
            // 
            // categoriesPanelToolStripMenuItem
            // 
            this.categoriesPanelToolStripMenuItem.Name = "categoriesPanelToolStripMenuItem";
            resources.ApplyResources(this.categoriesPanelToolStripMenuItem, "categoriesPanelToolStripMenuItem");
            this.categoriesPanelToolStripMenuItem.Click += new System.EventHandler(this.categoriesPanelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showErrorLogToolStripMenuItem,
            this.toolStripMenuItem1,
            this.projectSiteToolStripMenuItem,
            this.checkForNewVersionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // showErrorLogToolStripMenuItem
            // 
            this.showErrorLogToolStripMenuItem.Name = "showErrorLogToolStripMenuItem";
            resources.ApplyResources(this.showErrorLogToolStripMenuItem, "showErrorLogToolStripMenuItem");
            this.showErrorLogToolStripMenuItem.Click += new System.EventHandler(this.showErrorLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // projectSiteToolStripMenuItem
            // 
            this.projectSiteToolStripMenuItem.Name = "projectSiteToolStripMenuItem";
            resources.ApplyResources(this.projectSiteToolStripMenuItem, "projectSiteToolStripMenuItem");
            this.projectSiteToolStripMenuItem.Click += new System.EventHandler(this.projectSiteToolStripMenuItem_Click);
            // 
            // checkForNewVersionToolStripMenuItem
            // 
            this.checkForNewVersionToolStripMenuItem.Name = "checkForNewVersionToolStripMenuItem";
            resources.ApplyResources(this.checkForNewVersionToolStripMenuItem, "checkForNewVersionToolStripMenuItem");
            this.checkForNewVersionToolStripMenuItem.Click += new System.EventHandler(this.checkForNewVersionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // flagsImageList
            // 
            this.flagsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("flagsImageList.ImageStream")));
            this.flagsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.flagsImageList.Images.SetKeyName(0, "16x16_ledlightblue.png");
            this.flagsImageList.Images.SetKeyName(1, "16x16_ledlightgreen.png");
            this.flagsImageList.Images.SetKeyName(2, "16x16_ledorange.png");
            this.flagsImageList.Images.SetKeyName(3, "16x16_ledred.png");
            // 
            // refreshWorker
            // 
            this.refreshWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.refreshWorker_DoWork);
            this.refreshWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.refreshWorker_RunWorkerCompleted);
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // filesTimer
            // 
            this.filesTimer.Tick += new System.EventHandler(this.filesTimer_Tick);
            // 
            // filesWorker
            // 
            this.filesWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.filesWorker_DoWork);
            this.filesWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.filesWorker_RunWorkerCompleted);
            // 
            // refreshElapsedTimer
            // 
            this.refreshElapsedTimer.Interval = 1000;
            this.refreshElapsedTimer.Tick += new System.EventHandler(this.refreshElapsedTimer_Tick);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.torrentAndTabsSplitContainer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip);
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectButton,
            this.disconnectButton,
            this.toolStripSeparator4,
            this.addTorrentButton,
            this.addWebTorrentButton,
            this.toolStripSeparator1,
            this.startTorrentButton,
            this.pauseTorrentButton,
            this.recheckTorrentButton,
            this.configureTorrentButton,
            this.removeTorrentButton,
            this.removeAndDeleteButton,
            this.reannounceButton,
            this.openNetworkShareButton,
            this.remoteCmdButton,
            this.toolStripSeparator2,
            this.localConfigureButton,
            this.remoteConfigureButton,
            this.sessionStatsButton});
            this.toolStrip.Name = "toolStrip";
            // 
            // connectButton
            // 
            this.connectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connectButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.connect_creating;
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.ButtonClick += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disconnectButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.connect_no;
            resources.ApplyResources(this.disconnectButton, "disconnectButton");
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // addTorrentButton
            // 
            this.addTorrentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTorrentButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.edit_add;
            resources.ApplyResources(this.addTorrentButton, "addTorrentButton");
            this.addTorrentButton.Name = "addTorrentButton";
            this.addTorrentButton.Click += new System.EventHandler(this.addTorrentButton_Click);
            // 
            // addWebTorrentButton
            // 
            this.addWebTorrentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addWebTorrentButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.net_add;
            resources.ApplyResources(this.addWebTorrentButton, "addWebTorrentButton");
            this.addWebTorrentButton.Name = "addWebTorrentButton";
            this.addWebTorrentButton.Click += new System.EventHandler(this.addWebTorrentButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // startTorrentButton
            // 
            this.startTorrentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startTorrentButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAllToolStripMenuItem1});
            resources.ApplyResources(this.startTorrentButton, "startTorrentButton");
            this.startTorrentButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.player_play1;
            this.startTorrentButton.Name = "startTorrentButton";
            this.startTorrentButton.Click += new System.EventHandler(this.startTorrentButton_Click);
            // 
            // startAllToolStripMenuItem1
            // 
            this.startAllToolStripMenuItem1.Name = "startAllToolStripMenuItem1";
            resources.ApplyResources(this.startAllToolStripMenuItem1, "startAllToolStripMenuItem1");
            this.startAllToolStripMenuItem1.Click += new System.EventHandler(this.startAllMenuItem_Click);
            // 
            // pauseTorrentButton
            // 
            this.pauseTorrentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseTorrentButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseAllToolStripMenuItem});
            resources.ApplyResources(this.pauseTorrentButton, "pauseTorrentButton");
            this.pauseTorrentButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.player_pause;
            this.pauseTorrentButton.Name = "pauseTorrentButton";
            this.pauseTorrentButton.Click += new System.EventHandler(this.pauseTorrentButton_Click);
            // 
            // pauseAllToolStripMenuItem
            // 
            this.pauseAllToolStripMenuItem.Name = "pauseAllToolStripMenuItem";
            resources.ApplyResources(this.pauseAllToolStripMenuItem, "pauseAllToolStripMenuItem");
            this.pauseAllToolStripMenuItem.Click += new System.EventHandler(this.stopAllMenuItem_Click);
            // 
            // recheckTorrentButton
            // 
            this.recheckTorrentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.recheckTorrentButton, "recheckTorrentButton");
            this.recheckTorrentButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.player_reload;
            this.recheckTorrentButton.Name = "recheckTorrentButton";
            this.recheckTorrentButton.Click += new System.EventHandler(this.recheckTorrentButton_Click);
            // 
            // configureTorrentButton
            // 
            this.configureTorrentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.configureTorrentButton, "configureTorrentButton");
            this.configureTorrentButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.kgpg_edit;
            this.configureTorrentButton.Name = "configureTorrentButton";
            this.configureTorrentButton.Click += new System.EventHandler(this.ShowTorrentPropsHandler);
            // 
            // removeTorrentButton
            // 
            this.removeTorrentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.removeTorrentButton, "removeTorrentButton");
            this.removeTorrentButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.button_cancel1;
            this.removeTorrentButton.Name = "removeTorrentButton";
            this.removeTorrentButton.Click += new System.EventHandler(this.removeTorrentButton_Click);
            // 
            // removeAndDeleteButton
            // 
            this.removeAndDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.removeAndDeleteButton, "removeAndDeleteButton");
            this.removeAndDeleteButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.remove_and_delete;
            this.removeAndDeleteButton.Name = "removeAndDeleteButton";
            this.removeAndDeleteButton.Click += new System.EventHandler(this.removeAndDeleteButton_Click);
            // 
            // reannounceButton
            // 
            this.reannounceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reannounceButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.recentlyActiveToolStripMenuItem});
            resources.ApplyResources(this.reannounceButton, "reannounceButton");
            this.reannounceButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.reannounce;
            this.reannounceButton.Name = "reannounceButton";
            this.reannounceButton.ButtonClick += new System.EventHandler(this.reannounceButton_ButtonClick);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            resources.ApplyResources(this.allToolStripMenuItem, "allToolStripMenuItem");
            this.allToolStripMenuItem.Click += new System.EventHandler(this.reannounceAllToolStripMenuItem_Click);
            // 
            // recentlyActiveToolStripMenuItem
            // 
            this.recentlyActiveToolStripMenuItem.Name = "recentlyActiveToolStripMenuItem";
            resources.ApplyResources(this.recentlyActiveToolStripMenuItem, "recentlyActiveToolStripMenuItem");
            this.recentlyActiveToolStripMenuItem.Click += new System.EventHandler(this.recentlyActiveToolStripMenuItem_Click);
            // 
            // openNetworkShareButton
            // 
            this.openNetworkShareButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.openNetworkShareButton, "openNetworkShareButton");
            this.openNetworkShareButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.folder_html;
            this.openNetworkShareButton.Name = "openNetworkShareButton";
            this.openNetworkShareButton.Click += new System.EventHandler(this.openNetworkShareButton_Click);
            // 
            // remoteCmdButton
            // 
            this.remoteCmdButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.remoteCmdButton, "remoteCmdButton");
            this.remoteCmdButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.openterm;
            this.remoteCmdButton.Name = "remoteCmdButton";
            this.remoteCmdButton.Click += new System.EventHandler(this.runCmdButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // localConfigureButton
            // 
            this.localConfigureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.localConfigureButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.configure;
            resources.ApplyResources(this.localConfigureButton, "localConfigureButton");
            this.localConfigureButton.Name = "localConfigureButton";
            this.localConfigureButton.Click += new System.EventHandler(this.localConfigureButton_Click);
            // 
            // remoteConfigureButton
            // 
            this.remoteConfigureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.remoteConfigureButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.netconfigure;
            resources.ApplyResources(this.remoteConfigureButton, "remoteConfigureButton");
            this.remoteConfigureButton.Name = "remoteConfigureButton";
            this.remoteConfigureButton.Click += new System.EventHandler(this.remoteConfigureButton_Click);
            // 
            // sessionStatsButton
            // 
            this.sessionStatsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sessionStatsButton.Image = global::TransmissionRemoteDotnet.Properties.Resources.hwinfo;
            resources.ApplyResources(this.sessionStatsButton, "sessionStatsButton");
            this.sessionStatsButton.Name = "sessionStatsButton";
            this.sessionStatsButton.Click += new System.EventHandler(this.sessionStatsButton_Click);
            // 
            // torrentAndTabsSplitContainer
            // 
            resources.ApplyResources(this.torrentAndTabsSplitContainer, "torrentAndTabsSplitContainer");
            this.torrentAndTabsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.torrentAndTabsSplitContainer.Name = "torrentAndTabsSplitContainer";
            // 
            // torrentAndTabsSplitContainer.Panel1
            // 
            this.torrentAndTabsSplitContainer.Panel1.Controls.Add(this.mainVerticalSplitContainer);
            // 
            // torrentAndTabsSplitContainer.Panel2
            // 
            this.torrentAndTabsSplitContainer.Panel2.Controls.Add(this.torrentTabControl);
            // 
            // mainVerticalSplitContainer
            // 
            resources.ApplyResources(this.mainVerticalSplitContainer, "mainVerticalSplitContainer");
            this.mainVerticalSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainVerticalSplitContainer.Name = "mainVerticalSplitContainer";
            // 
            // mainVerticalSplitContainer.Panel1
            // 
            this.mainVerticalSplitContainer.Panel1.Controls.Add(this.stateListBox);
            // 
            // mainVerticalSplitContainer.Panel2
            // 
            this.mainVerticalSplitContainer.Panel2.Controls.Add(this.torrentListView);
            // 
            // stateListBox
            // 
            resources.ApplyResources(this.stateListBox, "stateListBox");
            this.stateListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.ImageList = null;
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.SelectedIndexChanged += new System.EventHandler(this.stateListBox_SelectedIndexChanged);
            // 
            // torrentListView
            // 
            this.torrentListView.AllowColumnReorder = true;
            this.torrentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader30});
            resources.ApplyResources(this.torrentListView, "torrentListView");
            this.torrentListView.FullRowSelect = true;
            this.torrentListView.Name = "torrentListView";
            this.torrentListView.ShowItemToolTips = true;
            this.torrentListView.UseCompatibleStateImageBehavior = false;
            this.torrentListView.View = System.Windows.Forms.View.Details;
            this.torrentListView.SelectedIndexChanged += new System.EventHandler(this.torrentListView_SelectedIndexChanged);
            this.torrentListView.DoubleClick += new System.EventHandler(this.ShowTorrentPropsHandler);
            this.torrentListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.torrentListView_ColumnClick);
            this.torrentListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.torrentListView_KeyDown);
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // columnHeader14
            // 
            resources.ApplyResources(this.columnHeader14, "columnHeader14");
            // 
            // columnHeader15
            // 
            resources.ApplyResources(this.columnHeader15, "columnHeader15");
            // 
            // columnHeader16
            // 
            resources.ApplyResources(this.columnHeader16, "columnHeader16");
            // 
            // columnHeader18
            // 
            resources.ApplyResources(this.columnHeader18, "columnHeader18");
            // 
            // columnHeader19
            // 
            resources.ApplyResources(this.columnHeader19, "columnHeader19");
            // 
            // columnHeader30
            // 
            resources.ApplyResources(this.columnHeader30, "columnHeader30");
            // 
            // torrentTabControl
            // 
            this.torrentTabControl.Controls.Add(this.generalTabPage);
            this.torrentTabControl.Controls.Add(this.trackersTabPage);
            this.torrentTabControl.Controls.Add(this.filesTabPage);
            this.torrentTabControl.Controls.Add(this.peersTabPage);
            this.torrentTabControl.Controls.Add(this.speedTabPage);
            resources.ApplyResources(this.torrentTabControl, "torrentTabControl");
            this.torrentTabControl.ImageList = this.tabControlImageList;
            this.torrentTabControl.Name = "torrentTabControl";
            this.torrentTabControl.SelectedIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.splitContainer3);
            resources.ApplyResources(this.generalTabPage, "generalTabPage");
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            resources.ApplyResources(this.splitContainer3.Panel2, "splitContainer3.Panel2");
            this.splitContainer3.Panel2.Controls.Add(this.generalTorrentNameGroupBox);
            // 
            // splitContainer4
            // 
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.downloadProgressLabel);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            // 
            // downloadProgressLabel
            // 
            resources.ApplyResources(this.downloadProgressLabel, "downloadProgressLabel");
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            // 
            // splitContainer5
            // 
            resources.ApplyResources(this.splitContainer5, "splitContainer5");
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.piecesGraph);
            this.splitContainer5.Panel1.Controls.Add(this.progressBar);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.percentageLabel);
            // 
            // piecesGraph
            // 
            this.piecesGraph.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.piecesGraph, "piecesGraph");
            this.piecesGraph.ForeColor = System.Drawing.Color.LimeGreen;
            this.piecesGraph.Name = "piecesGraph";
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // percentageLabel
            // 
            resources.ApplyResources(this.percentageLabel, "percentageLabel");
            this.percentageLabel.Name = "percentageLabel";
            // 
            // generalTorrentNameGroupBox
            // 
            resources.ApplyResources(this.generalTorrentNameGroupBox, "generalTorrentNameGroupBox");
            this.generalTorrentNameGroupBox.Controls.Add(this.createdByLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label17);
            this.generalTorrentNameGroupBox.Controls.Add(this.createdAtLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label16);
            this.generalTorrentNameGroupBox.Controls.Add(this.errorLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.labelForErrorLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.commentLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label15);
            this.generalTorrentNameGroupBox.Controls.Add(this.ratioLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label14);
            this.generalTorrentNameGroupBox.Controls.Add(this.leechersLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.seedersLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label13);
            this.generalTorrentNameGroupBox.Controls.Add(this.label10);
            this.generalTorrentNameGroupBox.Controls.Add(this.uploadLimitLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label12);
            this.generalTorrentNameGroupBox.Controls.Add(this.uploadRateLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label8);
            this.generalTorrentNameGroupBox.Controls.Add(this.uploadedLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label5);
            this.generalTorrentNameGroupBox.Controls.Add(this.remainingLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label4);
            this.generalTorrentNameGroupBox.Controls.Add(this.statusLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label11);
            this.generalTorrentNameGroupBox.Controls.Add(this.downloadLimitLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label9);
            this.generalTorrentNameGroupBox.Controls.Add(this.downloadSpeedLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label7);
            this.generalTorrentNameGroupBox.Controls.Add(this.label6);
            this.generalTorrentNameGroupBox.Controls.Add(this.downloadedLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.startedAtLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.label3);
            this.generalTorrentNameGroupBox.Controls.Add(this.timeElapsedLabelLabel);
            this.generalTorrentNameGroupBox.Controls.Add(this.timeElapsedLabel);
            this.generalTorrentNameGroupBox.Name = "generalTorrentNameGroupBox";
            this.generalTorrentNameGroupBox.TabStop = false;
            // 
            // createdByLabel
            // 
            resources.ApplyResources(this.createdByLabel, "createdByLabel");
            this.createdByLabel.Name = "createdByLabel";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // createdAtLabel
            // 
            resources.ApplyResources(this.createdAtLabel, "createdAtLabel");
            this.createdAtLabel.Name = "createdAtLabel";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // errorLabel
            // 
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.Name = "errorLabel";
            // 
            // labelForErrorLabel
            // 
            resources.ApplyResources(this.labelForErrorLabel, "labelForErrorLabel");
            this.labelForErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.labelForErrorLabel.Name = "labelForErrorLabel";
            // 
            // commentLabel
            // 
            resources.ApplyResources(this.commentLabel, "commentLabel");
            this.commentLabel.Name = "commentLabel";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // ratioLabel
            // 
            resources.ApplyResources(this.ratioLabel, "ratioLabel");
            this.ratioLabel.Name = "ratioLabel";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // leechersLabel
            // 
            resources.ApplyResources(this.leechersLabel, "leechersLabel");
            this.leechersLabel.Name = "leechersLabel";
            // 
            // seedersLabel
            // 
            resources.ApplyResources(this.seedersLabel, "seedersLabel");
            this.seedersLabel.Name = "seedersLabel";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // uploadLimitLabel
            // 
            resources.ApplyResources(this.uploadLimitLabel, "uploadLimitLabel");
            this.uploadLimitLabel.Name = "uploadLimitLabel";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // uploadRateLabel
            // 
            resources.ApplyResources(this.uploadRateLabel, "uploadRateLabel");
            this.uploadRateLabel.Name = "uploadRateLabel";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // uploadedLabel
            // 
            resources.ApplyResources(this.uploadedLabel, "uploadedLabel");
            this.uploadedLabel.Name = "uploadedLabel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // remainingLabel
            // 
            resources.ApplyResources(this.remainingLabel, "remainingLabel");
            this.remainingLabel.Name = "remainingLabel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // downloadLimitLabel
            // 
            resources.ApplyResources(this.downloadLimitLabel, "downloadLimitLabel");
            this.downloadLimitLabel.Name = "downloadLimitLabel";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // downloadSpeedLabel
            // 
            resources.ApplyResources(this.downloadSpeedLabel, "downloadSpeedLabel");
            this.downloadSpeedLabel.Name = "downloadSpeedLabel";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // downloadedLabel
            // 
            resources.ApplyResources(this.downloadedLabel, "downloadedLabel");
            this.downloadedLabel.Name = "downloadedLabel";
            // 
            // startedAtLabel
            // 
            resources.ApplyResources(this.startedAtLabel, "startedAtLabel");
            this.startedAtLabel.Name = "startedAtLabel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // timeElapsedLabelLabel
            // 
            resources.ApplyResources(this.timeElapsedLabelLabel, "timeElapsedLabelLabel");
            this.timeElapsedLabelLabel.Name = "timeElapsedLabelLabel";
            // 
            // timeElapsedLabel
            // 
            resources.ApplyResources(this.timeElapsedLabel, "timeElapsedLabel");
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            // 
            // trackersTabPage
            // 
            this.trackersTabPage.Controls.Add(this.trackersTorrentNameGroupBox);
            resources.ApplyResources(this.trackersTabPage, "trackersTabPage");
            this.trackersTabPage.Name = "trackersTabPage";
            this.trackersTabPage.UseVisualStyleBackColor = true;
            // 
            // trackersTorrentNameGroupBox
            // 
            this.trackersTorrentNameGroupBox.Controls.Add(this.trackersListView);
            resources.ApplyResources(this.trackersTorrentNameGroupBox, "trackersTorrentNameGroupBox");
            this.trackersTorrentNameGroupBox.Name = "trackersTorrentNameGroupBox";
            this.trackersTorrentNameGroupBox.TabStop = false;
            // 
            // trackersListView
            // 
            this.trackersListView.AllowColumnReorder = true;
            this.trackersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader20,
            this.columnHeader21});
            resources.ApplyResources(this.trackersListView, "trackersListView");
            this.trackersListView.FullRowSelect = true;
            this.trackersListView.Name = "trackersListView";
            this.trackersListView.UseCompatibleStateImageBehavior = false;
            this.trackersListView.View = System.Windows.Forms.View.Details;
            this.trackersListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.torrentDetailsTabListView_KeyDown);
            // 
            // columnHeader22
            // 
            resources.ApplyResources(this.columnHeader22, "columnHeader22");
            // 
            // columnHeader20
            // 
            resources.ApplyResources(this.columnHeader20, "columnHeader20");
            // 
            // columnHeader21
            // 
            resources.ApplyResources(this.columnHeader21, "columnHeader21");
            // 
            // filesTabPage
            // 
            this.filesTabPage.Controls.Add(this.filesTorrentNameGroupBox);
            resources.ApplyResources(this.filesTabPage, "filesTabPage");
            this.filesTabPage.Name = "filesTabPage";
            this.filesTabPage.UseVisualStyleBackColor = true;
            // 
            // filesTorrentNameGroupBox
            // 
            this.filesTorrentNameGroupBox.Controls.Add(this.filesListView);
            resources.ApplyResources(this.filesTorrentNameGroupBox, "filesTorrentNameGroupBox");
            this.filesTorrentNameGroupBox.Name = "filesTorrentNameGroupBox";
            this.filesTorrentNameGroupBox.TabStop = false;
            // 
            // filesListView
            // 
            this.filesListView.AllowColumnReorder = true;
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader32,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader17,
            this.columnHeader5});
            resources.ApplyResources(this.filesListView, "filesListView");
            this.filesListView.FullRowSelect = true;
            this.filesListView.Name = "filesListView";
            this.filesListView.ShowItemToolTips = true;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.SelectedIndexChanged += new System.EventHandler(this.filesListView_SelectedIndexChanged);
            this.filesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.filesListView_ColumnClick);
            this.filesListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.torrentDetailsTabListView_KeyDown);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader32
            // 
            resources.ApplyResources(this.columnHeader32, "columnHeader32");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader17
            // 
            resources.ApplyResources(this.columnHeader17, "columnHeader17");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // peersTabPage
            // 
            this.peersTabPage.Controls.Add(this.peersTorrentNameGroupBox);
            resources.ApplyResources(this.peersTabPage, "peersTabPage");
            this.peersTabPage.Name = "peersTabPage";
            this.peersTabPage.UseVisualStyleBackColor = true;
            // 
            // peersTorrentNameGroupBox
            // 
            this.peersTorrentNameGroupBox.Controls.Add(this.peersListView);
            resources.ApplyResources(this.peersTorrentNameGroupBox, "peersTorrentNameGroupBox");
            this.peersTorrentNameGroupBox.Name = "peersTorrentNameGroupBox";
            this.peersTorrentNameGroupBox.TabStop = false;
            // 
            // peersListView
            // 
            this.peersListView.AllowColumnReorder = true;
            this.peersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader31,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29});
            resources.ApplyResources(this.peersListView, "peersListView");
            this.peersListView.FullRowSelect = true;
            this.peersListView.Name = "peersListView";
            this.peersListView.ShowItemToolTips = true;
            this.peersListView.UseCompatibleStateImageBehavior = false;
            this.peersListView.View = System.Windows.Forms.View.Details;
            this.peersListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.peersListView_ColumnClick);
            this.peersListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.torrentDetailsTabListView_KeyDown);
            // 
            // columnHeader23
            // 
            resources.ApplyResources(this.columnHeader23, "columnHeader23");
            // 
            // columnHeader24
            // 
            resources.ApplyResources(this.columnHeader24, "columnHeader24");
            // 
            // columnHeader25
            // 
            resources.ApplyResources(this.columnHeader25, "columnHeader25");
            // 
            // columnHeader31
            // 
            resources.ApplyResources(this.columnHeader31, "columnHeader31");
            // 
            // columnHeader26
            // 
            resources.ApplyResources(this.columnHeader26, "columnHeader26");
            // 
            // columnHeader27
            // 
            resources.ApplyResources(this.columnHeader27, "columnHeader27");
            // 
            // columnHeader28
            // 
            resources.ApplyResources(this.columnHeader28, "columnHeader28");
            // 
            // columnHeader29
            // 
            resources.ApplyResources(this.columnHeader29, "columnHeader29");
            // 
            // speedTabPage
            // 
            this.speedTabPage.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.speedTabPage, "speedTabPage");
            this.speedTabPage.Name = "speedTabPage";
            this.speedTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.label19);
            this.splitContainer1.Panel2.Controls.Add(this.speedGraph);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label18);
            this.splitContainer2.Panel2.Controls.Add(this.speedResComboBox);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // speedResComboBox
            // 
            this.speedResComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedResComboBox.FormattingEnabled = true;
            this.speedResComboBox.Items.AddRange(new object[] {
            resources.GetString("speedResComboBox.Items"),
            resources.GetString("speedResComboBox.Items1"),
            resources.GetString("speedResComboBox.Items2"),
            resources.GetString("speedResComboBox.Items3")});
            resources.ApplyResources(this.speedResComboBox, "speedResComboBox");
            this.speedResComboBox.Name = "speedResComboBox";
            this.speedResComboBox.SelectedIndexChanged += new System.EventHandler(this.SpeedResComboBox_SelectedIndexChanged);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.BackColor = System.Drawing.Color.MidnightBlue;
            this.label20.ForeColor = System.Drawing.Color.Green;
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.MidnightBlue;
            this.label19.ForeColor = System.Drawing.Color.Yellow;
            this.label19.Name = "label19";
            // 
            // speedGraph
            // 
            this.speedGraph.AutoAdjustPeek = true;
            this.speedGraph.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.speedGraph, "speedGraph");
            this.speedGraph.GridColor = System.Drawing.Color.LightBlue;
            this.speedGraph.GridDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.speedGraph.GridSize = ((ushort)(50));
            this.speedGraph.HighQuality = true;
            this.speedGraph.LineInterval = 5F;
            this.speedGraph.MaxLabel = "Max";
            this.speedGraph.MaxPeekMagnitude = 100;
            this.speedGraph.MinLabel = "";
            this.speedGraph.MinPeekMagnitude = 0;
            this.speedGraph.Name = "speedGraph";
            this.speedGraph.ShowGrid = true;
            this.speedGraph.ShowLabels = true;
            this.speedGraph.TextColor = System.Drawing.Color.White;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.torrentAndTabsSplitContainer.Panel1.ResumeLayout(false);
            this.torrentAndTabsSplitContainer.Panel2.ResumeLayout(false);
            this.torrentAndTabsSplitContainer.ResumeLayout(false);
            this.mainVerticalSplitContainer.Panel1.ResumeLayout(false);
            this.mainVerticalSplitContainer.Panel2.ResumeLayout(false);
            this.mainVerticalSplitContainer.ResumeLayout(false);
            this.torrentTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            this.splitContainer5.ResumeLayout(false);
            this.generalTorrentNameGroupBox.ResumeLayout(false);
            this.generalTorrentNameGroupBox.PerformLayout();
            this.trackersTabPage.ResumeLayout(false);
            this.trackersTorrentNameGroupBox.ResumeLayout(false);
            this.filesTabPage.ResumeLayout(false);
            this.filesTorrentNameGroupBox.ResumeLayout(false);
            this.peersTabPage.ResumeLayout(false);
            this.peersTorrentNameGroupBox.ResumeLayout(false);
            this.speedTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton remoteCmdButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SplitContainer mainVerticalSplitContainer;
        private TransmissionRemoteDotnet.SplitContainerFix torrentAndTabsSplitContainer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton addTorrentButton;
        private System.Windows.Forms.TabPage trackersTabPage;
        private System.Windows.Forms.TabPage filesTabPage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ToolStripButton disconnectButton;
        private System.Windows.Forms.ToolStripButton addWebTorrentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton removeTorrentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton localConfigureButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton remoteConfigureButton;
        private System.Windows.Forms.ToolStripMenuItem addTorrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTorrentFromUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileMenuItemSeperator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripSplitButton connectButton;
        public System.Windows.Forms.Timer refreshTimer;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public ListViewNF torrentListView;
        private System.Windows.Forms.ToolStripMenuItem localSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteSettingsToolStripMenuItem;
        public TransmissionRemoteDotnet.GListBox stateListBox;
        private System.ComponentModel.BackgroundWorker filesWorker;
        public TransmissionRemoteDotnet.ListViewNF filesListView;
        public System.Windows.Forms.Timer filesTimer;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label downloadProgressLabel;
        private System.Windows.Forms.Label percentageLabel;
        public System.Windows.Forms.TabControl torrentTabControl;
        private TransmissionRemoteDotnet.ListViewNF trackersListView;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.Label timeElapsedLabelLabel;
        private System.Windows.Forms.Timer refreshElapsedTimer;
        private System.Windows.Forms.ImageList flagsImageList;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.GroupBox generalTorrentNameGroupBox;
        private System.Windows.Forms.Label downloadedLabel;
        private System.Windows.Forms.Label startedAtLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label downloadLimitLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label downloadSpeedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label uploadRateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uploadedLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label uploadLimitLabel;
        private System.Windows.Forms.Label leechersLabel;
        private System.Windows.Forms.Label seedersLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ratioLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label labelForErrorLabel;
        private System.Windows.Forms.Label createdAtLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage peersTabPage;
        private TransmissionRemoteDotnet.ListViewNF peersListView;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.GroupBox trackersTorrentNameGroupBox;
        private System.Windows.Forms.GroupBox filesTorrentNameGroupBox;
        private System.Windows.Forms.GroupBox peersTorrentNameGroupBox;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem projectSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showErrorLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private TransmissionRemoteDotnet.PiecesGraph piecesGraph;
        private System.ComponentModel.BackgroundWorker refreshWorker;
        private System.Windows.Forms.TabPage speedTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox speedResComboBox;
        private CustomUIControls.Graphing.C2DPushGraph speedGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ImageList tabControlImageList;
        private System.Windows.Forms.ToolStripButton recheckTorrentButton;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ToolStripButton removeAndDeleteButton;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ToolStripButton sessionStatsButton;
        private System.Windows.Forms.ToolStripButton configureTorrentButton;
        private System.Windows.Forms.ToolStripMenuItem torrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton startTorrentButton;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton pauseTorrentButton;
        private System.Windows.Forms.ToolStripMenuItem pauseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton reannounceButton;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentlyActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton openNetworkShareButton;
        private System.Windows.Forms.ToolStripMenuItem categoriesPanelToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ToolStripMenuItem reannounceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNetworkShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveTorrentDataToolStripMenuItem;
    }
}