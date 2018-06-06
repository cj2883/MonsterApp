using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Panels
{
    public partial class ResourcesPanel : UserControl
    {
        public ResourcesPanel()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (int i in Resources.CheckedIndices)
            {
                Resources.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        public CheckedListBox.CheckedItemCollection CheckedItems
        {
            get { return Resources.CheckedItems; }
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Resources.Items.Count; i++)
            {
                Resources.SetItemCheckState(i, CheckState.Checked);
            }
        }
        public System.Windows.Forms.CheckedListBox.ObjectCollection Items
        {
            get { return Resources.Items; }
        }
        public void Add(object item)
        {
            Resources.Items.Add(item);
        }
        public object SelectedItem
        {
            get { return Resources.SelectedItem; }
            set { Resources.SelectedItem = value; }
        }
        
        private void chkLst_Resources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedIndexChanged != null)
                SelectedIndexChanged(sender, e);
        }
        public event SelectedIndexChanged_Deligate SelectedIndexChanged;
        public delegate void SelectedIndexChanged_Deligate(object sender, EventArgs e);
        private void chkLst_Resources_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(ItemCheck != null)
                ItemCheck(sender, e);
        }
        public delegate void ItemCheck_Deligate(object sender, ItemCheckEventArgs e);
        public event ItemCheck_Deligate ItemCheck;
    }
}
