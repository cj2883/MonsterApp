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
    public partial class BestiaryPanel : UserControl
    {
        public BestiaryPanel()
        {
            InitializeComponent();
        }
        public void SetValue(Creature creature)
        {
            txtBx_Creature_AC.Text = creature.ac;
            txtBx_Creature_Alignment.Text = creature.alignment;
            txtBx_Creature_CHA.Text = creature.cha;
            txtBx_Creature_CON.Text = creature.con;
            txtBx_Creature_ConditionImmune.Text = creature.conditionImmune;
            txtBx_Creature_CR.Text = creature.cr;
            txtBx_Creature_DEX.Text = creature.dex;
            txtBx_Creature_HP.Text = creature.hp;
            txtBx_Creature_Immune.Text = creature.immune;
            txtBx_Creature_INT.Text = creature.intelligence;
            txtBx_Creature_Languages.Text = creature.languages;
            txtBx_Creature_Name.Text = creature.name;
            txtBx_Creature_PassivePerception.Text = creature.passive;
            txtBx_Creature_Resist.Text = creature.resist;
            txtBx_Creature_Save.Text = creature.save;
            txtBx_Creature_Senses.Text = creature.senses;
            txtBx_Creature_Size.Text = creature.size;
            txtBx_Creature_Skill.Text = creature.skill;
            txtBx_Creature_Speed.Text = creature.speed;
            txtBx_Creature_Spells.Text = creature.spells;
            txtBx_Creature_STR.Text = creature.str;
            txtBx_Creature_Type.Text = creature.type;
            txtBx_Creature_Vulnerable.Text = creature.vulnerable;
            txtBx_Creature_WIS.Text = creature.wis;
        }
    }
}
