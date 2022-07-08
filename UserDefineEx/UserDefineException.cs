using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineEx
{
    internal class UserDefineException:ApplicationException
    {
        public override string Message
        {
            get { return "Attemted to divide by odd number"; }
        }
    }

}
