﻿using Mamba.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Core.RepostoryAbstracts
{
    public interface IGenericRepostory<T> where T : BaseEntity, new()
    {
        void Add(T entity);
        void Remove(T entity);
        T Get(Func<T,bool>func=null);
        List<T> GetAll(Func<T, bool> func = null);
        int Count();

    }
}
