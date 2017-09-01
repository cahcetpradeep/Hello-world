using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    int ind;
    int[] array = new int[50]; 

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ind < 10)
        {
            array[ind] = int.Parse(TextBox1.Text);
            ind++;
        }
        for (int i = 0; i < 10; i++)
        {

            TextBox2.Text = array[i];

        }
        static_poly pos = new static_poly();
        int z=pos.run(5);
        TextBox2.Text = z;

           
       

    }
}