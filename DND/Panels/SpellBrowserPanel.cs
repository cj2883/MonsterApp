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
    public partial class SpellBrowserPanel : UserControl
    {
        public SpellBrowserPanel()
        {
            InitializeComponent();
        }

        public void LoadBrowser(string[] list)
        {
            foreach (string source in list)
            {
                chkLst_Spell_Resources.Add(new CheckBoxItems(source, System.IO.Path.GetFileName(source)));
            }
        }

        private void chkLst_Spells_Resources_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            string xmlPath = ((CheckBoxItems)chkLst_Spell_Resources.Items[e.Index]).path;
            Controllers.SpellController sController = new Controllers.SpellController(xmlPath);

            chkLst_Resources_ItemCheck(xmlPath, chkLst_Spell_list, sController.GetSpellList(), e.NewValue);
        }

        private void chkLst_Spells_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {

            Spell spell = new Spell();
            if (chkLst_Spell_list.SelectedItem != null)
            {
                CheckBoxItems selectedItem = ((CheckBoxItems)chkLst_Spell_list.SelectedItem);
                string xmlPath = selectedItem.path;
                Controllers.SpellController sController = new Controllers.SpellController(xmlPath);
                spell = sController.GetSpell(selectedItem.display);
            }
            pnl_Spell.SetValue(spell);
        }
        private void chkLst_Resources_ItemCheck(string sourceXml, DND.Panels.ResourcesPanel destination, List<string> collection, CheckState NewValue)
        {
            foreach (string spell in collection)
            {
                if (NewValue == CheckState.Checked)
                {
                    destination.Items.Add(new CheckBoxItems(sourceXml, spell));
                }
                else
                {
                    object removeObject = new object();
                    foreach (object obj in destination.Items)
                    {
                        if (obj.ToString() == spell)
                        {
                            removeObject = obj;
                            break;
                        }
                    }
                    destination.Items.Remove(removeObject);
                }
            }
        }

        public void Export(string fileName)
        {
            if (chkLst_Spell_list.CheckedItems != null)
            {
                DataTable dt = Spell.GenerateNewTable();
                foreach (CheckBoxItems selectedItem in chkLst_Spell_list.CheckedItems)
                {
                    string xmlPath = selectedItem.path;
                    Controllers.SpellController sController = new Controllers.SpellController(xmlPath);
                    Spell spell = sController.GetSpell(selectedItem.display);
                    DataRow dr = dt.NewRow();
                    spell.PopulateDataRow(ref dr);
                    dt.Rows.Add(dr);
                }

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DND.Controllers.ExcelController excel = new Controllers.ExcelController();
                excel.ExportDataSetToExcel(ds, fileName);

            }
        }
        
        public void Homebrewery(string fileName)
        {
            if (chkLst_Spell_list.CheckedItems != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (CheckBoxItems selectedItem in chkLst_Spell_list.CheckedItems)
                {
                    string xmlPath = selectedItem.path;
                    Controllers.SpellController sController = new Controllers.SpellController(xmlPath);
                    Spell spell = sController.GetSpell(selectedItem.display);
                    sb.AppendLine(spell.BuildHomebrewery());
                }
                System.IO.File.WriteAllText(fileName, sb.ToString());
            }
        }
    }
}
