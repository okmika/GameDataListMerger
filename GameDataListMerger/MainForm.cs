using Newtonsoft.Json;
using System.Text.Json.Serialization;
using TKMM.SarcTool.Core;
using TotkCommon;
using System.Linq;
using System.Diagnostics;

namespace GameDataListMerger;

public partial class MainForm : Form {
    private Totk? totkConfig;

    public MainForm() {
        InitializeComponent();
    }

    private void setPackagePathButton_Click(object sender, EventArgs e) {
        OpenFileDialog openFileDialog = new OpenFileDialog() {
            CheckFileExists = true,
            Title = "Select GameDataList file to package",
            Filter = "GDL Files (GameDataList.Product.*.byml.zs)|GameDataList.Product.*.byml.zs"
        };

        var result = openFileDialog.ShowDialog(this);

        if (result == DialogResult.Cancel)
            return;

        packagePathText.Text = openFileDialog.FileName;
    }

    private void removeMergeFileButton_Click(object sender, EventArgs e) {

        if (mergeList.SelectedItems.Count == 0)
            return;

        mergeList.Items.RemoveAt(mergeList.SelectedIndex);
    }

    private void addMergeFileButton_Click(object sender, EventArgs e) {
        OpenFileDialog openFileDialog = new OpenFileDialog() {
            CheckFileExists = true,
            Title = "Select GameDataList changelog to merge",
            Filter = "GDL Changelogs|*.gdlchangelog"
        };

        var result = openFileDialog.ShowDialog(this);

        if (result == DialogResult.Cancel)
            return;

        if (mergeList.Items.Contains(openFileDialog.FileName))
            return;

        mergeList.Items.Add(openFileDialog.FileName);
    }

    private void moveUpButton_Click(object sender, EventArgs e) {
        if (mergeList.SelectedItems.Count == 0)
            return;

        if (mergeList.SelectedIndex == 0)
            return;

        var item = mergeList.SelectedItem;
        var targetIndex = mergeList.SelectedIndex - 1;
        mergeList.Items.RemoveAt(mergeList.SelectedIndex);
        mergeList.Items.Insert(targetIndex, item!);

        mergeList.SelectedIndex = targetIndex;
    }

    private void moveDownButton_Click(object sender, EventArgs e) {
        if (mergeList.SelectedItems.Count == 0)
            return;

        if (mergeList.SelectedIndex == mergeList.Items.Count - 1)
            return;

        var item = mergeList.SelectedItem;
        var targetIndex = mergeList.SelectedIndex + 1;
        mergeList.Items.RemoveAt(mergeList.SelectedIndex);
        mergeList.Items.Insert(targetIndex, item!);

        mergeList.SelectedIndex = targetIndex;
    }

    private void setDumpPathButton_Click(object sender, EventArgs e) {
        var directoryDialog = new FolderBrowserDialog() {
            Description = "Select the location of your game dump's romfs",
            UseDescriptionForTitle = true,
            SelectedPath = gameDumpPathText.Text
        };

        var result = directoryDialog.ShowDialog();

        if (result == DialogResult.Cancel)
            return;

        if (!Directory.Exists(directoryDialog.SelectedPath)) {
            MessageBox.Show($"{directoryDialog.SelectedPath} does not exist!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        } else if (!directoryDialog.SelectedPath.EndsWith($"{Path.DirectorySeparatorChar}romfs")) {
            MessageBox.Show($"{directoryDialog.SelectedPath} is not a romfs folder.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }

        gameDumpPathText.Text = directoryDialog.SelectedPath;
    }

    private void LoadConfig() {
        var configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Totk",
                                      "config.json");

        if (!File.Exists(configPath))
            return;

        var configText = File.ReadAllText(configPath);
        var config = JsonConvert.DeserializeObject<Totk>(configText);

        gameDumpPathText.Text = config?.GamePath;
        this.totkConfig = config;
    }

    private void WriteConfig() {
        if (String.IsNullOrWhiteSpace(gameDumpPathText.Text))
            return;

        if (totkConfig == null)
            totkConfig = new Totk();

        totkConfig.GamePath = gameDumpPathText.Text;

        var configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Totk",
                                      "config.json");

        var output = JsonConvert.SerializeObject(totkConfig);
        File.WriteAllText(configPath, output);
    }

    private void MainForm_Load(object sender, EventArgs e) {
        LoadConfig();
    }

    private async void packageButton_Click(object sender, EventArgs e) {
        if (String.IsNullOrWhiteSpace(packagePathText.Text)) {
            MessageBox.Show("You need to specify a GDL file to package up.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }

        if (String.IsNullOrEmpty(gameDumpPathText.Text)) {
            MessageBox.Show("You need to set your game dump path first. See the \"Settings\" tab.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var saveDialog = new SaveFileDialog() {
            Title = "Select location to save GDL changelog",
            Filter = "GDL Changelogs|*.gdlchangelog",
            OverwritePrompt = true
        };

        var result = saveDialog.ShowDialog();

        if (result == DialogResult.Cancel) {
            return;
        }

        if (File.Exists(saveDialog.FileName))
            File.Delete(saveDialog.FileName);

        packageButton.Enabled = false;
        mainTabs.Enabled = false;
        packageProgress.Visible = true;

        bool packageResult = false;

        try {
            await Task.Run(() => {
                WriteConfig();

                var gdlPackager = new GdlPackager();
                packageResult = gdlPackager.Package(packagePathText.Text, saveDialog.FileName);
            });

            if (!packageResult) {
                MessageBox.Show("No changelog generated because there were no changes detected.", "Generation Complete",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                MessageBox.Show("Changelog generated successfully.", "Generation Complete", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        } catch (Exception exc) {
            MessageBox.Show($"Error generating changelog: {exc.Message}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
        } finally {
            packageButton.Enabled = true;
            mainTabs.Enabled = true;
            packageProgress.Visible = false;
        }





    }

    private async void mergeButton_Click(object sender, EventArgs e) {
        if (String.IsNullOrEmpty(gameDumpPathText.Text)) {
            MessageBox.Show("You need to set your game dump path first. See the \"Settings\" tab.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (mergeList.Items.Count == 0) {
            MessageBox.Show("You need to specify at least 1 changelog to merge.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }

        var folderDialog = new FolderBrowserDialog() {
            Description = "Select the folder to write the merged GDL files to",
            UseDescriptionForTitle = true,
            AddToRecent = true
        };

        var result = folderDialog.ShowDialog();

        if (result != DialogResult.OK)
            return;

        var hasFilesInFolder = Directory.EnumerateFiles(folderDialog.SelectedPath)
                                        .Where(l => Path.GetFileName(l).StartsWith("GameDataList.Product"))
                                        .Any();

        if (hasFilesInFolder) {
            var confirmMergeInto = MessageBox.Show(
                $"One or more GDL files already exist in {folderDialog.SelectedPath
                }.\n\nIf you keep these files, the selected changelogs will be merged into them. If you want to merge into a vanilla GDL, PLEASE DELETE the existing files and this tool will copy over the vanilla GDL automatically from the game dump.\n\nDo you want to continue merging into the existing files?",
                "Existing Files Found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmMergeInto != DialogResult.Yes)
                return;
        }

        mainTabs.Enabled = false;
        mergeProgress.Visible = true;

        try {
            await Task.Run(() => {
                WriteConfig();

                var gdlPackager = new GdlPackager();

                var mergeListItems = new List<string>();

                foreach (var item in mergeList.Items)
                    mergeListItems.Add((string)item);

                mergeListItems.Reverse();

                foreach (var item in mergeListItems) {
                    gdlPackager.MergeInto((string)item, folderDialog.SelectedPath);
                }
            });

            MessageBox.Show("Changelogs merged successfully.", "Merge Complete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        } catch (Exception exc) {
            MessageBox.Show($"Error merging changelogs: {exc.Message}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
        } finally {
            mainTabs.Enabled = true;
            mergeProgress.Visible = false;
        }
    }

    private void gameBananaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        var startInfo = new ProcessStartInfo() {
            UseShellExecute = true,
            FileName = "https://gamebanana.com/tools/16842"
        };

        Process.Start(startInfo);
    }

    private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        var startInfo = new ProcessStartInfo() {
            UseShellExecute = true,
            FileName = "https://github.com/okmika/GameDataListMerger"
        };

        Process.Start(startInfo);
    }
}