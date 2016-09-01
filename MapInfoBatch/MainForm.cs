using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GeoMedia = Intergraph.GeoMedia.GeoMedia;
using PClient = Intergraph.GeoMedia.PClient;
using MapInfo = Intergraph.GeoMedia.ExportToMapInfo;

public partial class MainForm : Form
{
    public GeoMedia.Application GeoMediaApp = null;
    PClient.Connection _connection = null;
    ToolStripMenuItem _recentItem = null;
    MapInfo.ExportToMapInfoService _mapInfoService = new Intergraph.GeoMedia.ExportToMapInfo.ExportToMapInfoService();

    public MainForm()
    {
        InitializeComponent();
    }

    void ImportConnections()
    {
        connectionsToolStripMenuItem.DropDownItems.Clear();
        mListView.Items.Clear();

        PClient.Connections cons = (GeoMediaApp.Document as GeoMedia.Document).Connections as PClient.Connections;

        foreach (PClient.Connection con in cons)
        {
            if (con.Status == PClient.ConnectionConstants.gmcStatusClosed)
                continue;

            PClient.GDatabase db = con.Database as PClient.GDatabase;

            string name = db.Name.Replace("=opgk", "=*");
            string info = con.ConnectInfo.Replace("=opgk", "=*");
            string tekst = string.Format("{0} ({1})", con.ConnectionName, name);

            ToolStripMenuItem item = new ToolStripMenuItem(tekst);
            item.Click += new EventHandler(connectionsItem_Click);
            item.Tag = con.ConnectionName;
            item.Checked = false;
            item.ToolTipText = "Name: " + con.ConnectionName + "\n" +
                "Info: " + info + "\n" +
                "Description :" + con.Description + "\n" +
                "Database: " + name;

            //WriteEvent(string.Format("dodano po³¹czenie do {0}, (enabled)", name));

            connectionsToolStripMenuItem.DropDownItems.Add(item);
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        if (GeoMediaApp == null)
        {
            MessageBox.Show("Error");
            return;
        }

        ImportConnections();
    }

    void connectionsItem_Click(object sender, EventArgs e)
    {
        //odznaczamy poprzednio wybrane pole
        if (_recentItem != null) _recentItem.Checked = false;

        ToolStripMenuItem item = sender as ToolStripMenuItem;

        //item.Tag zawiera nazwê po³¹czenia
        string connName = item.Tag as string;

        item.Checked = true;
        _recentItem = item;

        PClient.Connections cons = (GeoMediaApp.Document as GeoMedia.Document).Connections as PClient.Connections;

        _connection = cons.Item(connName);

        //WriteEvent(string.Format("wybrano po³¹czenie {0}", conApp.ConnectionName));
        mListView.Items.Clear();
        ImportFeatures();
    }

    void ImportFeatures()
    {
        PClient.GDatabase objDB = _connection.Database as PClient.GDatabase;
        PClient.GTableDefs tblDefs = objDB.GTableDefs as PClient.GTableDefs;
        PClient.GTableDef aliasTable = tblDefs["GAliasTable"];
        PClient.GField field = null;

        PClient.GRecordset dbRS = objDB.OpenRecordset("Select TableType, TableName From GAliasTable Where TableType='INGRFeatures'",
            PClient.GConstants.gdbOpenDynaset, null, null, null, null);

        string aliasTableName = null;

        while (!dbRS.EOF)
        {
            field = dbRS.GFields["TableName"];

            aliasTableName = (string)field.Value;

            dbRS.MoveNext();
        }

        dbRS.Close();

        if (string.IsNullOrEmpty(aliasTableName)) return;

        //WriteEvent("INGRFeatures table: " + aliasTableName);

        dbRS = objDB.OpenRecordset("Select FeatureName From " + aliasTableName,
            PClient.GConstants.gdbOpenDynaset, null, null, null, null);

        while (!dbRS.EOF)
        {
            field = dbRS.GFields["FeatureName"];

            string featureName = (string)field.Value;

            //WriteEvent(" Feature: " + featureName);
            ListViewItem item = new ListViewItem(featureName);
            item.SubItems.Add("");
            item.Checked = true;
            mListView.Items.Add(item);

            dbRS.MoveNext();
        }

        dbRS.Close();
    }

    bool ExportFeature(string featureName)
    {
        PClient.OriginatingPipe pipe;

        _connection.CreateOriginatingPipe(out pipe);
        pipe.Table = featureName;

        PClient.GRecordset recordset = pipe.OutputRecordset;
        int recordCount = recordset.RecordCount;

        if (recordCount == 0) return false;

        _mapInfoService.InputRecordset = recordset;
        _mapInfoService.OutputFileName = System.IO.Path.Combine(folderBrowserDialog.SelectedPath, featureName);
        _mapInfoService.Execute();

        return true;
    }

    private void exportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int exported = 0, empty = 0, skipped = 0;

        if (folderBrowserDialog.ShowDialog(this) != DialogResult.OK) return;

        foreach (ListViewItem item in mListView.Items)
        {
            if (item.Checked)
            {
                item.SubItems[1].Text = "Exporting...";
                if (ExportFeature(item.Text))
                {
                    item.SubItems[1].Text = "Done";
                    exported++;
                }
                else
                {
                    item.SubItems[1].Text = "Empty";
                    empty++;
                }
            }
            else
            {
                item.SubItems[1].Text = "Skipped";
                skipped++;
            }

            mListView.EnsureVisible(item.Index);
            mListView.Update();
        }

        MessageBox.Show(this,
            string.Format("Export complete.\nFeatures (not empty): {0}\nEmpty features: {1}\nSkipped features: {2}\nAll features: {3}",
            exported, empty, skipped, mListView.Items.Count),
            "gmCmdMapInfoExport - Eksport...",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    void SelectFeatures(bool check)
    {
        foreach (ListViewItem item in mListView.Items)
        {
            item.Checked = check;
        }
    }

    private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SelectFeatures(true);
    }

    private void odznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SelectFeatures(false);
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog(this) != DialogResult.OK) return;

        StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.GetEncoding(1250));

        foreach (ListViewItem item in mListView.Items)
        {
            writer.WriteLine("{0}\t{1}", item.SubItems[0].Text, item.SubItems[1].Text);
        }

        writer.Close();

        MessageBox.Show(this, "File saved.", "Save As...", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}




























