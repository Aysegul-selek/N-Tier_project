using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IMarkaServices
    {
        void MArkaAdd(Marka marka);
        List<Marka> GetList();
    }
}
