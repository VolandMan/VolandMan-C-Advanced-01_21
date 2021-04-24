using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   
    class Timer
    {
        internal int s;

        public string Time()
        {
            s++;
            return (s >= 60) ? "мин. " + s / 60 + " сек. " + s % 60 : s.ToString();
        }
    }

}
