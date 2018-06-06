using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Models
{
    public class StatBlock
    {
        public string str;
        public string dex;
        public string con;
        public string intelligence;
        public string wis;
        public string cha;

        static public int GetModifier(int Value)
        {
            decimal dec = (Value - 10) / 2;
            return (int)Math.Floor(dec);
        }
    }
}
