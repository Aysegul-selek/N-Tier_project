using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
     interface IGenericDal<T>where T:class
    {
        void Insert(T t);
        List<T> GetListAll();
    }
}
