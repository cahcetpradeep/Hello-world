using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;

public partial class create_xml : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // Create Xml file manually
    // Append data through programmatically

    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlTextWriter writer = new XmlTextWriter("E:/C Sharp/xml/product.xml", System.Text.Encoding.UTF8);
        writer.WriteStartDocument(true);
        writer.Formatting = Formatting.Indented;
        writer.Indentation = 2;
        writer.WriteStartElement("Table");
        createNode("1", "Product 1", "1000", writer);
        createNode("2", "Product 2", "2000", writer);
        createNode("3", "Product 3", "3000", writer);
        createNode("4", "Product 4", "4000", writer);
        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Close();
        // For Alert Messsage
        String testing = "xml created";
        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('" + testing + "');", true);
    }
    private void createNode(string pID, string pName, string pPrice, XmlTextWriter writer)
    {
        writer.WriteStartElement("Product");
        writer.WriteStartElement("Product_id");
        writer.WriteString(pID);
        writer.WriteEndElement();
        writer.WriteStartElement("Product_name");
        writer.WriteString(pName);
        writer.WriteEndElement();
        writer.WriteStartElement("Product_price");
        writer.WriteString(pPrice);
        writer.WriteEndElement();
        writer.WriteEndElement();
    }




}



