﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.DomainModel
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetItems();

        T GetByCode(string keyWord);
    }
}
