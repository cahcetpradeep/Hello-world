using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;


public partial class All_Attribute : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // Attribute
    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("E:/C Sharp/xmlnew/Xml Attribute.xml");

        XmlNode root = doc.FirstChild;

        //Create a new attribute.
        string ns = root.GetNamespaceOfPrefix("booking");
        XmlNode attr = doc.CreateNode(XmlNodeType.Attribute, "genre", ns);
        attr.Value = "novel";

        //Add the attribute to the document.
        root.Attributes.SetNamedItem(attr);

        String testing = "Updated";
        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('" + testing + "');", true);
        doc.Save("E:/C Sharp/xmlnew/Xml AttributeMod.xml");
    }


    // Child nodes,DocumentElement and HasChildNodes
    protected void Button2_Click(object sender, EventArgs e)
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml("<book ISBN='1-861001-57-5'>" +
                "<title>Java</title>" +
                "<price>499</price>" +
                "</book>");

        XmlNode root = doc.FirstChild;
        

        //Display the contents of the child nodes.
        if (root.HasChildNodes)
        {
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                Label1.Text += (root.ChildNodes[i].InnerText) + "<br/>";
            }
        }
        Label1.Text  +="OuterXml:"+(doc.DocumentElement.OuterXml)+"<br/>";
        Label1.Text += "OuterXml:" + (root.FirstChild.OuterXml) + "<br/>";
    }
}