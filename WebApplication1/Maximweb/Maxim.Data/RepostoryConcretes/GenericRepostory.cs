﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxim.Core.RepostoryConcretes
{
    internal class GenericRepostory<T> :IGenericRepostory<T> where T: BaseEntity, new()
    {
    }
}
