using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LineCoparisonObj
{
    internal class Length
    {
        public Double FindLength(int x1, int y1 , int x2, int y2) {

            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        
        }
    }
}
