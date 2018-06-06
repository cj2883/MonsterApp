using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND.Models;

namespace DND.Panels
{
    public partial class ItemPanel : UserControl
    {
        public ItemPanel()
        {
            InitializeComponent();
        }
        public void SetValue(DND.Models.Item item)
        {
            txtBx_Item_AC.Text = item.ac;
            txtBx_Item_Damage.Text = item.dmg1 + " " + item.dmg2;
            txtBx_Item_DamageType.Text = item.dmgtype;
            chkBx_Item_Magic.Checked = String.IsNullOrEmpty(item.magic) ? false : item.magic.ToUpper() == "YES";
            txtBx_Item_Name.Text = item.name;
            txtBx_Item_Property.Text = item.property;
            txtBx_Item_Range.Text = item.range;
            txtBx_Item_Rarity.Text = item.rarity;
            txtBx_Item_Stealth.Text = item.stealth;
            txtBx_Item_Str.Text = item.strength;
            txtBx_Item_Text.Text = item.text;
            txtBx_Item_Type.Text = item.type;
            txtBx_Item_Weight.Text = item.weight;
        }
    }
}
