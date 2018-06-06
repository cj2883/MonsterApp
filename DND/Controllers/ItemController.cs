using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DND.Models;

namespace DND.Controllers
{
    class ItemController : BaseController
    {
        public ItemController(string dataSource) : base(dataSource)
        {  }
        public List<string> GetItemList()
        {
            List<string> returnValues = new List<string>();
            foreach (XmlNode node in document.DocumentElement.SelectNodes(@"//compendium/item/name"))
            {
                returnValues.Add(node.InnerText);
            }
            return returnValues;
        }

        internal Item GetItem(string itemName)
        {
            Item returnItem = new Item();
            XmlNode spellNode = document.DocumentElement.SelectSingleNode("//*[text()=\"" + itemName + "\"]").ParentNode;
            SetValue(ref returnItem.ac, spellNode.SelectSingleNode(@"ac"));
            SetValue(ref returnItem.dmg1, spellNode.SelectSingleNode(@"dmg1"));
            SetValue(ref returnItem.dmg2, spellNode.SelectSingleNode(@"dmg2"));
            SetValue(ref returnItem.dmgtype, spellNode.SelectSingleNode(@"dmgtype"));
            SetValue(ref returnItem.magic, spellNode.SelectSingleNode(@"magic"));
            SetValue(ref returnItem.name, spellNode.SelectSingleNode(@"name"));
            SetValue(ref returnItem.property, spellNode.SelectSingleNode(@"property"));
            SetValue(ref returnItem.range, spellNode.SelectSingleNode(@"range"));
            SetValue(ref returnItem.rarity, spellNode.SelectSingleNode(@"rarity"));
            SetValue(ref returnItem.stealth, spellNode.SelectSingleNode(@"stealth"));
            SetValue(ref returnItem.strength, spellNode.SelectSingleNode(@"strength"));
            SetValue(ref returnItem.type, spellNode.SelectSingleNode(@"type"));
            SetValue(ref returnItem.weight, spellNode.SelectSingleNode(@"weight"));

            returnItem.text = "";
            foreach (XmlNode element in spellNode.SelectNodes(@"text"))
            {
                returnItem.text += element.InnerText + Environment.NewLine;
            }

            return returnItem;
        }
    }
}
