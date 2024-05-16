using doorang.Core.Models;
using doorang.Core.RepostoryAbstracts;
using doorang.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doorang.Data.RepostoryConcretes
{
    public class ExploreRepostory : GenericRepostory<Explore>, IExploreRepostory
    {
        public ExploreRepostory(AppDbContext context) : base(context)
        {
        }
    }
}
