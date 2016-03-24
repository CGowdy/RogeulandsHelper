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

            dgvPlayer0.CellValueChanged += new DataGridViewCellEventHandler(RefreshMainDataGrid);
            dgvPlayer1.CellValueChanged += new DataGridViewCellEventHandler(RefreshMainDataGrid);
            dgvPlayer2.CellValueChanged += new DataGridViewCellEventHandler(RefreshMainDataGrid);
            dgvPlayer3.CellValueChanged += new DataGridViewCellEventHandler(RefreshMainDataGrid);
            dgvPlayer4.CellValueChanged += new DataGridViewCellEventHandler(RefreshMainDataGrid);
            dgvPlayer5.CellValueChanged += new DataGridViewCellEventHandler(RefreshMainDataGrid);
            dgvStorageChest.CellValueChanged += new DataGridViewCellEventHandler(RefreshMainDataGrid);
        }

        private void PopulateMain()
        {
            allPrefs = playerPrefs.GetAllPrefsDataTable();
            dgvMainView.DataSource = allPrefs;
            dgvMainView.Columns[1].ReadOnly = false;
        }

        public void PopulatePlayerData()
        {
            string[] playerNums = { "0", "1", "2", "3", "4", "5" };

            foreach (string playernum in playerNums)
            {
                DataTable temp = playerPrefs.GetPlayerDataDataTable(playernum);
                TabPage tp = (TabPage)this.Controls.Find("tpPlayer" + playernum, true).FirstOrDefault();
                DataGridView dgv = (DataGridView)this.Controls.Find("dgvPlayer" + playernum, true).FirstOrDefault();
                dgv.DataSource = temp;

                if (temp.Rows.Count > 0)
                {
                    DataRow dr = temp.Select("Key LIKE '*name'").FirstOrDefault();
                    if (dr == null)
                    {
                        tp.Text = "Empty";
                        tp.Enabled = false;
                        continue;
                    }
                    tp.Text = dr[1].ToString();
                    tp.Enabled = true;
                    dgv.Columns[1].ReadOnly = false;
                }
                else
                {
                    tp.Text = "Empty";
                    tp.Enabled = false;
                }
            }

        }

        public void PopulateStorageData()
        {
            DataTable temp = playerPrefs.GetStorageData();
            dgvStorageChest.DataSource = temp;
            dgvStorageChest.Columns[1].ReadOnly = false;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            File.Copy(fp.prefLocation, fp.prefLocation + ".backup", true);
            
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
            foreach(DataRow row in (DataGridView)sender.Rows)
            {

            }
            return;
        }
    }
}