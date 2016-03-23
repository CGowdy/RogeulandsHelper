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
            fp.Parse();
        }
    }
}
