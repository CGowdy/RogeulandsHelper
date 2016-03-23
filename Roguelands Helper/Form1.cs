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


        public Form1()
        {
            InitializeComponent();
            fp = new PlayerPrefParser();
        }

        private void btnLoadPlayerPrefs_Click(object sender, EventArgs e)
        {
            Dictionary<string, PrefValue> playerPrefs = fp.Parse();
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            playerPrefs.ToList()
                .ForEach(kvp => dt.Rows.Add(new object[] { kvp.Key, kvp.Value.value, kvp.Value.type }));
            dgvMainView.DataSource = dt;
            dgvMainView.Columns[1].ReadOnly = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            File.Copy(fp.prefLocation, fp.prefLocation + ".backup", true);

            Dictionary<string, PrefValue> dict = new Dictionary<string, PrefValue>();
            DataTable dt = (DataTable)dgvMainView.DataSource;
            dt.AsEnumerable()
                .ToList()
                .ForEach(row => dict.Add(row[0] as string, new PrefValue(row[1] as string, row[2] as string)));

            StringBuilder sb = new StringBuilder();

            foreach (string key in dict.Keys)
            {
                PrefValue value;
                if (dict.TryGetValue(key, out value))
                    sb.Append(key + " : " + value.value + " : " + value.type + " ; ");
            }
            sb.Remove(sb.Length - 2, 1);
            File.WriteAllText(fp.prefLocation, sb.ToString().Trim());
        }
    }
}
