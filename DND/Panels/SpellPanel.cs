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
    public partial class SpellPanel : UserControl
    {
        public SpellPanel()
        {
            InitializeComponent();
        }
        public void SetValue(Spell spell)
        {
            txtBx_Spell_Classes.Text = spell.classes;
            txtBx_Spell_Components.Text = spell.components;
            txtBx_Spell_Duration.Text = spell.duration;
            txtBx_Spell_Level.Text = spell.level;
            txtBx_Spell_Name.Text = spell.name;
            txtBx_Spell_Range.Text = spell.range;
            txtBx_Spell_Roll.Text = spell.roll;
            txtBx_Spell_School.Text = spell.school;
            txtBx_Spell_Text.Text = spell.text;
            txtBx_Spell_Time.Text = spell.time;
        }
    }
}
