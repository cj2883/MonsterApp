namespace DND
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnl_Browser_Bestiary = new DND.Panels.BestiaryBrowserPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl_Browser_Items = new DND.Panels.ItemsBrowserPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl_Browser_Spells = new DND.Panels.SpellBrowserPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Homebrewery = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(955, 582);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnl_Browser_Bestiary);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bestiary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnl_Browser_Bestiary
            // 
            this.pnl_Browser_Bestiary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Browser_Bestiary.Location = new System.Drawing.Point(3, 3);
            this.pnl_Browser_Bestiary.Name = "pnl_Browser_Bestiary";
            this.pnl_Browser_Bestiary.Size = new System.Drawing.Size(941, 550);
            this.pnl_Browser_Bestiary.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnl_Browser_Items);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(947, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnl_Browser_Items
            // 
            this.pnl_Browser_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Browser_Items.Location = new System.Drawing.Point(3, 3);
            this.pnl_Browser_Items.Name = "pnl_Browser_Items";
            this.pnl_Browser_Items.Size = new System.Drawing.Size(941, 550);
            this.pnl_Browser_Items.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnl_Browser_Spells);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spells";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnl_Browser_Spells
            // 
            this.pnl_Browser_Spells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Browser_Spells.Location = new System.Drawing.Point(3, 3);
            this.pnl_Browser_Spells.Name = "pnl_Browser_Spells";
            this.pnl_Browser_Spells.Size = new System.Drawing.Size(941, 550);
            this.pnl_Browser_Spells.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Homebrewery);
            this.panel4.Controls.Add(this.btn_Export);
            this.panel4.Controls.Add(this.btn_Cancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 582);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(955, 35);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(768, 6);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(94, 23);
            this.btn_Export.TabIndex = 1;
            this.btn_Export.Text = "Export to Excel";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(868, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Homebrewery
            // 
            this.btn_Homebrewery.Location = new System.Drawing.Point(644, 5);
            this.btn_Homebrewery.Name = "btn_Homebrewery";
            this.btn_Homebrewery.Size = new System.Drawing.Size(118, 23);
            this.btn_Homebrewery.TabIndex = 2;
            this.btn_Homebrewery.Text = "Homebrewery Format";
            this.btn_Homebrewery.UseVisualStyleBackColor = true;
            this.btn_Homebrewery.Click += new System.EventHandler(this.btn_Homebrewery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(955, 617);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "John\'s D&D Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Export;
        private Panels.ItemsBrowserPanel pnl_Browser_Items;
        private Panels.BestiaryBrowserPanel pnl_Browser_Bestiary;
        private Panels.SpellBrowserPanel pnl_Browser_Spells;
        private System.Windows.Forms.Button btn_Homebrewery;
    }
}

