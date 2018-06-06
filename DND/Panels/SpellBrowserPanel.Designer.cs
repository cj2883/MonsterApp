namespace DND.Panels
{
    partial class SpellBrowserPanel
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
            this.pnl_Spell = new DND.Panels.SpellPanel();
            this.chkLst_Spell_Resources = new DND.Panels.ResourcesPanel();
            this.chkLst_Spell_list = new DND.Panels.ResourcesPanel();
            this.SuspendLayout();
            // 
            // pnl_Spell
            // 
            this.pnl_Spell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Spell.Location = new System.Drawing.Point(328, 0);
            this.pnl_Spell.Name = "pnl_Spell";
            this.pnl_Spell.Size = new System.Drawing.Size(620, 628);
            this.pnl_Spell.TabIndex = 5;
            // 
            // chkLst_Spell_Resources
            // 
            this.chkLst_Spell_Resources.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkLst_Spell_Resources.Location = new System.Drawing.Point(0, 0);
            this.chkLst_Spell_Resources.Name = "chkLst_Spell_Resources";
            this.chkLst_Spell_Resources.SelectedItem = null;
            this.chkLst_Spell_Resources.Size = new System.Drawing.Size(165, 628);
            this.chkLst_Spell_Resources.TabIndex = 6;
            this.chkLst_Spell_Resources.ItemCheck += new DND.Panels.ResourcesPanel.ItemCheck_Deligate(this.chkLst_Spells_Resources_ItemCheck);
            // 
            // chkLst_Spell_list
            // 
            this.chkLst_Spell_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkLst_Spell_list.Location = new System.Drawing.Point(165, 0);
            this.chkLst_Spell_list.Name = "chkLst_Spell_list";
            this.chkLst_Spell_list.SelectedItem = null;
            this.chkLst_Spell_list.Size = new System.Drawing.Size(163, 628);
            this.chkLst_Spell_list.TabIndex = 7;
            this.chkLst_Spell_list.SelectedIndexChanged += new DND.Panels.ResourcesPanel.SelectedIndexChanged_Deligate(this.chkLst_Spells_Selected_SelectedIndexChanged);
            // 
            // SpellBrowserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Spell);
            this.Controls.Add(this.chkLst_Spell_list);
            this.Controls.Add(this.chkLst_Spell_Resources);
            this.Name = "SpellBrowserPanel";
            this.Size = new System.Drawing.Size(948, 628);
            this.ResumeLayout(false);

        }

        #endregion
        private SpellPanel pnl_Spell;
        private ResourcesPanel chkLst_Spell_Resources;
        private ResourcesPanel chkLst_Spell_list;
    }
}
