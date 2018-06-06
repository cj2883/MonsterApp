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
    public partial class BestiaryBrowserPanel : UserControl
    {
        public BestiaryBrowserPanel()
        {
            InitializeComponent();
        }

        private void chkLst_Bestiary_Resources_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string xmlPath = ((CheckBoxItems)chkLst_Bestiary_Resources.Items[e.Index]).path;
            Controllers.CreatureController sController = new Controllers.CreatureController(xmlPath);

            chkLst_Resources_ItemCheck(xmlPath, chkLst_Bestiary_Selected, sController.GetCreatureList(), e.NewValue);
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
        private void chkLst_Bestiary_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            Creature creature = new Creature();
            if (chkLst_Bestiary_Selected.SelectedItem != null)
            {
                CheckBoxItems selectedItem = ((CheckBoxItems)chkLst_Bestiary_Selected.SelectedItem);
                string xmlPath = selectedItem.path;
                Controllers.CreatureController sController = new Controllers.CreatureController(xmlPath);
                creature = sController.GetCreature(selectedItem.display);
            }
            pnl_Bestiary.SetValue(creature);
        }
        public void LoadBrowser(string[] list)
        {
            foreach (string source in list)
            {
                chkLst_Bestiary_Resources.Items.Add(new CheckBoxItems(source, System.IO.Path.GetFileName(source)));
            }
        }
        public void Homebrewery(string fileName)
        {
            if (chkLst_Bestiary_Selected.CheckedItems != null)
            {
                StringBuilder sb = new StringBuilder();
                int lineNumber = 1;
                foreach (CheckBoxItems selectedItem in chkLst_Bestiary_Selected.CheckedItems)
                {
                    if (lineNumber >= 2)
                    {
                        sb.AppendLine(@"\page");
                        lineNumber = 0;
                    }
                    string xmlPath = selectedItem.path;
                    Controllers.CreatureController sController = new Controllers.CreatureController(xmlPath);
                    Creature creature = sController.GetCreature(selectedItem.display);
                    sb.AppendLine(creature.BuildHomebrewery());
                    lineNumber++;
                }
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName);
                
                sw.WriteLine(sb.ToString());
            }
        }
        public void Export(string fileName)
        {
            if (chkLst_Bestiary_Selected.CheckedItems != null)
            {
                DataTable dt = Creature.GenerateNewTable();
                foreach (CheckBoxItems selectedItem in chkLst_Bestiary_Selected.CheckedItems)
                {
                    string xmlPath = selectedItem.path;
                    Controllers.CreatureController sController = new Controllers.CreatureController(xmlPath);
                    Creature creature = sController.GetCreature(selectedItem.display);
                    DataRow dr = dt.NewRow();
                    creature.PopulateDataRow(ref dr);
                    dt.Rows.Add(dr);
                }

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DND.Controllers.ExcelController excel = new Controllers.ExcelController();
                excel.ExportDataSetToExcel(ds, fileName);

            }
        }
    }
}
