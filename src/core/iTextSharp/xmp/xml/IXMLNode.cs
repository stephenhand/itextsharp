using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace iTextSharp.xmp.xml
{
    interface IXMLNode
    {
        List<IXMLAttribute> Attributes { get; }
        List<IXMLNode> ChildNodes { get; }
        string Prefix { get; }
        string Name { get; }
        string NamespaceURI { get; }
        string LocalName { get; }
        string Value { get; }
        XmlNodeType NodeType { get; }
        bool HasChildNodes { get; }
    }
}
