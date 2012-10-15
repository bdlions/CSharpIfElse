using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XMLToCodeGenerator
{
    [XmlInclude(typeof(PageBlock))]
    public class PageBlock
    {
        [XmlElement("Block")]
        public List<Block> blocks { get; set; }
    }
}
