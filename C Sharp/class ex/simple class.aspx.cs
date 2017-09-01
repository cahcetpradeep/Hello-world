using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class simple_class : System.Web.UI.Page
{
    int x;
    int y;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {   
        x=int.Parse(TextBox1.Text);
        execlass exeob = new execlass();
         y=exeob.exe(x);
        TextBox2.Text=y.ToString();

    }
}