using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelands_Helper
{
    class PlayerPrefParser
    {
        public Dictionary<string, PrefValue> playerPrefs { get; set; }

        public string prefLocation { get; set; }

        public PlayerPrefParser()
        {
            prefLocation = "C:/Users/Collin/AppData/LocalLow/DefaultCompany/Roguelands/PlayerPrefs.txt";
        }

        public PlayerPrefParser(string filepath)
        {
            prefLocation = filepath;
        }

        public Dictionary<string, PrefValue> Parse()
        {
            return Parse(prefLocation);
        }

        public Dictionary<string, PrefValue> Parse(string filepath)
        {
            StringBuilder sb = new StringBuilder();
            playerPrefs = new Dictionary<string, PrefValue>();

            using (StreamReader sr = new StreamReader(filepath))
            {
                string result = sr.ReadToEnd();

                var dictionary = result.Split(';');

                foreach (string part in dictionary)
                {
                    string[] parts = part.Split(':');

                    playerPrefs.Add(parts[0].Trim(), new PrefValue(parts[1].Trim(),parts[2].Trim()));
                }
            }
            return playerPrefs;
        }


    }
}
