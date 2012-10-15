using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XMLToCodeGenerator
{
    [XmlInclude(typeof(Pages))]
    public class Pages
    {
        [XmlElement("Page")]
        public List<Page> page { get; set; } 
    }
}
