using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DND.Models
{
    public class Spell
    { 
        public string name;
        public string level;
        public string school;
        public string ritual;
        public string time;
        public string range;
        public string components;
        public string duration;
        public string classes;
        public string text;
        public string roll;


        static public DataTable GenerateNewTable()
        {
            DataTable dt = new DataTable("Spelss");

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Level", typeof(string));
            dt.Columns.Add("School", typeof(string));
            dt.Columns.Add("Ritual", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Range", typeof(string));
            dt.Columns.Add("Components", typeof(string));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Classes", typeof(string));
            dt.Columns.Add("Text", typeof(string));
            dt.Columns.Add("Roll", typeof(string));

            return dt;
        }

        internal void PopulateDataRow(ref DataRow dr)
        {
            dr["Name"] = name;
            dr["Level"] = level;
            dr["School"] = school;
            dr["Ritual"] = ritual;
            dr["Time"] = time;
            dr["Range"] = range;
            dr["Components"] = components;
            dr["Duration"] = duration;
            dr["Classes"] = classes;
            dr["Text"] = text;
            dr["Roll"] = roll;
        }
        public string BuildHomebrewery()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#### " + name);
            sb.AppendLine("*" + MathExtensions.ToOrdinal(level) + "-level " + school + " " + ((ritual == "" || ritual.ToUpper() == "YES") ? "" : "(ritual)") + "*");
            sb.AppendLine("___");
            sb.AppendLine("- **Casting Time:** " + time);
            if (range != "")
                sb.AppendLine("- **Range:** " + range);
            if (components != "")
                sb.AppendLine("- **Components:** " + components);
            if (duration != "")
                sb.AppendLine("- **Duration: " + duration);
            sb.AppendLine(text);

            return sb.ToString();
        }

            public Spell Clone()
        {
            Spell returnspell = new Spell();
            returnspell.name = name;
            returnspell.level = level;
            returnspell.school = school;
            returnspell.ritual = ritual;
            returnspell.time = time;
            returnspell.range = range;
            returnspell.components = components;
            returnspell.duration = duration;
            returnspell.classes = classes;
            returnspell.text = text;
            returnspell.roll = roll;

            return returnspell;
        }
    }
}
