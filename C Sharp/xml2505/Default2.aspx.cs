using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public partial class Default2 : System.Web.UI.Page
{
    
   


    protected void Page_Load(object sender, EventArgs e)
    {   
         String ClientId,CountryCode,UserId;
         XmlDocument dataDoc;
         XmlNode ClntId,Cnrycode,UrID,Reffer;
        
         ////Load Xml document
         //var Object1 = JsonConvert.DeserializeObject<dynamic>(new StreamReader(Request.InputStream).ReadToEnd());
         //dataDoc = new XmlDocument();
         
         // /* Load Congiguration File */
         dataDoc = new XmlDocument();
         //dataDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "savaconfig.xml");


         ///* GET CONFIGURATION DETAILS */
         //ClientId = (String)Object1.context.client_id;
         //CountryCode = (String)Object1.context.country_code;
         //UserId = (String)Object1.context.inputparam.user_id;

        ClientId="kobelco";
        CountryCode="vivid";
        UserId="we10";
         
        dataDoc.Load("E:/C Sharp/xml2505/XMLFile.xml"); //

        Reffer = dataDoc.LastChild;
        
        //Check if 
         
      

       
            //if (!dataDoc.ChildNodes[1].HasChildNodes)
            //{
            //    ClntId = dataDoc.CreateElement(ClientId);
            //    dataDoc.DocumentElement.AppendChild(ClntId);

            //    Cnrycode = dataDoc.CreateElement(CountryCode);
            //    dataDoc.DocumentElement.AppendChild(Cnrycode);

            //    UrID = dataDoc.CreateElement(UserId);
            //    dataDoc.DocumentElement.AppendChild(UrID);

            //}
            
                ClntId = dataDoc.CreateElement(ClientId);
                Reffer.AppendChild(ClntId);

                Cnrycode = dataDoc.CreateElement(CountryCode);
                ClntId.AppendChild(Cnrycode);

                UrID = dataDoc.CreateElement(UserId);
                Cnrycode.AppendChild(UrID);
            
            //XmlNodeList nodeList = Reffer.SelectNodes(ClientId);    
        //    foreach (XmlNode node in nodeList)
        //    {
            
        //     if(node[ClientId] != null )
        //    {
        //        ClntId = dataDoc.CreateElement(ClientId);
        //        dataDoc.DocumentElement.AppendChild(ClntId);

        //        Cnrycode = dataDoc.CreateElement(CountryCode);
        //        dataDoc.DocumentElement.AppendChild(Cnrycode);

        //        UrID = dataDoc.CreateElement(UserId);
        //        dataDoc.DocumentElement.AppendChild(UrID);
        //    }
             
        //}

        dataDoc.Save("E:/C Sharp/xml2505/XMLFile.xml");








            }
        }


         

         




