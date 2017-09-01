using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;
using System.IO;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument xmldoc = new XmlDocument();
        XmlNode rootnode = xmldoc.CreateElement("root");
        xmldoc.AppendChild(rootnode);
        XmlNode childnode = xmldoc.CreateElement("child");
        rootnode.AppendChild(childnode);
        childnode.InnerText = "pradeep";
        XmlAttribute attr = xmldoc.CreateAttribute("id");
        attr.Value = "qwqw";
        childnode.Attributes.Append(attr);
        string str1=xmldoc.Name;
        

        xmldoc.Save("E:/C Sharp/xmlnew/Develop1child.xml");
       


    }
}
