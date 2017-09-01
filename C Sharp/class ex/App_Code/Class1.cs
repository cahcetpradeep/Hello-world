using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class abclass
{
    public int exe(int  x)
    { return 0;
    }

}
public class execlass : abclass
{
    public int exe(int  a)
    {
        int x = a;
        int y = 0;
        int z = x + y;
        return z;

    }

}
