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

        public string prefLocation { get; set; }

        public PlayerPrefParser()
        {
            prefLocation = "C:/Users/Collin/AppData/LocalLow/DefaultCompany/Roguelands/PlayerPrefs.txt";
        }

        public PlayerPrefParser(string filepath)
        {
            prefLocation = filepath;
        }

        public Dictionary<string, string> Parse()
        {
            return Parse(prefLocation);
        }

        public Dictionary<string, string> Parse(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> prefs = new Dictionary<string, string>();

            string result = sr.ReadToEnd();

            var dictionary = result.Split(';');

            foreach (string part in dictionary)
            {
                string[] parts = part.Split(':');

                prefs.Add(parts[0], parts[1]);
            }

            Console.WriteLine(prefs.ToString());
            return prefs;
        }


    }
}
