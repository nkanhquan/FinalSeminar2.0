using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class Info
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public Info()
        {}
        public Info(Info that)
        {
            this.Name = that.Name;
            this.ID = that.ID;
        }

    }
}
