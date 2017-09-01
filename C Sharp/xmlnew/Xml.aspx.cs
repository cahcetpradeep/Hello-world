using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Xml : System.Web.UI.Page
{   //manually Create a Xml file And Append Data to it through Programmatically
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    XmlDocument xmldoc = new XmlDocument();
    //    XmlNode rootNode = xmldoc.CreateElement("users");
    //    xmldoc.AppendChild(rootNode);

    //    XmlNode userNode = xmldoc.CreateElement("user");
    //   // XmlAttribute attribute = xmlDoc.CreateAttribute("age");
    //   // attribute.Value = "40";
    //   // userNode.Attributes.Append(attribute);
    //   // userNode.InnerText = "prabu";
    //    rootNode.AppendChild(userNode);

    //    XmlNode childNode = xmldoc.CreateElement("customer");
    //    XmlAttribute attribute = xmldoc.CreateAttribute("age");
    //    attribute.Value = "39";
    //    childNode.Attributes.Append(attribute);
    //    childNode.InnerText = "Prasanth";
    //    userNode.AppendChild(childNode);

    //    XmlNode userNode1 = xmldoc.CreateElement("user1");
    //    rootNode.AppendChild(userNode1);

    //    XmlNode childNode1 = xmldoc.CreateElement("customer");
    //    XmlAttribute attribute1 = xmldoc.CreateAttribute("age");
    //    attribute1.Value = "40";
    //    childNode1.Attributes.Append(attribute1);
    //    childNode1.InnerText = "Prabu"; 
    //    userNode1.AppendChild(childNode1);

    //    Label1.Text += rootNode.LastChild.InnerText;  //Prabu
    //    Label1.Text += rootNode.FirstChild.InnerText; //Prasanth

    //    // Add Attribute to root element
    //    XmlAttribute attr = xmldoc.CreateAttribute("No");
    //    attr.Value="1001";
    //    rootNode.Attributes.Append(attr);

    //    Label1.Text = rootNode.LocalName;  // users

    //    XmlNode temp = xmldoc.CreateElement("user1");
    //    rootNode.PrependChild(temp);

    //    XmlNode tmp = xmldoc.DocumentElement.FirstChild;
    //    Label1.Text=tmp.InnerText;

    //    xmldoc.Save("E:/C Sharp/xmlnew/XMLFile.xml");

    //    xmldoc.Load("E:/C Sharp/xmlnew/XMLFile.xml");
    //    XmlNode refe=xmldoc.FirstChild;
    //    XmlNode currentConfigNode = refe.SelectSingleNode(".//user1");

    //    refe.InnerText = "pradeep";

    //    xmldoc.Load("E:/C Sharp/xmlnew/XMLFile2.xml");

         
    //    //Label1.Text +=xmldoc.DocumentElement.OuterXml; //return root element and specific value
    //    //Label1.Text += node2.FirstChild.InnerXml;        // return particular node
    //    //Label1.Text = xmldoc.DocumentType.OuterXml;
        

    //}
    //Create a Xml file And Append Data to it through Programmatically

    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load("E:/C Sharp/xmlnew/XMLFile.xml");
        XmlNode xmlnode = xmldoc.FirstChild;
        Label1.Text = xmlnode.InnerText;
        XmlNodeList Xmlchild =xmldoc.SelectNodes("/config");
        
        int xccount = Xmlchild.Count;
        XmlNode Xchild = xmldoc.SelectSingleNode("/Config");
        xmldoc.Save("E:/C Sharp/xmlnew/XMLFile.xml");
    }
}