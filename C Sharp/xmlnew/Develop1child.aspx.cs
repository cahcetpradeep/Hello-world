using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Data;




public partial class Develop1child : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            XmlDocument xmlDoc = new XmlDocument();
            
            String root = TextBox1.Text;
            XmlNode rootNode = xmlDoc.CreateElement(root);
            
            xmlDoc.AppendChild(rootNode);

            String user = TextBox2.Text;
            XmlNode userNode = xmlDoc.CreateElement(user);

            String Att = TextBox4.Text;
            XmlAttribute attribute = xmlDoc.CreateAttribute(Att);

            attribute.Value = TextBox5.Text;
            // attribute.Value = "40";

            userNode.Attributes.Append(attribute);

            userNode.InnerText = TextBox6.Text;
            //userNode.InnerText = "prabu";
            rootNode.AppendChild(userNode);

            if (TextBox7.Text.Length != 0)
            {

                String user1 = TextBox2.Text;
                XmlNode userNode1 = xmlDoc.CreateElement(user1);

                String Att1 = TextBox4.Text;
                XmlAttribute attribute1 = xmlDoc.CreateAttribute(Att1);

                attribute1.Value = TextBox7.Text;
                // attribute.Value = "40";

                userNode1.Attributes.Append(attribute1);

                userNode1.InnerText = TextBox8.Text;
                //userNode.InnerText = "prabu";
                rootNode.AppendChild(userNode1);
            }

            if (TextBox9.Text.Length != 0)
            {

                String user1 = TextBox2.Text;
                XmlNode userNode1 = xmlDoc.CreateElement(user1);

                String Att1 = TextBox4.Text;
                XmlAttribute attribute1 = xmlDoc.CreateAttribute(Att1);

                attribute1.Value = TextBox9.Text;
                // attribute.Value = "40";

                userNode1.Attributes.Append(attribute1);

                userNode1.InnerText = TextBox10.Text;
                //userNode.InnerText = "prabu";
                rootNode.AppendChild(userNode1);
            }
            if (TextBox11.Text.Length != 0)
            {

                String user1 = TextBox2.Text;
                XmlNode userNode1 = xmlDoc.CreateElement(user1);

                String Att1 = TextBox4.Text;
                XmlAttribute attribute1 = xmlDoc.CreateAttribute(Att1);

                attribute1.Value = TextBox11.Text;
                // attribute.Value = "40";

                userNode1.Attributes.Append(attribute1);

                userNode1.InnerText = TextBox12.Text;
                //userNode.InnerText = "prabu";
                rootNode.AppendChild(userNode1);
            }
        
            xmlDoc.Save("E:/C Sharp/xmlnew/Develop1child.xml");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Updated');", true);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";


        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load("E:/C Sharp/xmlnew/Develop1child.xml");

        String root = TextBox1.Text;
        XmlNode rootNode = xmldoc.CreateElement(root);
        //xmldoc.DocumentElement.AppendChild(rootNode); // Inside Values the parent node
        XmlNode xmloc = xmldoc.LastChild;               // Inside  Values The Parent node following Two line
        xmloc.AppendChild(rootNode);
        
      if(TextBox6.Text.Length != 0)
      {
        
        String user = TextBox2.Text;
        XmlNode userNode = xmldoc.CreateElement(user);

        String Att = TextBox4.Text;
        XmlAttribute attribute = xmldoc.CreateAttribute(Att);

        attribute.Value = TextBox5.Text;
        // attribute.Value = "40";

        userNode.Attributes.Append(attribute);

        userNode.InnerText = TextBox6.Text;
        //userNode.InnerText = "prabu";
        rootNode.AppendChild(userNode);
    }

        if (TextBox8.Text.Length != 0)
        {

            String user1 = TextBox2.Text;
            XmlNode userNode1 = xmldoc.CreateElement(user1);

            String Att1 = TextBox4.Text;
            XmlAttribute attribute1 = xmldoc.CreateAttribute(Att1);

            attribute1.Value = TextBox7.Text;
            // attribute.Value = "40";

            userNode1.Attributes.Append(attribute1);

            userNode1.InnerText = TextBox8.Text;
            //userNode.InnerText = "prabu";
            rootNode.AppendChild(userNode1);
        }

        if (TextBox10.Text.Length != 0)
        {

            String user1 = TextBox2.Text;
            XmlNode userNode1 = xmldoc.CreateElement(user1);

            String Att1 = TextBox4.Text;
            XmlAttribute attribute1 = xmldoc.CreateAttribute(Att1);

            attribute1.Value = TextBox9.Text;
            // attribute.Value = "40";

            userNode1.Attributes.Append(attribute1);

            userNode1.InnerText = TextBox10.Text;
            //userNode.InnerText = "prabu";
            rootNode.AppendChild(userNode1);
        }
        if (TextBox12.Text.Length != 0)
        {

            String user1 = TextBox2.Text;
            XmlNode userNode1 = xmldoc.CreateElement(user1);

            String Att1 = TextBox4.Text;
            XmlAttribute attribute1 = xmldoc.CreateAttribute(Att1);

            attribute1.Value = TextBox11.Text;
            // attribute.Value = "40";

            userNode1.Attributes.Append(attribute1);

            userNode1.InnerText = TextBox12.Text;
            //userNode.InnerText = "prabu";
            rootNode.AppendChild(userNode1);
        }

        xmldoc.Save("E:/C Sharp/xmlnew/Develop1child.xml");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("XMLFile4.xml"));
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

    }
}