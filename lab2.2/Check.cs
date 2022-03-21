using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._2
{
    public class Check
    {
        public static int checkPresence(int x, int y) {
            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) < 625 && y < x && y < -x)
            {
                return 2;
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 625 && y<=0 && y == x) || 
                (Math.Pow(x, 2) + Math.Pow(y, 2) <= 625 && y <= 0 && y == -x) ||
                (Math.Pow(x, 2) + Math.Pow(y, 2) == 625 && y <= 0 && y < x && y < -x))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
