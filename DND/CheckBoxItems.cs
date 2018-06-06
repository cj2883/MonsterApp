using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    class CheckBoxItems
    {
        public CheckBoxItems(string Path, string Display)
        {
            path = Path;
            display = Display;
        }
        public string path;
        public string display;
        public override string ToString()
        {
            return display;
        }
    }
}
