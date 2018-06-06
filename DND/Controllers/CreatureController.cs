using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DND.Models;

namespace DND.Controllers
{
    class CreatureController : BaseController
    {
        public CreatureController(string dataSource) : base(dataSource)
        {  }

        public List<string> GetCreatureList()
        {
            List<string> returnValues = new List<string>();
            foreach (XmlNode node in document.DocumentElement.SelectNodes(@"//compendium/monster/name"))
            {
                returnValues.Add(node.InnerText);
            }
            return returnValues;
        }
        public Creature GetCreature(string creatureName)
        {
            Creature returnItem = new Creature();
            XmlNode creatureNode = document.DocumentElement.SelectSingleNode("//*[text()=\"" + creatureName + "\"]").ParentNode;

            SetValue(ref returnItem.ac, creatureNode.SelectSingleNode(@"ac"));
            SetActions(ref returnItem.actions, creatureNode.SelectNodes(@"action"));
            SetValue(ref returnItem.alignment, creatureNode.SelectSingleNode(@"alignment"));
            SetValue(ref returnItem.conditionImmune, creatureNode.SelectSingleNode(@"conditionImmune"));
            SetValue(ref returnItem.cr, creatureNode.SelectSingleNode(@"cr"));
            SetValue(ref returnItem.hp, creatureNode.SelectSingleNode(@"hp"));
            SetValue(ref returnItem.immune, creatureNode.SelectSingleNode(@"immune"));
            SetValue(ref returnItem.languages, creatureNode.SelectSingleNode(@"languages"));
            SetActions(ref returnItem.legendaryActions, creatureNode.SelectNodes(@"legendaryAction"));
            SetValue(ref returnItem.name, creatureNode.SelectSingleNode(@"name"));
            SetValue(ref returnItem.passive, creatureNode.SelectSingleNode(@"passive"));
            SetActions(ref returnItem.reactions, creatureNode.SelectNodes(@"reaction"));
            SetValue(ref returnItem.resist, creatureNode.SelectSingleNode(@"resist"));
            SetValue(ref returnItem.save, creatureNode.SelectSingleNode(@"save"));
            SetValue(ref returnItem.senses, creatureNode.SelectSingleNode(@"senses"));
            SetValue(ref returnItem.size, creatureNode.SelectSingleNode(@"size"));
            SetValue(ref returnItem.skill, creatureNode.SelectSingleNode(@"skill"));
            SetValue(ref returnItem.speed, creatureNode.SelectSingleNode(@"speed"));
            SetValue(ref returnItem.spells, creatureNode.SelectSingleNode(@"spells"));
            SetTraits(ref returnItem.traits, creatureNode.SelectNodes(@"trait"));
            SetValue(ref returnItem.type, creatureNode.SelectSingleNode(@"type"));
            SetValue(ref returnItem.vulnerable, creatureNode.SelectSingleNode(@"vulnerable"));
            SetValue(ref returnItem.str, creatureNode.SelectSingleNode(@"str"));
            SetValue(ref returnItem.dex, creatureNode.SelectSingleNode(@"dex"));
            SetValue(ref returnItem.con, creatureNode.SelectSingleNode(@"con"));
            SetValue(ref returnItem.intelligence, creatureNode.SelectSingleNode(@"int"));
            SetValue(ref returnItem.wis, creatureNode.SelectSingleNode(@"wis"));
            SetValue(ref returnItem.cha, creatureNode.SelectSingleNode(@"cha"));

            return returnItem;
        }

        private void SetTraits(ref List<Models.Trait> traits, XmlNodeList xmlNodeList)
        {
            foreach (XmlNode node in xmlNodeList)
            {
                Models.Trait t = new Models.Trait();
                SetMultiLineValue(ref t.text, ((XmlElement)node).SelectNodes(@"text"));
                SetValue(ref t.name, ((XmlElement)node).SelectSingleNode(@"name"));
                traits.Add(t);
            }
        }

        private void SetActions(ref List<Models.Action> actions, XmlNodeList xmlNodeList)
        {
            foreach (XmlNode node in xmlNodeList)
            {
                Models.Action a = new Models.Action();
                SetMultiLineValue(ref a.attack, ((XmlElement)node).SelectNodes(@"attack"));
                SetMultiLineValue(ref a.text, ((XmlElement)node).SelectNodes(@"text"));
                SetValue(ref a.name, ((XmlElement)node).SelectSingleNode(@"name"));
                actions.Add(a);
            }
        }

        public decimal CalculateCR(Models.Creature creature)
        {
            return CRController.CalculateCR(creature).CR;
        }
    }
}
