using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DND.Controllers
{
    class DataSourceController
    {

        public string[] GetBestiaryDataSources()
        {
            return GetDataSources("Bestiary");
        }
        public string[] GetItemDataSources()
        {
            return GetDataSources("Items");
        }
        public string[] GetSpellDataSources()
        {
            return GetDataSources("Spells");
        }
        private string[] GetDataSources(string folderName)
        {
            string dataSourceName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "DnDResources\\" + folderName);
            return Directory.GetFiles(dataSourceName);
        }
    }
}
