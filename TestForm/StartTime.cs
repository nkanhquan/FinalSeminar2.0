using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    class StartTime
    {
        public int Minute { get; set; }

        public int Hour { get; set; }

        public StartTime()
        {
            Minute = 0;
            Hour = 0;
        }
        public override string ToString()
        {
            if (Hour > 10)
            {
                if (Minute > 10)
                {
                    return Hour.ToString() + ":" + Minute.ToString();

                }
                else return Hour.ToString() + ":0" + Minute.ToString();

            }
            else
            {
                if (Minute > 10)
                {
                    return "0"+Hour.ToString() + ":" + Minute.ToString();

                }
                else return "0"+Hour.ToString() + ":0" + Minute.ToString();
            }
        }
    }
}
