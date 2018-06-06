using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Models
{
    public class Trait
    {
        public string name;
        public string text;

        public override string ToString()
        { return name + ": " + text; }
    }
}
