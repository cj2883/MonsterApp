using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DND.Models;

namespace DND.Controllers
{
    class SpellController : BaseController
    {
        public SpellController(string dataSource) : base(dataSource)
        {
            
        }
        public List<string> GetSpellList()
        {
            List<string> returnValues = new List<string>();
            foreach (XmlNode node in document.DocumentElement.SelectNodes(@"//compendium/spell/name"))
            {
                returnValues.Add(node.InnerText);
            }
            return returnValues;
        }

        internal Spell GetSpell(string spellName)
        {
            Spell returnSpell = new Spell();
            XmlNode spellNode = document.DocumentElement.SelectSingleNode("//*[text()=\"" + spellName + "\"]").ParentNode;
            SetValue(ref returnSpell.classes, spellNode.SelectSingleNode(@"classes"));
            SetValue(ref returnSpell.components, spellNode.SelectSingleNode(@"components"));
            SetValue(ref returnSpell.duration, spellNode.SelectSingleNode(@"duration"));
            SetValue(ref returnSpell.level, spellNode.SelectSingleNode(@"level"));
            SetValue(ref returnSpell.name, spellNode.SelectSingleNode(@"name"));
            SetValue(ref returnSpell.range, spellNode.SelectSingleNode(@"range"));
            SetValue(ref returnSpell.ritual, spellNode.SelectSingleNode(@"ritual"));
            SetMultiLineValue(ref returnSpell.roll, spellNode.SelectNodes(@"roll"));
            SetValue(ref returnSpell.school, spellNode.SelectSingleNode(@"school"));
            SetMultiLineValue(ref returnSpell.text, spellNode.SelectNodes(@"text"));
            SetValue(ref returnSpell.text, spellNode.SelectSingleNode(@"text"));
            SetValue(ref returnSpell.time, spellNode.SelectSingleNode(@"time"));

            return returnSpell;
        }
    }
}
