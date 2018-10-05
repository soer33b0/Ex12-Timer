using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Timer
{
    public class Timer
    {
        public int Seconds { get; set; }

        public override string ToString()
        {
            int sec = (Seconds % 60); 
            int min = ((Seconds / 60) % 60);
            int hours = (Seconds / 3600);

            return Padded(hours) + ":" + Padded(min) + ":" + Padded(sec);

            /*if(hours.Length < 2)
            {
                hours = "0" + hours;
            }
            
            if(min.Length < 2)
            {
                min = "0" + min;
            }

            if (sec.Length < 2)
            {
                sec = "0" + sec;
            }

            return hours + ":" + min + ":" + sec;*/
        }

        public string Padded(int v)
        {
            string result;

            if (v < 10)
            {
                result = "0" + v;
            }

            else
            {
                return v.ToString();
            }

            return result;
        }
    }
}
