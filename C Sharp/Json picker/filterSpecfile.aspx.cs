using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class filterSpecfile : System.Web.UI.Page
{
    String path = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // int i = 0;
        path = TextBox1.Text;
        DirectoryInfo dr = new DirectoryInfo(path);
        FileInfo[] fi = dr.GetFiles();
        TextBox2.Text = "[";
        int i = 0;
        foreach (FileInfo des in fi)
        {
            int count;
            string[] files = Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);
            count = files.Length;
            if (des.Name.Contains(".json"))
            {
                TextBox2.Text += "''";
                int fileExtPos = des.Name.LastIndexOf(".");
                if (fileExtPos >= 0)
                TextBox2.Text += des.Name.Substring(0, fileExtPos);
                TextBox2.Text += "''";
                i++;
                if (i < count)
                {
                    TextBox2.Text += ",";
                }

            }

        }

        TextBox2.Text += "]";
    }
}