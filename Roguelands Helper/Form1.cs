using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Roguelands_Helper
{
    public partial class Form1 : Form
    {
        PlayerPrefParser fp;
        PlayerPrefs playerPrefs;
        DataTable allPrefs;
        DataView allPrefsView;
        DataView player0View;
        DataView player1View;
        DataView player2View;
        DataView player3View;
        DataView player4View;
        DataView player5View;
        DataView storageView;

        public Form1()
        {
            InitializeComponent();
            fp = new PlayerPrefParser();
            playerPrefs = new PlayerPrefs();
            allPrefs = new DataTable();
        }

        private void btnLoadPlayerPrefs_Click(object sender, EventArgs e)
        {
            playerPrefs.playerPrefs = fp.Parse();
            PopulateMain();
            PopulatePlayerData();
            PopulateStorageData();
        }

        private void PopulateMain()
        {
            allPrefs = playerPrefs.GetAllPrefsDataTable();
            allPrefsView = new DataView(allPrefs);
            player0View = new DataView(allPrefs);
            player1View = new DataView(allPrefs);
            player2View = new DataView(allPrefs);
            player3View = new DataView(allPrefs);
            player4View = new DataView(allPrefs);
            player5View = new DataView(allPrefs);
            storageView = new DataView(allPrefs);
            allPrefsView.Sort = "Key";
            player0View.Sort = "Key";
            player1View.Sort = "Key";
            player2View.Sort = "Key";
            player3View.Sort = "Key";
            player4View.Sort = "Key";
            player5View.Sort = "Key";
            storageView.Sort = "Key";
            dgvMainView.DataSource = allPrefsView;
        }

        public void PopulatePlayerData()
        {
            string[] playerNums = { "0", "1", "2", "3", "4", "5" };

            foreach (string playernum in playerNums)
            {
                TabPage tp = (TabPage)this.Controls.Find("tpPlayer" + playernum, true).FirstOrDefault();
                DataGridView dgv = (DataGridView)this.Controls.Find("dgvPlayer" + playernum, true).FirstOrDefault();
                switch (playernum)
                {
                    case "0":
                        BindingSource source0 = new BindingSource();
                        source0.DataSource = player0View;
                        source0.Filter = "Key LIKE '" + playernum + "*'";
                        dgv.DataSource = source0;
                        if (player0View.Count > 0)
                        {
                            int rowIndex = player0View.Find(playernum + "name");
                            if (rowIndex < 0)
                            {
                                tp.Text = "Empty";
                                tp.Enabled = false;
                                continue;
                            }
                            tp.Text = player0View[rowIndex][1].ToString();
                            tp.Enabled = true;
                        }
                        break;
                    case "1":
                        BindingSource source1 = new BindingSource();
                        source1.DataSource = player1View;
                        source1.Filter = "Key LIKE '" + playernum + "*'";
                        dgv.DataSource = source1;
                        if (player1View.Count > 0)
                        {
                            int rowIndex = player1View.Find(playernum + "name");
                            if (rowIndex < 0)
                            {
                                tp.Text = "Empty";
                                tp.Enabled = false;
                                continue;
                            }
                            tp.Text = player1View[rowIndex][1].ToString();
                            tp.Enabled = true;
                        }
                        break;
                    case "2":
                        BindingSource source2 = new BindingSource();
                        source2.DataSource = player2View;
                        source2.Filter = "Key LIKE '" + playernum + "*'";
                        dgv.DataSource = source2;
                        if (player2View.Count > 0)
                        {
                            int rowIndex = player2View.Find(playernum + "name");
                            if (rowIndex < 0)
                            {
                                tp.Text = "Empty";
                                tp.Enabled = false;
                                continue;
                            }
                            tp.Text = player2View[rowIndex][1].ToString();
                            tp.Enabled = true;
                        }
                        break;
                    case "3":
                        BindingSource source3 = new BindingSource();
                        source3.DataSource = player3View;
                        source3.Filter = "Key LIKE '" + playernum + "*'";
                        dgv.DataSource = source3;
                        if (player3View.Count > 0)
                        {
                            int rowIndex = player3View.Find(playernum + "name");
                            if (rowIndex < 0)
                            {
                                tp.Text = "Empty";
                                tp.Enabled = false;
                                continue;
                            }
                            tp.Text = player3View[rowIndex][1].ToString();
                            tp.Enabled = true;
                        }
                        break;
                    case "4":
                        BindingSource source4 = new BindingSource();
                        source4.DataSource = player4View;
                        source4.Filter = "Key LIKE '" + playernum + "*'";
                        dgv.DataSource = source4;
                        if (player4View.Count > 0)
                        {
                            int rowIndex = player4View.Find(playernum + "name");
                            if (rowIndex < 0)
                            {
                                tp.Text = "Empty";
                                tp.Enabled = false;
                                continue;
                            }
                            tp.Text = player4View[rowIndex][1].ToString();
                            tp.Enabled = true;
                        }
                        break;
                    case "5":
                        BindingSource source5 = new BindingSource();
                        source5.DataSource = player5View;
                        source5.Filter = "Key LIKE '" + playernum + "*'";
                        dgv.DataSource = source5;
                        if (player5View.Count > 0)
                        {
                            int rowIndex = player5View.Find(playernum + "name");
                            if (rowIndex < 0)
                            {
                                tp.Text = "Empty";
                                tp.Enabled = false;
                                continue;
                            }
                            tp.Text = player5View[rowIndex][1].ToString();
                            tp.Enabled = true;
                        }
                        break;
                }
            }

        }

        public void PopulateStorageData()
        {
            BindingSource source = new BindingSource();
            source.DataSource = storageView;
            source.Filter = "Key LIKE '*storage*'";
            dgvStorageChest.DataSource = source;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            File.Copy(fp.prefLocation, fp.prefLocation + ".backup", true);

            playerPrefs.UpdatePlayerPrefs(allPrefs);
            StringBuilder sb = new StringBuilder();

            foreach (string key in playerPrefs.playerPrefs.Keys)
            {
                PrefValue value;
                if (playerPrefs.playerPrefs.TryGetValue(key, out value))
                    sb.Append(key + " : " + value.value + " : " + value.type + " ; ");
            }
            sb.Remove(sb.Length - 2, 1);
            File.WriteAllText(fp.prefLocation, sb.ToString().Trim());
        }

        private void dgvPlayer5_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshMainDataGrid(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}