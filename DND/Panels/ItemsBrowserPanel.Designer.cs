namespace DND.Panels
{
    partial class ItemsBrowserPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPanel1 = new DND.Panels.ItemPanel();
            this.chkLst_Items_Resources = new DND.Panels.ResourcesPanel();
            this.chkLst_Items_Selected = new DND.Panels.ResourcesPanel();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Location = new System.Drawing.Point(326, 0);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(639, 603);
            this.itemPanel1.TabIndex = 4;
            // 
            // chkLst_Items_Resources
            // 
            this.chkLst_Items_Resources.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkLst_Items_Resources.Location = new System.Drawing.Point(0, 0);
            this.chkLst_Items_Resources.Name = "chkLst_Items_Resources";
            this.chkLst_Items_Resources.SelectedItem = null;
            this.chkLst_Items_Resources.Size = new System.Drawing.Size(163, 603);
            this.chkLst_Items_Resources.TabIndex = 5;
            this.chkLst_Items_Resources.ItemCheck += new DND.Panels.ResourcesPanel.ItemCheck_Deligate(this.chkLst_Items_Resources_ItemCheck_1);
            // 
            // chkLst_Items_Selected
            // 
            this.chkLst_Items_Selected.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkLst_Items_Selected.Location = new System.Drawing.Point(163, 0);
            this.chkLst_Items_Selected.Name = "chkLst_Items_Selected";
            this.chkLst_Items_Selected.SelectedItem = null;
            this.chkLst_Items_Selected.Size = new System.Drawing.Size(163, 603);
            this.chkLst_Items_Selected.TabIndex = 6;
            this.chkLst_Items_Selected.SelectedIndexChanged += new DND.Panels.ResourcesPanel.SelectedIndexChanged_Deligate(this.chkLst_Items_Selected_SelectedIndexChanged);
            // 
            // ItemsBrowserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.chkLst_Items_Selected);
            this.Controls.Add(this.chkLst_Items_Resources);
            this.Name = "ItemsBrowserPanel";
            this.Size = new System.Drawing.Size(965, 603);
            this.Load += new System.EventHandler(this.ItemsBrowserPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ItemPanel itemPanel1;
        private ResourcesPanel chkLst_Items_Resources;
        private ResourcesPanel chkLst_Items_Selected;
    }
}
