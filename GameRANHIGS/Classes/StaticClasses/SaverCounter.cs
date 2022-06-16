using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRANHIGS.Classes.StaticClasses
{
    static public class SaverCounter
    {
        static private int opekaCounter = 0;
        static private int orgCounter = 0;
        static private int blagCounter = 0;


        static public int OpekaCounter
        {
            get { return opekaCounter; }
            set { opekaCounter = value; }
        }
        static public int OrgCounter
        {
            get { return orgCounter; }
            set { orgCounter = value; }
        }
        static public int BlagCounter
        {
            get { return blagCounter; }
            set { blagCounter = value; }
        }
    }
}
