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
    
    // Create a xml file manually
    // Append data manually
    // Display Data in grid view
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("XMLFile.xml"));
        GridView1.DataSource=ds.Tables[0];
        GridView1.DataBind();
    }
}