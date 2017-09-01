using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Xml3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument xmldoc = new XmlDocument();
       // xmldoc.Load("E:/C Sharp/xmlnew/XMLFile2.xml");
        xmldoc.LoadXml("<users><user>InnerText/InnerXml is here</user></users>");
        //Label1.Text=xmldoc.DocumentElement.InnerText+"<br/>";  
        //Label1.Text += xmldoc.DocumentElement.Name+"<br/>";
        Label1.Text += "Inner Xml:"+xmldoc.DocumentElement.InnerXml + "<br/>"; //Same as InnerText
        Label1.Text += "Outer Xml:"+xmldoc.DocumentElement.OuterXml + "<br/>"; 
        //Label1.Text += xmldoc.DocumentElement.InnerText+"<br/>";
        //Label1.Text += xmldoc.DocumentElement.Value+"<br/>";
        if (xmldoc.DocumentElement.Attributes["name"] != null)
            Console.WriteLine(xmldoc.DocumentElement.Attributes["name"].Value);
        if (xmldoc.DocumentElement.Attributes["age"] != null)
            Console.WriteLine(xmldoc.DocumentElement.Attributes["age"].Value);

        
    }
 }
