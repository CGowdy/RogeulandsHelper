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
        private Dictionary<string, string> prefs = new Dictionary<string, string>();
        private string prefLocation = "C:/Users/Collin/AppData/LocalLow/DefaultCompany/Roguelands/PlayerPrefs.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadPlayerPrefs_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader(prefLocation);
            StringBuilder sb = new StringBuilder();

            string result = sr.ReadToEnd();

            var dictionary = result.Split(';');

            foreach(string part in dictionary)
            {
                string[] parts = part.Split(':');

                prefs.Add(parts[0], parts[1]);
            }

            Console.WriteLine(prefs.ToString());
        }
    }
}
