using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelands_Helper
{
    class PlayerPrefs
    {
        public Dictionary<string, PrefValue> playerPrefs;

        public PlayerPrefs()
        {
            playerPrefs = new Dictionary<string, PrefValue>();
        }

        public DataTable GetAllPrefsDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            playerPrefs.ToList()
                .ForEach(kvp => dt.Rows.Add(new object[] { kvp.Key, kvp.Value.value, kvp.Value.type }));

            return dt;
        }

        public DataTable GetPlayerDataDataTable(string playerNum)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            playerPrefs.Where(kvp => kvp.Key.StartsWith(playerNum))
                .ToList()
                .ForEach(kvp => dt.Rows.Add(new object[] { kvp.Key, kvp.Value.value, kvp.Value.type }));

            return dt;
        }

        public DataTable GetStorageData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            playerPrefs.Where(kvp => kvp.Key.Contains("storage"))
                .ToList()
                .ForEach(kvp => dt.Rows.Add(new object[] { kvp.Key, kvp.Value.value, kvp.Value.type }));

            return dt;
        }

        public bool UpdatePlayerPrefs(DataTable newPrefs)
        {
            foreach(DataRow row in newPrefs.Rows)
            {
                playerPrefs[(string)row[0]].value = (string)row[1];
            }
            return true;
        }
    }
}
