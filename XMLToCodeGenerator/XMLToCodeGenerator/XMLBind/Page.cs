using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XMLToCodeGenerator
{
    [XmlInclude(typeof(Page))]
    public class Page
    {
        [XmlAttribute("page-name")]
        public String pageName { set; get; }
        [XmlElement("PageBlocks")]
        public PageBlock pageBlocks { set; get; }
    }
}
