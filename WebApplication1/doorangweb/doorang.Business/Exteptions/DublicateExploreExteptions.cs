using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doorang.Business.Exteptions
{
    internal class DublicateExploreExteptions :Exception
    {
        public DublicateExploreExteptions(string? message) :base(message) { }
        
    }
}
