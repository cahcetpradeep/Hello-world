using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;


public partial class Xml4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        XmlTextReader xReader = new XmlTextReader("E:/C Sharp/xmlnew/XMLFile4.xml");
        while (xReader.Read())
        {
            switch (xReader.NodeType)
            {
                case XmlNodeType.Element:
                    Label2.Text +=("<" + xReader.Name + ">");
                    break;
                case XmlNodeType.Text:
                    Label2.Text += (xReader.Value);
                    break;
                case XmlNodeType.EndElement:
                    Label2.Text += ("")+"<br/>";
                    break;
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        XmlDocument xmldoc = new XmlDocument();
        XmlNodeList xmlnode;
        int i = 0;
        string str = null;

        xmldoc.Load("E:/C Sharp/xmlnew/XMLFile4.xml");
        xmlnode = xmldoc.GetElementsByTagName("Product");
        for (i = 0; i <= xmlnode.Count - 1; i++)
        {
            xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
            str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
            Label1.Text += "<br/> " + (str);
        }
    }
}