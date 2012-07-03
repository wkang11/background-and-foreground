using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orpheum.objects
{
    static class  sharedNuvixa
    {
        public static object AlphaImage { get; set; }
        public static Int32 Depth { get; set; }
        public static void Init()
        {
            AlphaImage = new object();
            Depth = 0;
        }
        public static Int32 xCoordinate()
        {
            return 0;
        }
        public static Int32 yCoordinate()
        {
            return 0;
        }
    }
}
