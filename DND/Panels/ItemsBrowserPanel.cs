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
    public partial class ItemsBrowserPanel : UserControl
    {
        public ItemsBrowserPanel()
        {
            InitializeComponent();
        }
        public void LoadBrowser(string[] List)
        {
            foreach (string source in List)
            {
                chkLst_Items_Resources.Items.Add(new CheckBoxItems(source, System.IO.Path.GetFileName(source)));
            }
        }
        private void chkLst_Items_Resources_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            string xmlPath = ((CheckBoxItems)chkLst_Items_Resources.Items[e.Index]).path;
            Controllers.ItemController sController = new Controllers.ItemController(xmlPath);

            chkLst_Resources_ItemCheck(xmlPath, chkLst_Items_Selected, sController.GetItemList(), e.NewValue);
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
            if (chkLst_Items_Selected.CheckedItems != null)
            {
                DataTable dt = Item.GenerateNewTable();
                foreach (CheckBoxItems selectedItem in chkLst_Items_Selected.CheckedItems)
                {
                    string xmlPath = selectedItem.path;
                    Controllers.ItemController iController = new Controllers.ItemController(xmlPath);
                    Item item = iController.GetItem(selectedItem.display);
                    DataRow dr = dt.NewRow();
                    item.PopulateDataRow(ref dr);
                    dt.Rows.Add(dr);
                }

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DND.Controllers.ExcelController excel = new Controllers.ExcelController();
                excel.ExportDataSetToExcel(ds, fileName);

            }
        }

        private void chkLst_Items_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = new Item();
            if (chkLst_Items_Selected.SelectedItem != null)
            {
                CheckBoxItems selectedItem = ((CheckBoxItems)chkLst_Items_Selected.SelectedItem);
                string xmlPath = selectedItem.path;
                Controllers.ItemController sController = new Controllers.ItemController(xmlPath);
                item = sController.GetItem(selectedItem.display);
            }
            itemPanel1.SetValue(item);
        }

        private void ItemsBrowserPanel_Load(object sender, EventArgs e)
        {

        }
        public void Homebrewery(string fileName)
        {
            if (chkLst_Items_Selected.CheckedItems != null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (CheckBoxItems selectedItem in chkLst_Items_Selected.CheckedItems)
                {
                    string xmlPath = selectedItem.path;
                    Controllers.ItemController sController = new Controllers.ItemController(xmlPath);
                    Item item = sController.GetItem(selectedItem.display);
                    sb.AppendLine(item.BuildHomebrewery());
                }
                System.IO.File.WriteAllText(fileName, sb.ToString());
            }
        }
    }
}
