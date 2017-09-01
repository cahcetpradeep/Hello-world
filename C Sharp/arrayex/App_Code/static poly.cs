using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
/// Summary description for static_poly
/// </summary>

sealed abstract class st_poly
{
    public abstract void run(int x) { }
    
}


public class static_poly:st_poly

{
    public override int run(int x)
    {
        int i = x;
        int j=0;
        int z = 0;
        z = i + j;
        return z;


    }



}