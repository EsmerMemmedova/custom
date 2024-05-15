using Mamba.Core.Models;
using Mamba.Core.RepostoryAbstracts;
using Mamba.Data.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Data.RepostoryConcretes
{
    public class TeamsRepostory : GenericRepostory<Team>, ITeamsRepostory
    {
        public TeamsRepostory(AppDbContext context) : base(context)
        {
        }
    }
}
