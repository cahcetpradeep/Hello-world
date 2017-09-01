using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        XmlReader xmlFile;
        xmlFile = XmlReader.Create("E:/C Sharp/xml/product.xml", new XmlReaderSettings());
        DataSet ds = new DataSet();
        ds.ReadXml(xmlFile);
        

        String testing = "xml created";
        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('" + testing + "');", true);
    }
}