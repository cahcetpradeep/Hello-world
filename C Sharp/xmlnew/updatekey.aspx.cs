using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;


public partial class updatekey : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load("E:/C Sharp/xmlnew/updatekey.xml");

        String Client_id = TextBox1.Text;
        String Country_name = TextBox2.Text;
        String User_id = TextBox3.Text;
        String App_key = TextBox4.Text;

        XmlNode XClient_id, XCountry_name, XUser_id;

    

        XmlNode xmlnode = xmldoc.FirstChild;



           // To Check Existing Child
         if (xmldoc.DocumentElement.FirstChild != null)
          {
             XmlNode Xtemp=xmldoc.DocumentElement;
             if(Xtemp.HasChildNodes)
             {
                 for (int i = 0; i < Xtemp.ChildNodes.Count; i++)
                 {
                     String String1= Xtemp.ChildNodes[i].Name;
                   
                     
                     if(String1==Client_id)
                     {
                         XmlNodeList Xtemp1=Xtemp.ChildNodes[i].ChildNodes;
                         for (int j = 0; j < Xtemp1.Count;j++ )
                         {
                             String Str2 = Xtemp.ChildNodes[i].ChildNodes[j].Name;
                             if (Str2 == Country_name)
                             {
                                 XmlNodeList Xtemp2=Xtemp.ChildNodes[i].ChildNodes[j].ChildNodes;
                                 for (int k = 0; k < Xtemp2.Count; k++)
                                 {
                                     if (Xtemp.ChildNodes[i].ChildNodes[j].ChildNodes[k].Name == User_id)
                                     {
                                         
                                         Xtemp.ChildNodes[i].ChildNodes[j].ChildNodes[k].InnerText=App_key;
                                         break;
                                         
                                     }
                                     else if (Xtemp.ChildNodes[i].ChildNodes[j].ChildNodes[k].Name != User_id)
                                     { 
                                         if((Xtemp2.Count - 1) == k)
                                         {
                                             XUser_id=xmldoc.CreateElement(User_id);
                                             Xtemp.ChildNodes[i].ChildNodes[j].AppendChild(XUser_id);
                                             XUser_id.InnerText = App_key;
                                             break;
                                         }
                                     }
                                 } break;
                             }
                             else if (Str2 != Country_name)
                             {
                                 if ((Xtemp1.Count - 1) == j)
                                 {
                                     XCountry_name = xmldoc.CreateElement(Country_name);
                                     XUser_id = xmldoc.CreateElement(User_id);
                                     Xtemp.ChildNodes[i].AppendChild(XCountry_name);
                                     XCountry_name.AppendChild(XUser_id);
                                     XUser_id.InnerText = App_key;
                                     break;
                                 }
                             }

                         } break;

                     } 

                     else if (String1!=Client_id)
                     {
                         if ((Xtemp.ChildNodes.Count-1) == i)
                         {
                             XClient_id = xmldoc.CreateElement(Client_id);
                             XCountry_name = xmldoc.CreateElement(Country_name);
                             XUser_id = xmldoc.CreateElement(User_id);

                             xmldoc.DocumentElement.AppendChild(XClient_id);
                             XClient_id.AppendChild(XCountry_name);
                             XCountry_name.AppendChild(XUser_id);
                             XUser_id.InnerText = App_key;
                             break;
                         }
                     }

                 }

            }

        }//Creation Of First Child
         else if (!xmlnode.HasChildNodes)
         {
             XClient_id = xmldoc.CreateElement(Client_id);
             XCountry_name = xmldoc.CreateElement(Country_name);
             XUser_id = xmldoc.CreateElement(User_id);

             xmldoc.DocumentElement.AppendChild(XClient_id);
             XClient_id.AppendChild(XCountry_name);
             XCountry_name.AppendChild(XUser_id);
             XUser_id.InnerText = App_key;
         }

        xmldoc.Save("E:/C Sharp/xmlnew/updatekey.xml");
    }
}
