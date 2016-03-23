using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelands_Helper
{
    class PrefValue
    {
        public string value { get; set; }
        public string type { get; set; }

        public PrefValue(string value, string type)
        {
            this.value = value;
            this.type = type;
        }
    }
}
