using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class Status
    {
        public string st { get; set; }

        public Status()
        {
            st = "chua lam ";
        }
        public override string ToString()
        {
            return st ;
        }
    }
}
