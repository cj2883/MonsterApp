namespace DND.Panels
{
    partial class BestiaryBrowserPanel
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
            this.pnl_Bestiary = new DND.Panels.BestiaryPanel();
            this.chkLst_Bestiary_Resources = new DND.Panels.ResourcesPanel();
            this.chkLst_Bestiary_Selected = new DND.Panels.ResourcesPanel();
            this.SuspendLayout();
            // 
            // pnl_Bestiary
            // 
            this.pnl_Bestiary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Bestiary.Location = new System.Drawing.Point(326, 0);
            this.pnl_Bestiary.Name = "pnl_Bestiary";
            this.pnl_Bestiary.Size = new System.Drawing.Size(631, 555);
            this.pnl_Bestiary.TabIndex = 6;
            // 
            // chkLst_Bestiary_Resources
            // 
            this.chkLst_Bestiary_Resources.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkLst_Bestiary_Resources.Location = new System.Drawing.Point(0, 0);
            this.chkLst_Bestiary_Resources.Name = "chkLst_Bestiary_Resources";
            this.chkLst_Bestiary_Resources.SelectedItem = null;
            this.chkLst_Bestiary_Resources.Size = new System.Drawing.Size(163, 555);
            this.chkLst_Bestiary_Resources.TabIndex = 7;
            this.chkLst_Bestiary_Resources.ItemCheck += new DND.Panels.ResourcesPanel.ItemCheck_Deligate(this.chkLst_Bestiary_Resources_ItemCheck);
            // 
            // chkLst_Bestiary_Selected
            // 
            this.chkLst_Bestiary_Selected.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkLst_Bestiary_Selected.Location = new System.Drawing.Point(163, 0);
            this.chkLst_Bestiary_Selected.Name = "chkLst_Bestiary_Selected";
            this.chkLst_Bestiary_Selected.SelectedItem = null;
            this.chkLst_Bestiary_Selected.Size = new System.Drawing.Size(163, 555);
            this.chkLst_Bestiary_Selected.TabIndex = 8;
            this.chkLst_Bestiary_Selected.SelectedIndexChanged += new DND.Panels.ResourcesPanel.SelectedIndexChanged_Deligate(this.chkLst_Bestiary_Selected_SelectedIndexChanged);
            // 
            // BestiaryBrowserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Bestiary);
            this.Controls.Add(this.chkLst_Bestiary_Selected);
            this.Controls.Add(this.chkLst_Bestiary_Resources);
            this.Name = "BestiaryBrowserPanel";
            this.Size = new System.Drawing.Size(957, 555);
            this.ResumeLayout(false);

        }

        #endregion
        private BestiaryPanel pnl_Bestiary;
        private ResourcesPanel chkLst_Bestiary_Resources;
        private ResourcesPanel chkLst_Bestiary_Selected;
    }
}
