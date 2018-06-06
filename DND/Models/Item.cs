using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Models
{
    public class Item
    {
        public string name;
        public string type = "";
        public string magic = "";
        public string weight = "";
        public string ac = "";
        public string strength = "";
        public string stealth = "";
        public string dmg1 = "";
        public string dmg2 = "";
        public string dmgtype = "";
        public string property = "";
        public string range = "";
        public string rarity = "";
        public string text = "";

        static public DataTable GenerateNewTable()
        {
            DataTable dt = new DataTable("Items");

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Weight", typeof(string));
            dt.Columns.Add("Text", typeof(string));

            return dt;
        }

        public void PopulateDataRow(ref DataRow dr)
        {
            dr["Name"] = name;
            dr["Type"] = ((magic == "") ? "" : "Magical ") + type;
            dr["Weight"] = weight + " lb";
            dr["Text"] = "";
            if (ac.ToUpper() != "")
                dr["Text"] += "AC = " + ac + Environment.NewLine;
            if (strength.ToUpper() != "")
                dr["Text"] += "Requires a base Str of " + strength + Environment.NewLine;
            if (stealth.ToUpper() == "YES")
                dr["Text"] += "Imposes a disadvantage on stealth checks." + Environment.NewLine;
            if(dmg1.ToUpper() != "")
                dr["Text"] += dmg1 + dmgtype + Environment.NewLine + ((dmg2 == "") ? dmg2 + dmgtype + Environment.NewLine : "");
            if(property.ToUpper() != "")    
                dr["Text"] += property + Environment.NewLine;
            if(range.ToUpper() != "")   
                dr["Text"] += range + Environment.NewLine;
            
            dr["Text"] += text;

        }
        public string BuildHomebrewery()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("___");
            sb.AppendLine("####" + name);
            sb.AppendLine("*"+ ((magic == "") ? "" : "Magical ") + type + "*");
            sb.AppendLine("This " + type + " weighs " + weight + " lbs.");
            if (ac.ToUpper() != "")
                sb.AppendLine("AC = " + ac);
            if (strength.ToUpper() != "")
                sb.AppendLine("Requires a base Str of " + strength);
            if (stealth.ToUpper() == "YES")
                sb.AppendLine("Imposes a disadvantage on stealth checks.");
            if (dmg1.ToUpper() != "")
                sb.AppendLine(dmg1 + dmgtype + Environment.NewLine + ((dmg2 == "") ? dmg2 + dmgtype : ""));
            if (property.ToUpper() != "")
                sb.AppendLine(property);
            if (range.ToUpper() != "")
                sb.AppendLine("Range: " + range);
            sb.AppendLine(text);

            return sb.ToString();
        }
    }
}
