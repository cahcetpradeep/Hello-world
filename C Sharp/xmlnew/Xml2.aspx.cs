using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Xml2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("E:/C Sharp/xmlnew/XMLFile.xml");
        XmlNodeList userNodes = xmlDoc.SelectNodes("//users/users");
        foreach (XmlNode userNode in userNodes)
        {
            int age = int.Parse(userNode.Attributes["age"].Value);
            userNode.Attributes["age"].Value = (age + 1).ToString();
        }
        xmlDoc.Save("E:/C Sharp/xmlnew/XMLFile2.xml");
    }
}