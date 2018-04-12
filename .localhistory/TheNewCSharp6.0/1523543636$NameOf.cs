using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TheNewCSharp6._0
{
   public class NameOf
    {
        public void Add(Point point)
        {
            if(point==null)
                throw new ArgumentNullException(nameof(point));
        }
    }


}
