namespace GameDataListMerger;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        mainTabs = new TabControl();
        packageTab = new TabPage();
        packageProgress = new ProgressBar();
        packageButton = new Button();
        setPackagePathButton = new Button();
        packagePathText = new TextBox();
        label2 = new Label();
        mergeTab = new TabPage();
        mergeProgress = new ProgressBar();
        mergeButton = new Button();
        label3 = new Label();
        moveDownButton = new Button();
        moveUpButton = new Button();
        removeMergeFileButton = new Button();
        addMergeFileButton = new Button();
        mergeList = new ListBox();
        settingsTab = new TabPage();
        setDumpPathButton = new Button();
        gameDumpPathText = new TextBox();
        label1 = new Label();
        aboutTab = new TabPage();
        githubLinkLabel = new LinkLabel();
        gameBananaLinkLabel = new LinkLabel();
        label4 = new Label();
        label5 = new Label();
        mainTabs.SuspendLayout();
        packageTab.SuspendLayout();
        mergeTab.SuspendLayout();
        settingsTab.SuspendLayout();
        aboutTab.SuspendLayout();
        SuspendLayout();
        // 
        // mainTabs
        // 
        mainTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        mainTabs.Controls.Add(packageTab);
        mainTabs.Controls.Add(mergeTab);
        mainTabs.Controls.Add(settingsTab);
        mainTabs.Controls.Add(aboutTab);
        mainTabs.Location = new Point(12, 12);
        mainTabs.Name = "mainTabs";
        mainTabs.SelectedIndex = 0;
        mainTabs.Size = new Size(513, 253);
        mainTabs.TabIndex = 0;
        // 
        // packageTab
        // 
        packageTab.Controls.Add(packageProgress);
        packageTab.Controls.Add(packageButton);
        packageTab.Controls.Add(setPackagePathButton);
        packageTab.Controls.Add(packagePathText);
        packageTab.Controls.Add(label2);
        packageTab.Location = new Point(4, 24);
        packageTab.Name = "packageTab";
        packageTab.Padding = new Padding(3);
        packageTab.Size = new Size(505, 225);
        packageTab.TabIndex = 0;
        packageTab.Text = "Package";
        packageTab.UseVisualStyleBackColor = true;
        // 
        // packageProgress
        // 
        packageProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        packageProgress.Location = new Point(6, 196);
        packageProgress.Name = "packageProgress";
        packageProgress.Size = new Size(353, 23);
        packageProgress.Style = ProgressBarStyle.Marquee;
        packageProgress.TabIndex = 4;
        packageProgress.Visible = false;
        // 
        // packageButton
        // 
        packageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        packageButton.Location = new Point(365, 196);
        packageButton.Name = "packageButton";
        packageButton.Size = new Size(134, 23);
        packageButton.TabIndex = 3;
        packageButton.Text = "&Generate Changelog";
        packageButton.UseVisualStyleBackColor = true;
        packageButton.Click += packageButton_Click;
        // 
        // setPackagePathButton
        // 
        setPackagePathButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        setPackagePathButton.Location = new Point(424, 20);
        setPackagePathButton.Name = "setPackagePathButton";
        setPackagePathButton.Size = new Size(75, 23);
        setPackagePathButton.TabIndex = 2;
        setPackagePathButton.Text = "&Select";
        setPackagePathButton.UseVisualStyleBackColor = true;
        setPackagePathButton.Click += setPackagePathButton_Click;
        // 
        // packagePathText
        // 
        packagePathText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        packagePathText.Location = new Point(6, 21);
        packagePathText.Name = "packagePathText";
        packagePathText.ReadOnly = true;
        packagePathText.Size = new Size(412, 23);
        packagePathText.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 3);
        label2.Name = "label2";
        label2.Size = new Size(286, 15);
        label2.TabIndex = 0;
        label2.Text = "Select the GameDataList file you want to package up.";
        // 
        // mergeTab
        // 
        mergeTab.Controls.Add(mergeProgress);
        mergeTab.Controls.Add(mergeButton);
        mergeTab.Controls.Add(label3);
        mergeTab.Controls.Add(moveDownButton);
        mergeTab.Controls.Add(moveUpButton);
        mergeTab.Controls.Add(removeMergeFileButton);
        mergeTab.Controls.Add(addMergeFileButton);
        mergeTab.Controls.Add(mergeList);
        mergeTab.Location = new Point(4, 24);
        mergeTab.Name = "mergeTab";
        mergeTab.Padding = new Padding(3);
        mergeTab.Size = new Size(505, 225);
        mergeTab.TabIndex = 1;
        mergeTab.Text = "Merge";
        mergeTab.UseVisualStyleBackColor = true;
        // 
        // mergeProgress
        // 
        mergeProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        mergeProgress.Location = new Point(3, 196);
        mergeProgress.Name = "mergeProgress";
        mergeProgress.Size = new Size(400, 23);
        mergeProgress.Style = ProgressBarStyle.Marquee;
        mergeProgress.TabIndex = 7;
        mergeProgress.Visible = false;
        // 
        // mergeButton
        // 
        mergeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        mergeButton.Location = new Point(409, 196);
        mergeButton.Name = "mergeButton";
        mergeButton.Size = new Size(87, 23);
        mergeButton.TabIndex = 6;
        mergeButton.Text = "&Merge";
        mergeButton.UseVisualStyleBackColor = true;
        mergeButton.Click += mergeButton_Click;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label3.Location = new Point(6, 3);
        label3.Name = "label3";
        label3.Size = new Size(488, 30);
        label3.TabIndex = 0;
        label3.Text = "Select GameDataList changelog files to merge together. Select them in order of priority (top = higher)";
        // 
        // moveDownButton
        // 
        moveDownButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        moveDownButton.Location = new Point(409, 152);
        moveDownButton.Name = "moveDownButton";
        moveDownButton.Size = new Size(87, 23);
        moveDownButton.TabIndex = 5;
        moveDownButton.Text = "Move &Down";
        moveDownButton.UseVisualStyleBackColor = true;
        moveDownButton.Click += moveDownButton_Click;
        // 
        // moveUpButton
        // 
        moveUpButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        moveUpButton.Location = new Point(409, 123);
        moveUpButton.Name = "moveUpButton";
        moveUpButton.Size = new Size(87, 23);
        moveUpButton.TabIndex = 4;
        moveUpButton.Text = "Move &Up";
        moveUpButton.UseVisualStyleBackColor = true;
        moveUpButton.Click += moveUpButton_Click;
        // 
        // removeMergeFileButton
        // 
        removeMergeFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        removeMergeFileButton.Location = new Point(409, 65);
        removeMergeFileButton.Name = "removeMergeFileButton";
        removeMergeFileButton.Size = new Size(87, 23);
        removeMergeFileButton.TabIndex = 3;
        removeMergeFileButton.Text = "&Remove";
        removeMergeFileButton.UseVisualStyleBackColor = true;
        removeMergeFileButton.Click += removeMergeFileButton_Click;
        // 
        // addMergeFileButton
        // 
        addMergeFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        addMergeFileButton.Location = new Point(409, 36);
        addMergeFileButton.Name = "addMergeFileButton";
        addMergeFileButton.Size = new Size(87, 23);
        addMergeFileButton.TabIndex = 2;
        addMergeFileButton.Text = "&Add";
        addMergeFileButton.UseVisualStyleBackColor = true;
        addMergeFileButton.Click += addMergeFileButton_Click;
        // 
        // mergeList
        // 
        mergeList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        mergeList.FormattingEnabled = true;
        mergeList.ItemHeight = 15;
        mergeList.Location = new Point(6, 36);
        mergeList.Name = "mergeList";
        mergeList.Size = new Size(397, 139);
        mergeList.TabIndex = 1;
        // 
        // settingsTab
        // 
        settingsTab.Controls.Add(setDumpPathButton);
        settingsTab.Controls.Add(gameDumpPathText);
        settingsTab.Controls.Add(label1);
        settingsTab.Location = new Point(4, 24);
        settingsTab.Name = "settingsTab";
        settingsTab.Size = new Size(505, 225);
        settingsTab.TabIndex = 2;
        settingsTab.Text = "Settings";
        settingsTab.UseVisualStyleBackColor = true;
        // 
        // setDumpPathButton
        // 
        setDumpPathButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        setDumpPathButton.Location = new Point(397, 82);
        setDumpPathButton.Name = "setDumpPathButton";
        setDumpPathButton.Size = new Size(105, 23);
        setDumpPathButton.TabIndex = 2;
        setDumpPathButton.Text = "Set &Path";
        setDumpPathButton.UseVisualStyleBackColor = true;
        setDumpPathButton.Click += setDumpPathButton_Click;
        // 
        // gameDumpPathText
        // 
        gameDumpPathText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gameDumpPathText.Location = new Point(3, 83);
        gameDumpPathText.Name = "gameDumpPathText";
        gameDumpPathText.ReadOnly = true;
        gameDumpPathText.Size = new Size(388, 23);
        gameDumpPathText.TabIndex = 1;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.Location = new Point(3, 10);
        label1.Name = "label1";
        label1.Size = new Size(499, 70);
        label1.TabIndex = 0;
        label1.Text = resources.GetString("label1.Text");
        // 
        // aboutTab
        // 
        aboutTab.Controls.Add(label5);
        aboutTab.Controls.Add(githubLinkLabel);
        aboutTab.Controls.Add(gameBananaLinkLabel);
        aboutTab.Controls.Add(label4);
        aboutTab.Location = new Point(4, 24);
        aboutTab.Name = "aboutTab";
        aboutTab.Size = new Size(505, 225);
        aboutTab.TabIndex = 3;
        aboutTab.Text = "About";
        aboutTab.UseVisualStyleBackColor = true;
        // 
        // githubLinkLabel
        // 
        githubLinkLabel.AutoSize = true;
        githubLinkLabel.Location = new Point(15, 69);
        githubLinkLabel.Name = "githubLinkLabel";
        githubLinkLabel.Size = new Size(72, 15);
        githubLinkLabel.TabIndex = 1;
        githubLinkLabel.TabStop = true;
        githubLinkLabel.Text = "Github Page";
        githubLinkLabel.LinkClicked += githubLinkLabel_LinkClicked;
        // 
        // gameBananaLinkLabel
        // 
        gameBananaLinkLabel.AutoSize = true;
        gameBananaLinkLabel.Location = new Point(15, 44);
        gameBananaLinkLabel.Name = "gameBananaLinkLabel";
        gameBananaLinkLabel.Size = new Size(109, 15);
        gameBananaLinkLabel.TabIndex = 1;
        gameBananaLinkLabel.TabStop = true;
        gameBananaLinkLabel.Text = "Game Banana Page";
        gameBananaLinkLabel.LinkClicked += gameBananaLinkLabel_LinkClicked;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.Location = new Point(15, 13);
        label4.Name = "label4";
        label4.Size = new Size(114, 15);
        label4.TabIndex = 0;
        label4.Text = "Made by Mikachan!";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(15, 201);
        label5.Name = "label5";
        label5.Size = new Size(43, 15);
        label5.TabIndex = 2;
        label5.Text = "v. 1.0.4";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(537, 277);
        Controls.Add(mainTabs);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "GameDataList Merger";
        Load += MainForm_Load;
        mainTabs.ResumeLayout(false);
        packageTab.ResumeLayout(false);
        packageTab.PerformLayout();
        mergeTab.ResumeLayout(false);
        settingsTab.ResumeLayout(false);
        settingsTab.PerformLayout();
        aboutTab.ResumeLayout(false);
        aboutTab.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl mainTabs;
    private TabPage packageTab;
    private TabPage mergeTab;
    private TabPage settingsTab;
    private Label label1;
    private TabPage aboutTab;
    private Button setPackagePathButton;
    private TextBox packagePathText;
    private Label label2;
    private Button setDumpPathButton;
    private TextBox gameDumpPathText;
    private ProgressBar packageProgress;
    private Button packageButton;
    private Label label3;
    private Button moveDownButton;
    private Button moveUpButton;
    private Button removeMergeFileButton;
    private Button addMergeFileButton;
    private ListBox mergeList;
    private ProgressBar mergeProgress;
    private Button mergeButton;
    private LinkLabel githubLinkLabel;
    private LinkLabel gameBananaLinkLabel;
    private Label label4;
    private Label label5;
}