using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DND.Controllers
{
    class BaseController
    {
        internal XmlDocument document;
        public BaseController(string dataSource)
        {
            document = new XmlDocument();
            document.Load(dataSource);
        }
        internal void SetMultiLineValue(ref string value, XmlNodeList nodeList)
        {
            foreach (XmlNode nodeValue in nodeList)
                value += nodeValue.InnerText + Environment.NewLine;
        }
        internal void SetValue(ref string value, XmlNode valueNode)
        {
            if (valueNode != null)
                value = valueNode.InnerText;
        }
    }
}
