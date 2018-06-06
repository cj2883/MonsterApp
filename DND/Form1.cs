using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND.Models;

namespace DND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controllers.DataSourceController sourceController = new Controllers.DataSourceController();

            pnl_Browser_Spells.LoadBrowser(sourceController.GetSpellDataSources());
            pnl_Browser_Items.LoadBrowser(sourceController.GetItemDataSources());
            pnl_Browser_Bestiary.LoadBrowser(sourceController.GetBestiaryDataSources());
        }
        
        
        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension =true;
            sfd.DefaultExt = ".xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                switch (tabControl.SelectedTab.Text)
                {
                    case "Bestiary":
                        pnl_Browser_Bestiary.Export(fileName);
                        break;
                    case "Items":
                        pnl_Browser_Items.Export(fileName);
                        break;
                    case "Spells":
                        pnl_Browser_Spells.Export(fileName);
                        break;

                }
                MessageBox.Show("Export Complete.");
            }
        }

        private void btn_Homebrewery_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = ".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                switch (tabControl.SelectedTab.Text)
                {
                    case "Bestiary":
                        pnl_Browser_Bestiary.Homebrewery(fileName);
                        break;
                    case "Items":
                        pnl_Browser_Items.Homebrewery(fileName);
                        break;
                    case "Spells":
                        pnl_Browser_Spells.Homebrewery(fileName);
                        break;

                }
                MessageBox.Show("Export Complete.");
            }

        }
    }
}
