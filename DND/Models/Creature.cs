using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Models
{
    public class Creature : StatBlock
    {
        public string name = "";
        public string size = "";
        public string type = "";
        public string alignment = "";
        public string ac = "";
        public string hp = "";
        public string speed = "";
        public string save = "";
        public string skill = "";
        public string resist = "";
        public string vulnerable = "";
        public string immune = "";
        public string conditionImmune = "";
        public string senses = "";
        public string passive = "";
        public string languages = "";
        public string cr = "";
        public List<Trait> traits = new List<Trait>();
        public List<Action> actions = new List<Action>();
        public List<Action> reactions = new List<Action>();
        public List<Action> legendaryActions = new List<Action>();
        public string spells = "";

        static public DataTable GenerateNewTable()
        {
            DataTable dt = new DataTable("Creatures");

            //Stat Block
            dt.Columns.Add("Str", typeof(string));
            dt.Columns.Add("Dex", typeof(string));
            dt.Columns.Add("Con", typeof(string));
            dt.Columns.Add("Int", typeof(string));
            dt.Columns.Add("Wis", typeof(string));
            dt.Columns.Add("Cha", typeof(string));


            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Alignment", typeof(string));
            dt.Columns.Add("AC", typeof(string));
            dt.Columns.Add("HP", typeof(string));
            dt.Columns.Add("Speed", typeof(string));
            dt.Columns.Add("Save", typeof(string));
            dt.Columns.Add("Skill", typeof(string));
            dt.Columns.Add("Resists", typeof(string));
            dt.Columns.Add("Vulnerable", typeof(string));
            dt.Columns.Add("Immune", typeof(string));
            dt.Columns.Add("ConditionImmune", typeof(string));
            dt.Columns.Add("Senses", typeof(string));
            dt.Columns.Add("Passive", typeof(string));
            dt.Columns.Add("Languages", typeof(string));
            dt.Columns.Add("CR", typeof(string));
            dt.Columns.Add("Traits", typeof(string));
            dt.Columns.Add("Actions", typeof(string));
            dt.Columns.Add("Reactions", typeof(string));
            dt.Columns.Add("LegendaryActions", typeof(string));
            dt.Columns.Add("Spells", typeof(string));

            return dt;
        }
        internal void PopulateDataRow(ref DataRow dr)
        {
            dr["Str"] = str + GetModifierString(str);
            dr["Dex"] = dex + GetModifierString(dex);
            dr["Con"] = con + GetModifierString(con);
            dr["Int"] = intelligence + GetModifierString(intelligence);
            dr["Wis"] = wis + GetModifierString(wis);
            dr["Cha"] = cha + GetModifierString(cha);
            dr["Name"] = name;
            dr["Size"] = size;
            dr["Type"] = type;
            dr["Alignment"] = alignment;
            dr["AC"] = ac;
            dr["HP"] = hp;
            dr["Speed"] = speed;
            dr["Save"] = save;
            dr["Skill"] = skill;
            dr["Resists"] = resist;
            dr["Vulnerable"] = vulnerable;
            dr["Immune"] = immune;
            dr["ConditionImmune"] = conditionImmune;
            dr["Senses"] = senses;
            dr["Passive"] = passive;
            dr["Languages"] = languages;
            dr["CR"] = cr;
            dr["Traits"] = GetStringOfTraits(traits);
            dr["Actions"] = GetStringOfActions(actions);
            dr["Reactions"] = GetStringOfActions(reactions);
            dr["LegendaryActions"] = GetStringOfActions(legendaryActions);
            dr["Spells"] = spells;
        }
        public string BuildHomebrewery()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("___");
            sb.AppendLine("> ## " + name);
            sb.AppendLine(">*" + GetSizeString(size) + " " + type + ", " + alignment + "*");
            sb.AppendLine(">___");
            sb.AppendLine("> - **Armor Class** " + ac);
            sb.AppendLine("> - **Hit Points** " + hp);
            sb.AppendLine("> - **Speed** " + speed);
            sb.AppendLine(">___");
            sb.AppendLine(">|STR|DEX|CON|INT|WIS|CHA|");
            sb.AppendLine(">|:---:|:---:|:---:|:---:|:---:|:---:|");
            sb.AppendLine(">|" + str + GetModifierString(str) + "|" + dex + GetModifierString(dex) + "|" + con + GetModifierString(con) + "|" + intelligence + GetModifierString(intelligence) + "|" + wis + GetModifierString(wis) + "|" + cha + GetModifierString(cha) + "|");
            sb.AppendLine(">___");
            if (skill != "")
                sb.AppendLine("> - **Skills** " + skill);
            if (save != "")
                sb.AppendLine("> - **Saving Throws** " + save);
            if (vulnerable != null)
                sb.AppendLine("> - **Damage Vulnerabilities** " + vulnerable);
            if (resist != "")
                sb.AppendLine("> - **Damage Resistances** " + resist);
            if (immune != "")
                sb.AppendLine("> - **Damage Immunities** " + immune);
            if (conditionImmune != "")
                sb.AppendLine("> - **Condition Immunities** " + conditionImmune);
            if (senses != "")
                sb.AppendLine("> - **Senses** " + senses);
            if (languages != "")
                sb.AppendLine("> - **Languages** " + languages);
            if (cr != "")
                sb.AppendLine("> - **Challenge** " + cr);
            sb.AppendLine(">___");
            foreach(Trait myTrait in traits)
                sb.AppendLine("> ***" + myTrait.name + ". ***" + myTrait.text.Replace(Environment.NewLine, Environment.NewLine + ">"));
            if(actions.Count > 0)
            {
                sb.AppendLine("> ### Actions");
                foreach (Action myAction in actions)
                    sb.AppendLine("> ***" + myAction.name + ".*** *" + myAction.attack + ":* " + myAction.text);
            }
            if (legendaryActions.Count > 0)
            {
                sb.AppendLine("> ### Legendary Actions");
                foreach (Action myAction in legendaryActions)
                    sb.AppendLine("> ***" + myAction.name + ".*** *" + myAction.attack + ":* " + myAction.text);
            }

            return sb.ToString();
        }

        private string GetSizeString(string size)
        {
            string returnValue = "Medium";
            switch (size)
            {
                case ("M"):
                    returnValue = "Medium";
                    break;
                case ("S"):
                    returnValue = "Small";
                    break;
                case ("L"):
                    returnValue = "Large";
                    break;
                case ("H"):
                    returnValue = "Huge";
                    break;
                case ("T"):
                    returnValue = "Tiny";
                    break;
                case ("G"):
                    returnValue = "Gargantuan";
                    break;
                default:
                    returnValue = size;
                    break;
            }
            return returnValue;
        }

        private string GetStringOfTraits(List<Trait> traits)
        {
            string returnValue = "";
            if (traits != null)
            {
                foreach (Trait trait in traits)
                {
                    returnValue += trait.ToString();
                }
            }
            return returnValue;
        }
        private string GetStringOfActions(List<Action> actions)
        {
            string returnValue = "";
            if (actions != null)
            {
                foreach (Action action in actions)
                {
                    returnValue += action.ToString();
                }
            }
            return returnValue;
        }
        private string GetModifierString(string statValue)
        {
            int modiferValue = StatBlock.GetModifier(Int32.Parse(statValue));
            return " (" + ((modiferValue > 0) ? "+" : "") + modiferValue.ToString() + ")";
        }
    }
}
