using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


public partial class Default2 : System.Web.UI.Page
{
    string path = " ";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e) //WRITE THE FILE
    {
       path=TextBox1.Text;
       FileStream fs=new FileStream(path,FileMode.Append,FileAccess.Write);
       StreamWriter st=new StreamWriter(fs);
       
       st.Write ("<br/>"+Label1.Text);
       st.Close();
       fs.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)  // READ THE FILE
    {
        path = TextBox1.Text;
        //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
       String Text=" ";
       StreamReader sr = new StreamReader(path);
        do
        {
         Text += sr.ReadLine() +"<br/>";
        } while (sr.Peek() != -1);
        sr.Close();

        Label1.Text = Text;   


    }
}