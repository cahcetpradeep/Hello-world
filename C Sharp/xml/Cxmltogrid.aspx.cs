using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
public partial class Cxmltogrid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    // Create a xml file manually
    //Append a data through Programmaticaly
    // display in gridview
    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlTextWriter writer = new XmlTextWriter("E:/C Sharp/xml/demo.xml", System.Text.Encoding.UTF8);
        writer.WriteStartDocument(true);
        writer.Formatting = Formatting.Indented;
        writer.Indentation = 2;
        writer.WriteStartElement("Table");
        createNode("1", "Phone", "15000", writer);
        createNode("2", "AC", "25000", writer);
        createNode("3", "Bike", "75000", writer);
        createNode("4", "House", "50,00,000", writer);
        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Close();
        // For Alert Messsage
        String testing = "xml created";
        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('" + testing + "');", true);
        
        //Append data to Grid View
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("demo.xml"));
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
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

    // Append data to Form view
    protected void Button2_Click(object sender, EventArgs e)
    {
        XmlReader xmlFile;
        xmlFile = XmlReader.Create("E:/C Sharp/xml/demo.xml", new XmlReaderSettings());
        DataSet ds = new DataSet();
        ds.ReadXml(xmlFile);
        FormView1.DataSource = ds.Tables[0];
        FormView1.DataBind();
    }
}